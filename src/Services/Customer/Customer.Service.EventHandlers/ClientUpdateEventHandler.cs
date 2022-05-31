using Customer.Persistence.Database;
using Customer.Service.EventHandlers.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Service.EventHandlers
{
    public class ClientUpdateEventHandler : INotificationHandler<ClientUpdateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ClientUpdateEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ClientUpdateCommand notification, CancellationToken cancellationToken)
        {
            var client = _context.Clients.FirstOrDefault(x => x.ClientId == notification.ClientId);

            if (client == null)
            {
                //devolver notfound
                throw new Exception("No existe el cliente al que intenta acceder.");
            }

            client.Name = notification.Name;
            client.State = notification.State;
            client.ClientType = notification.ClientType;
            client.SpecialContribuyent = notification.SpecialContribuyent;
            client.Ruc = notification.Ruc;
            client.Dni = notification.Dni;
            client.SocialReason = notification.SocialReason;
            client.BussinesName = notification.BussinesName;
            client.Phone = notification.Phone;
            client.Address = notification.Address;
            client.ResidentForeign = notification.ResidentForeign;
            client.Email = notification.Email;

            await _context.SaveChangesAsync();
        }
    }
}
