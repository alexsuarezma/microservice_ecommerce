using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Identity.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Username { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string CompanyId { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
