using Customer.Domain;
using Customer.Persistence.Database;
using Customer.Service.EventHandlers.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Service.EventHandlers
{
    public class ClientCreateEventHandler :
        INotificationHandler<ClientCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ClientCreateEventHandler(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ClientCreateCommand notification, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Client
            {
                Name = notification.Name,
                State = notification.State,
                ClientType = notification.ClientType,
                SpecialContribuyent = notification.SpecialContribuyent,
                Ruc = notification.Ruc,
                Dni = notification.Dni,
                SocialReason = notification.SocialReason,
                BussinesName = notification.BussinesName,
                Phone = notification.Phone,
                Address = notification.Address,
                ResidentForeign = notification.ResidentForeign,
                Email = notification.Email
            });

            await _context.SaveChangesAsync();
        }
    }
}
