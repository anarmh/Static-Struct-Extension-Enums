using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IAccount
    {
       void Login(string email,string password,int roleId);
    }
}
