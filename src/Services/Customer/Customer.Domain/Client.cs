using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Customer.Domain
{
    //[Index(nameof(Dni), nameof(Ruc))]
    public class Client
    {
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool State { get; set; }
        public string ClientType { get; set; }
        public bool SpecialContribuyent { get; set; }
        //public Category Category { get; set; }
        public string Ruc { get; set; }
        public string Dni { get; set; }
        [Required]
        public string SocialReason { get; set; }
        [Required]
        public string BussinesName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool ResidentForeign { get; set; }
        public string Email { get; set; }
        public decimal InitialBalance{ get; set; }
        public string Salesman { get; set; }
        public decimal DefaultPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal CreditLimit { get; set; }
        public string Bank { get; set; }
        public string TypeOfBankAccount { get; set; }
        public string BankAccountNumber { get; set; }
    }
}
