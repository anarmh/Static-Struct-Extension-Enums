using Service.Helpers;
using Service.Implementation;
using System;

namespace Login_verification_by_role
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account();

            account.Login("test@code.edu.az ", "test12345", 1);
            
        }
    }
}
