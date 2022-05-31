using Microsoft.EntityFrameworkCore.Migrations;

namespace Customer.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Customer");

            migrationBuilder.CreateTable(
                name: "Clients",
                schema: "Customer",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    ClientType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialContribuyent = table.Column<bool>(type: "bit", nullable: false),
                    Ruc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BussinesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidentForeign = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salesman = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfBankAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                schema: "Customer",
                table: "Clients",
                columns: new[] { "ClientId", "Address", "Bank", "BankAccountNumber", "BussinesName", "ClientType", "CreditLimit", "DefaultPrice", "Discount", "Dni", "Email", "InitialBalance", "Name", "Phone", "ResidentForeign", "Ruc", "Salesman", "SocialReason", "SpecialContribuyent", "State", "TypeOfBankAccount" },
                values: new object[,]
                {
                    { 1, null, null, null, "Client Bussines 1", null, 0m, 0m, 0m, null, null, 0m, "Client 1", null, false, null, null, "Client Social 1", false, false, null },
                    { 2, null, null, null, "Client Bussines 2", null, 0m, 0m, 0m, null, null, 0m, "Client 2", null, false, null, null, "Client Social 2", false, false, null },
                    { 3, null, null, null, "Client Bussines 3", null, 0m, 0m, 0m, null, null, 0m, "Client 3", null, false, null, null, "Client Social 3", false, false, null },
                    { 4, null, null, null, "Client Bussines 4", null, 0m, 0m, 0m, null, null, 0m, "Client 4", null, false, null, null, "Client Social 4", false, false, null },
                    { 5, null, null, null, "Client Bussines 5", null, 0m, 0m, 0m, null, null, 0m, "Client 5", null, false, null, null, "Client Social 5", false, false, null },
                    { 6, null, null, null, "Client Bussines 6", null, 0m, 0m, 0m, null, null, 0m, "Client 6", null, false, null, null, "Client Social 6", false, false, null },
                    { 7, null, null, null, "Client Bussines 7", null, 0m, 0m, 0m, null, null, 0m, "Client 7", null, false, null, null, "Client Social 7", false, false, null },
                    { 8, null, null, null, "Client Bussines 8", null, 0m, 0m, 0m, null, null, 0m, "Client 8", null, false, null, null, "Client Social 8", false, false, null },
                    { 9, null, null, null, "Client Bussines 9", null, 0m, 0m, 0m, null, null, 0m, "Client 9", null, false, null, null, "Client Social 9", false, false, null },
                    { 10, null, null, null, "Client Bussines 10", null, 0m, 0m, 0m, null, null, 0m, "Client 10", null, false, null, null, "Client Social 10", false, false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients",
                schema: "Customer");
        }
    }
}
