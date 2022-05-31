using Identity.Domain;
using Identity.Service.EventHandler.Commands;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.EventHandler
{
    public class UserUpdateEventHandler
    : IRequestHandler<UserUpdateCommand, IdentityResult>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserUpdateEventHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(UserUpdateCommand notification, CancellationToken cancellationToken)
        {
            var user = _userManager.Users.SingleOrDefault(x => x.Id == notification.Id);

            if (user == null)
            {
                //devolver notfound
                throw new Exception("No existe el usuario al que intenta acceder.");
            }

            user.PhoneNumber = notification.Phone;
            user.FirstName = notification.FirstName;
            user.LastName = notification.LastName;
            user.Email = notification.Email;
            user.Address = notification.Address;
            user.CompanyId = notification.CompanyId;

            return await _userManager.UpdateAsync(user);
        }
    }
}
