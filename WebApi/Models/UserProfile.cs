﻿using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace WebApi.Models
{
    public class UserProfile : IUser<Guid>
    {
        // Implementation of IUser<Guid>
        public Guid Id { get; set; }
        public string UserName { get; set; }

        // Customize user's profile data
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // UserPasswordStore
        public string Password { get; set; }

        // UserSecurityStampStore
        public string SecurityStamp { get; set; }

        // UserEmailStore
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }

        // UserClaimStore
        public List<UserClaim> Claims { get; set; } = new List<UserClaim>();
    }
}
