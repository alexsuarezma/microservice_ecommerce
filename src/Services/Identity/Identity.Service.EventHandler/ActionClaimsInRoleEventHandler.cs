using Identity.Domain;
using Identity.Persistence.Database;
using Identity.Service.EventHandler.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using static Identity.Common.Enums;

namespace Identity.Service.EventHandler
{
    public class ActionClaimsInRoleEventHandler : INotificationHandler<ActionClaimsInRoleCommand>
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public ActionClaimsInRoleEventHandler(RoleManager<ApplicationRole> roleManager, ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }

        public async Task Handle(ActionClaimsInRoleCommand request, CancellationToken cancellationToken)
        {
            var adminRole =  _roleManager.Roles.FirstOrDefault(x => x.Id == request.roleId);

            foreach (string claimId in request.claimsId)
            {
                var claim = _context.ApplicationClaims.SingleOrDefault(x => x.Id == claimId);

                if(request.action == AgregateRemoveAction.Agregate)
                {
                    await _roleManager.AddClaimAsync(adminRole, new Claim(CustomClaimTypes.Permission, claim.Name));
                }
                else
                {
                    await _roleManager.RemoveClaimAsync(adminRole, new Claim(CustomClaimTypes.Permission, claim.Name));
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
