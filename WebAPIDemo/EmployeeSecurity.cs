﻿using EmployeeDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (EmployeeDBEntities entites = new EmployeeDBEntities())
            {
                return entites.Users.Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && user.Password == password);
            }
        }
    }
}