using Catalog.Domain;
using Catalog.Presitence.Database;
using Catalog.Services.EventHandlers.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Services.EventHandlers
{
    class ProductCreateEventHandler : INotificationHandler<ProductCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ProductCreateEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ProductCreateCommand command, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Product
            {
                Name = command.Name,
                Description = command.Description,
                ProductType = command.ProductType,
                UnitOfMeasure = command.UnitOfMeasure,
                PhotoPath = command.PhotoPath,
                PriceOne = command.PriceOne,
                PriceTwo = command.PriceTwo,
                PriceThree = command.PriceThree,
                Iva = command.Iva,
                Ice = command.Ice
            });

            await _context.SaveChangesAsync();
        }
    }
}
