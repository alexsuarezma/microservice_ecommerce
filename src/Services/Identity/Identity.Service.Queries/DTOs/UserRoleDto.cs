using Identity.Domain;

namespace Identity.Service.Queries.DTOs
{
    public class UserRoleDto
    {
        public ApplicationRole Role { get; set; }
        public ApplicationUser User { get; set; }
    }
}
