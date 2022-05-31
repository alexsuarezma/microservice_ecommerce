using Identity.Service.EventHandler.Responses;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Identity.Service.EventHandler.Commands
{
    public class UserLoginCommand : IRequest<IdentityAccess>
    {
        [Required]//, EmailAddress]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
