namespace Order.Domain
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int SecuenceInOrder { get; set; }
        public int ProductId { get; set; }
        public int ProductDescription{ get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Ice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
    }
}
