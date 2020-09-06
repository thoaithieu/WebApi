﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DAL.Entities
{
    public class UserRole
    {
        public const string Admin = "Admin";
        public const string User = "User";
        public static AuthorizationPolicy AdminPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(Admin).Build();
        }
        public static AuthorizationPolicy UserPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(User).Build();
        }
    }
}
