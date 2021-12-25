using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IsTeYazilim.Models
{
    public class WebUser: IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }

        [PersonalData]
        public string Surname { get; set; }

        [PersonalData]
        public string Address { get; set; }

        [PersonalData]
        public DateTime DateOfBirth { get; set; }
    }
}
