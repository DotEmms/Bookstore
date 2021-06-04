using Bookstore.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string FavoriteBook { get; set; }
        public Genre FavoriteGenre { get; set; }
        public virtual DateTime RegisteredSince { get; set; } = DateTime.Now;
    }
}
