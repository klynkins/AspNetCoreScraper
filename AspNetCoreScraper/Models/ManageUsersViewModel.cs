using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreScraper.Models;
using AspNetCoreScraper.Controllers;
using Microsoft.AspNetCore.Identity;
namespace AspNetCoreScraper.Models
{
    public class ManageUsersViewModel
    {
        public IdentityUser[] Administrators { get; set; }
        public IdentityUser[] Everyone { get; set; }
    }
}
