﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserApp:IdentityUser
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}
