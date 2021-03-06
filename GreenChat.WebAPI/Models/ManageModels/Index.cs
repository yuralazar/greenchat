﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace GreenChat.WebAPI.Models.ManageModels
{
    public class Index
    {
        public bool HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }

        public string PhoneNumber { get; set; }

        public bool TwoFactor { get; set; }

        public bool BrowserRemembered { get; set; }
    }
}
