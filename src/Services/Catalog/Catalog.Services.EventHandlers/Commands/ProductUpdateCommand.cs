using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Services.EventHandlers.Commands
{
    public class ProductUpdateCommand : INotification
    {
        [Required]
        public int ProductId { get; set; }
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
