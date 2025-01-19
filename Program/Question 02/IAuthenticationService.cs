﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Question_02
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string username ,string  password);
        bool AuthorizeUser(string username, string role);
    }
}
