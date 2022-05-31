using Catalog.Domain;
using MediatR;

namespace Catalog.Services.EventHandlers.Commands
{
    public class ProductCreateCommand : INotification
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string ProductType { get; set; }
        public string UnitOfMeasure { get; set; }
        public string PhotoPath { get; set; }
        public decimal PriceOne { get; set; }
        public decimal PriceTwo { get; set; }
        public decimal PriceThree { get; set; }
        public bool Iva { get; set; }
        public bool Ice { get; set; }
    }
}
