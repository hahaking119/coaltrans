﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coal.BLL
{
    public class LoginContext
    {
        public static User CurrentUser;

        public class User
        {
            public int UserId { get; set; }
        }
    }
}
