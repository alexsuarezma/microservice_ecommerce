using MediatR;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Identity.Service.EventHandler.Commands
{
    public class UserCreateCommand : IRequest<IdentityResult>
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        [Required]
        public string CompanyId { get; set; }
    }
}
