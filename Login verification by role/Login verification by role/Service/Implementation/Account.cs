using Service.Helpers;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Implementation
{
    public class Account : IAccount
    {
        

        public void Login (string email,string password,int roleId)
        {
            if(email!= "test@code.edu.az " || password!= "test12345")
            {
                Console.WriteLine("please correct the email or password");
            }
            if(roleId != (int)Roles.SuperAdmin)
            {
                Console.WriteLine("You do not have permission to enter");
            }
            if (email == "test@code.edu.az " && password == "test12345" && roleId == (int)Roles.SuperAdmin)
            {
                Console.WriteLine("login is successful");
            }
            return;
        }
    }
}
