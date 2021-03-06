﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GreenChat.WebAPI.Models.ManageModels
{
    public class ConfigureTwoFactor
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }
    }
}
