﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public bool Login(string username, string password)
        {

            return false;
        }

        private AccountDAO() { }
    }
}
