using MediatR;
using Order.Domain;
using System;
using System.Collections.Generic;
using static Order.Common.Enums;

namespace Order.Service.EventHandlers.Commands
{
    public class OrderCreateCommand : INotification
    {
        public OrderPayment PaymentType { get; set; }
        public int ClientId { get; set; }
        public string Salesman { get; set; }
        public string DocumentType { get; set; }
        public string Description { get; set; }
        public string DocumentNumber { get; set; }
        public string Reference { get; set; }
        public string Autorization { get; set; }
        public OrderStatus Status { get; set; }
        public string AttachedFilePath { get; set; }
        public decimal AdditionalDiscount { get; set; }
        public decimal Total { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<OrderCreateDetail> Items { get; set; } = new List<OrderCreateDetail>();
    }

    public class OrderCreateDetail : OrderDetail
    {
    }
}
