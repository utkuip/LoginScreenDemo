using LoginScreenDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginScreenDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        List<User> user = new List<User>();

        public SignupPage()
        {
            
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            lblLoginPassword.TextColor = Constants.textColor;
            lblLoginUsername.TextColor = Constants.textColor;
            lblSignPassword.TextColor = Constants.textColor;
            lblSignUsername.TextColor = Constants.textColor;
        }

        void signUp(Object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(entrySignUsername.Text) && !string.IsNullOrEmpty(entrySignPassword.Text))
            {
                user.Add(new User(entrySignUsername.Text, entrySignPassword.Text));
                
                DisplayAlert("Congratulation!", "You signed up.", "DONE");
                
                
            }
            else
            {
                DisplayAlert("Sign up failed.", "Username or password is empty. Try again.", "DONE");

            }
            entrySignUsername.Text = string.Empty;
            entrySignPassword.Text = string.Empty;


        }

        void logIn(Object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryLoginUsername.Text) && !string.IsNullOrEmpty(entryLoginPassword.Text))
            {
                if (!checkUsername(entryLoginUsername.Text))
                {
                    DisplayAlert("Login failed.", "Username is wrong or not signed. Please try again.", "DONE");
                }else if(!checkPassword(entryLoginPassword.Text))
                {
                    DisplayAlert("Login failed.", "Password is wrong, please try again.", "DONE");
                }else
                    DisplayAlert("Congratulation!", "You loged in.", "DONE");
            }
            else
            {
                DisplayAlert("Login failed.", "Username or password is empty. Try again.", "DONE");

            }
        }

        bool checkUsername(String username)
        {
            bool isFound = false; 
            for (Int32 i = 0; i < user.Count; i++)
            {
                if(user[i].getUsername() == username)
                {
                    isFound = true;
                    break;
                }
                
            }

            return isFound;
        }

        bool checkPassword(String password)
        {
            bool isFound = false;
            for (Int32 i = 0; i < user.Count; i++)
            {
               
                if (user[i].getPassword() == password)
                {
                    isFound = true;
                    break;
                }

            }

            return isFound;
        }


    }
}
         


