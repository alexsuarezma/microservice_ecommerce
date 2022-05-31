using Catalog.Domain;
using Catalog.Presitence.Database;
using Catalog.Services.EventHandlers.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Services.EventHandlers
{
    public class ProductUpdateEventHandler : INotificationHandler<ProductUpdateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ProductUpdateEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ProductUpdateCommand notification, CancellationToken cancellationToken)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == notification.ProductId);

            if (product == null)
            {
                //devolver notfound
                throw new Exception("No existe el producto al que intenta acceder.");
            }

            product.Name = notification.Name;
            product.Code = notification.Code;
            product.Description = notification.Description;
            product.ProductType = notification.ProductType;
            product.UnitOfMeasure = notification.UnitOfMeasure;
            product.PhotoPath = notification.PhotoPath;
            product.PriceOne = notification.PriceOne;
            product.PriceTwo = notification.PriceTwo;
            product.PriceThree = notification.PriceThree;
            product.Iva = notification.Iva;
            product.Ice = notification.Ice;

            await _context.SaveChangesAsync();
        }
    }
}
