using System;
using System.Collections.Generic;
using System.Text;

namespace LoginScreenDemo.Models
{
    public class User
    {
        //public static int userCount = 0;
        private String username;
        private String password;

        public User(String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        

        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }


        


    }
}
