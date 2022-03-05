﻿using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AddUserBusiness
    {
        public void SaveUser(AddUserDetailsModel addUser)
        {
            AddUserData userData = new AddUserData();
            userData.SaveUserData(addUser);
        }
        public List<AddUserDetailsModel> GetUserDetails()
        {
            AddUserData userData = new AddUserData();
            return userData.GetUserData();
        }
    }
}
