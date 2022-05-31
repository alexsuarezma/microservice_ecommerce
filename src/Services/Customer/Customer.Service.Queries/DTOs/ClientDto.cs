namespace Customer.Service.Queries.DTOs
{
    public class ClientDto
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }
        public string ClientType { get; set; }
        public bool SpecialContribuyent { get; set; }
        //public Category Category { get; set; }
        public string Ruc { get; set; }
        public string Dni { get; set; }
        public string SocialReason { get; set; }
        public string BussinesName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool ResidentForeign { get; set; }
        public string Email { get; set; }
        public decimal InitialBalance { get; set; }
        public string Salesman { get; set; }
        public decimal DefaultPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal CreditLimit { get; set; }
        public string Bank { get; set; }
        public string TypeOfBankAccount { get; set; }
        public string BankAccountNumber { get; set; }
    }
}
