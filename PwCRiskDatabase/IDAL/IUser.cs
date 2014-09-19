using PwCRiskDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PwCRiskDatabase.IDAL
{
    public interface IUser
    {
        User[] GetUsers();
        User GetUserById(int UserId);
        User GetUserByName(String UserName);
    }
}