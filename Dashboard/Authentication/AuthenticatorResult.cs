﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Authentication
{
    public class AuthenticationResult
    {
        public bool IsAuthenticated { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserImage { get; set; }
        public AuthenticationResult? AuthResult { get; internal set; }
        // You can add other properties as needed based on your requirements
    }
}

