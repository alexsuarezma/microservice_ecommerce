using Identity.Domain;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Identity.Service.Queries.DTOs
{
    public class RoleDto
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
