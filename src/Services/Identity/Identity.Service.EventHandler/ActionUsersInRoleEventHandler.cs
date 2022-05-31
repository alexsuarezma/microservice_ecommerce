using Identity.Domain;
using Identity.Persistence.Database;
using Identity.Service.EventHandler.Commands;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Identity.Common.Enums;

namespace Identity.Service.EventHandler
{
    public class ActionUsersInRoleEventHandler : INotificationHandler<ActionUsersInRoleCommand>
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public ActionUsersInRoleEventHandler(RoleManager<ApplicationRole> roleManager, ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }
        public async Task Handle(ActionUsersInRoleCommand command, CancellationToken cancellationToken)
        {
            var adminRole = _context.Roles.FirstOrDefault(x => x.Id == command.roleId);

            foreach (string userId in command.userId)
            {
                var user = _context.Users.SingleOrDefault(x => x.Id == userId);

                if (command.action == AgregateRemoveAction.Agregate)
                {
                    _context.UserRoles.Add(new ApplicationUserRole
                     {
                        UserId = userId,
                        RoleId = adminRole.Id
                    });
                }
                else
                {
                    _context.UserRoles.Remove(new ApplicationUserRole
                    {
                        UserId = userId,
                        RoleId = adminRole.Id
                    });
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
