using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Presitence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceOne = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceTwo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceThree = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Iva = table.Column<bool>(type: "bit", nullable: false),
                    Ice = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Description", "Ice", "Iva", "Name", "PhotoPath", "PriceOne", "PriceThree", "PriceTwo", "ProductType", "UnitOfMeasure" },
                values: new object[,]
                {
                    { 1, "P001", "Description for product 1", false, true, "Product 1", null, 455m, 0m, 0m, null, null },
                    { 72, "P0072", "Description for product 72", false, true, "Product 72", null, 188m, 0m, 0m, null, null },
                    { 71, "P0071", "Description for product 71", false, true, "Product 71", null, 759m, 0m, 0m, null, null },
                    { 70, "P0070", "Description for product 70", false, true, "Product 70", null, 449m, 0m, 0m, null, null },
                    { 69, "P0069", "Description for product 69", false, true, "Product 69", null, 448m, 0m, 0m, null, null },
                    { 68, "P0068", "Description for product 68", false, true, "Product 68", null, 235m, 0m, 0m, null, null },
                    { 67, "P0067", "Description for product 67", false, true, "Product 67", null, 720m, 0m, 0m, null, null },
                    { 66, "P0066", "Description for product 66", false, true, "Product 66", null, 226m, 0m, 0m, null, null },
                    { 65, "P0065", "Description for product 65", false, true, "Product 65", null, 319m, 0m, 0m, null, null },
                    { 64, "P0064", "Description for product 64", false, true, "Product 64", null, 342m, 0m, 0m, null, null },
                    { 63, "P0063", "Description for product 63", false, true, "Product 63", null, 784m, 0m, 0m, null, null },
                    { 62, "P0062", "Description for product 62", false, true, "Product 62", null, 770m, 0m, 0m, null, null },
                    { 61, "P0061", "Description for product 61", false, true, "Product 61", null, 664m, 0m, 0m, null, null },
                    { 60, "P0060", "Description for product 60", false, true, "Product 60", null, 933m, 0m, 0m, null, null },
                    { 59, "P0059", "Description for product 59", false, true, "Product 59", null, 282m, 0m, 0m, null, null },
                    { 58, "P0058", "Description for product 58", false, true, "Product 58", null, 139m, 0m, 0m, null, null },
                    { 57, "P0057", "Description for product 57", false, true, "Product 57", null, 484m, 0m, 0m, null, null },
                    { 56, "P0056", "Description for product 56", false, true, "Product 56", null, 181m, 0m, 0m, null, null },
                    { 55, "P0055", "Description for product 55", false, true, "Product 55", null, 728m, 0m, 0m, null, null },
                    { 54, "P0054", "Description for product 54", false, true, "Product 54", null, 969m, 0m, 0m, null, null },
                    { 53, "P0053", "Description for product 53", false, true, "Product 53", null, 620m, 0m, 0m, null, null },
                    { 52, "P0052", "Description for product 52", false, true, "Product 52", null, 204m, 0m, 0m, null, null },
                    { 73, "P0073", "Description for product 73", false, true, "Product 73", null, 832m, 0m, 0m, null, null },
                    { 51, "P0051", "Description for product 51", false, true, "Product 51", null, 526m, 0m, 0m, null, null },
                    { 74, "P0074", "Description for product 74", false, true, "Product 74", null, 627m, 0m, 0m, null, null },
                    { 76, "P0076", "Description for product 76", false, true, "Product 76", null, 722m, 0m, 0m, null, null },
                    { 97, "P0097", "Description for product 97", false, true, "Product 97", null, 754m, 0m, 0m, null, null },
                    { 96, "P0096", "Description for product 96", false, true, "Product 96", null, 455m, 0m, 0m, null, null },
                    { 95, "P0095", "Description for product 95", false, true, "Product 95", null, 192m, 0m, 0m, null, null },
                    { 94, "P0094", "Description for product 94", false, true, "Product 94", null, 831m, 0m, 0m, null, null },
                    { 93, "P0093", "Description for product 93", false, true, "Product 93", null, 987m, 0m, 0m, null, null },
                    { 92, "P0092", "Description for product 92", false, true, "Product 92", null, 798m, 0m, 0m, null, null },
                    { 91, "P0091", "Description for product 91", false, true, "Product 91", null, 990m, 0m, 0m, null, null },
                    { 90, "P0090", "Description for product 90", false, true, "Product 90", null, 994m, 0m, 0m, null, null },
                    { 89, "P0089", "Description for product 89", false, true, "Product 89", null, 637m, 0m, 0m, null, null },
                    { 88, "P0088", "Description for product 88", false, true, "Product 88", null, 715m, 0m, 0m, null, null },
                    { 87, "P0087", "Description for product 87", false, true, "Product 87", null, 455m, 0m, 0m, null, null },
                    { 86, "P0086", "Description for product 86", false, true, "Product 86", null, 187m, 0m, 0m, null, null },
                    { 85, "P0085", "Description for product 85", false, true, "Product 85", null, 571m, 0m, 0m, null, null },
                    { 84, "P0084", "Description for product 84", false, true, "Product 84", null, 764m, 0m, 0m, null, null },
                    { 83, "P0083", "Description for product 83", false, true, "Product 83", null, 444m, 0m, 0m, null, null },
                    { 82, "P0082", "Description for product 82", false, true, "Product 82", null, 752m, 0m, 0m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Description", "Ice", "Iva", "Name", "PhotoPath", "PriceOne", "PriceThree", "PriceTwo", "ProductType", "UnitOfMeasure" },
                values: new object[,]
                {
                    { 81, "P0081", "Description for product 81", false, true, "Product 81", null, 243m, 0m, 0m, null, null },
                    { 80, "P0080", "Description for product 80", false, true, "Product 80", null, 331m, 0m, 0m, null, null },
                    { 79, "P0079", "Description for product 79", false, true, "Product 79", null, 576m, 0m, 0m, null, null },
                    { 78, "P0078", "Description for product 78", false, true, "Product 78", null, 100m, 0m, 0m, null, null },
                    { 77, "P0077", "Description for product 77", false, true, "Product 77", null, 373m, 0m, 0m, null, null },
                    { 75, "P0075", "Description for product 75", false, true, "Product 75", null, 210m, 0m, 0m, null, null },
                    { 98, "P0098", "Description for product 98", false, true, "Product 98", null, 758m, 0m, 0m, null, null },
                    { 50, "P0050", "Description for product 50", false, true, "Product 50", null, 541m, 0m, 0m, null, null },
                    { 48, "P0048", "Description for product 48", false, true, "Product 48", null, 204m, 0m, 0m, null, null },
                    { 22, "P0022", "Description for product 22", false, true, "Product 22", null, 374m, 0m, 0m, null, null },
                    { 21, "P0021", "Description for product 21", false, true, "Product 21", null, 261m, 0m, 0m, null, null },
                    { 20, "P0020", "Description for product 20", false, true, "Product 20", null, 336m, 0m, 0m, null, null },
                    { 19, "P0019", "Description for product 19", false, true, "Product 19", null, 384m, 0m, 0m, null, null },
                    { 18, "P0018", "Description for product 18", false, true, "Product 18", null, 597m, 0m, 0m, null, null },
                    { 17, "P0017", "Description for product 17", false, true, "Product 17", null, 358m, 0m, 0m, null, null },
                    { 16, "P0016", "Description for product 16", false, true, "Product 16", null, 597m, 0m, 0m, null, null },
                    { 15, "P0015", "Description for product 15", false, true, "Product 15", null, 825m, 0m, 0m, null, null },
                    { 14, "P0014", "Description for product 14", false, true, "Product 14", null, 524m, 0m, 0m, null, null },
                    { 13, "P0013", "Description for product 13", false, true, "Product 13", null, 501m, 0m, 0m, null, null },
                    { 12, "P0012", "Description for product 12", false, true, "Product 12", null, 405m, 0m, 0m, null, null },
                    { 11, "P0011", "Description for product 11", false, true, "Product 11", null, 201m, 0m, 0m, null, null },
                    { 10, "P0010", "Description for product 10", false, true, "Product 10", null, 510m, 0m, 0m, null, null },
                    { 9, "P009", "Description for product 9", false, true, "Product 9", null, 340m, 0m, 0m, null, null },
                    { 8, "P008", "Description for product 8", false, true, "Product 8", null, 990m, 0m, 0m, null, null },
                    { 7, "P007", "Description for product 7", false, true, "Product 7", null, 853m, 0m, 0m, null, null },
                    { 6, "P006", "Description for product 6", false, true, "Product 6", null, 521m, 0m, 0m, null, null },
                    { 5, "P005", "Description for product 5", false, true, "Product 5", null, 356m, 0m, 0m, null, null },
                    { 4, "P004", "Description for product 4", false, true, "Product 4", null, 415m, 0m, 0m, null, null },
                    { 3, "P003", "Description for product 3", false, true, "Product 3", null, 493m, 0m, 0m, null, null },
                    { 2, "P002", "Description for product 2", false, true, "Product 2", null, 941m, 0m, 0m, null, null },
                    { 23, "P0023", "Description for product 23", false, true, "Product 23", null, 557m, 0m, 0m, null, null },
                    { 49, "P0049", "Description for product 49", false, true, "Product 49", null, 737m, 0m, 0m, null, null },
                    { 24, "P0024", "Description for product 24", false, true, "Product 24", null, 454m, 0m, 0m, null, null },
                    { 26, "P0026", "Description for product 26", false, true, "Product 26", null, 423m, 0m, 0m, null, null },
                    { 47, "P0047", "Description for product 47", false, true, "Product 47", null, 279m, 0m, 0m, null, null },
                    { 46, "P0046", "Description for product 46", false, true, "Product 46", null, 900m, 0m, 0m, null, null },
                    { 45, "P0045", "Description for product 45", false, true, "Product 45", null, 877m, 0m, 0m, null, null },
                    { 44, "P0044", "Description for product 44", false, true, "Product 44", null, 556m, 0m, 0m, null, null },
                    { 43, "P0043", "Description for product 43", false, true, "Product 43", null, 101m, 0m, 0m, null, null },
                    { 42, "P0042", "Description for product 42", false, true, "Product 42", null, 539m, 0m, 0m, null, null },
                    { 41, "P0041", "Description for product 41", false, true, "Product 41", null, 226m, 0m, 0m, null, null },
                    { 40, "P0040", "Description for product 40", false, true, "Product 40", null, 757m, 0m, 0m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Description", "Ice", "Iva", "Name", "PhotoPath", "PriceOne", "PriceThree", "PriceTwo", "ProductType", "UnitOfMeasure" },
                values: new object[,]
                {
                    { 39, "P0039", "Description for product 39", false, true, "Product 39", null, 765m, 0m, 0m, null, null },
                    { 38, "P0038", "Description for product 38", false, true, "Product 38", null, 270m, 0m, 0m, null, null },
                    { 37, "P0037", "Description for product 37", false, true, "Product 37", null, 837m, 0m, 0m, null, null },
                    { 36, "P0036", "Description for product 36", false, true, "Product 36", null, 475m, 0m, 0m, null, null },
                    { 35, "P0035", "Description for product 35", false, true, "Product 35", null, 176m, 0m, 0m, null, null },
                    { 34, "P0034", "Description for product 34", false, true, "Product 34", null, 365m, 0m, 0m, null, null },
                    { 33, "P0033", "Description for product 33", false, true, "Product 33", null, 685m, 0m, 0m, null, null },
                    { 32, "P0032", "Description for product 32", false, true, "Product 32", null, 975m, 0m, 0m, null, null },
                    { 31, "P0031", "Description for product 31", false, true, "Product 31", null, 291m, 0m, 0m, null, null },
                    { 30, "P0030", "Description for product 30", false, true, "Product 30", null, 997m, 0m, 0m, null, null },
                    { 29, "P0029", "Description for product 29", false, true, "Product 29", null, 305m, 0m, 0m, null, null },
                    { 28, "P0028", "Description for product 28", false, true, "Product 28", null, 182m, 0m, 0m, null, null },
                    { 27, "P0027", "Description for product 27", false, true, "Product 27", null, 857m, 0m, 0m, null, null },
                    { 25, "P0025", "Description for product 25", false, true, "Product 25", null, 232m, 0m, 0m, null, null },
                    { 99, "P0099", "Description for product 99", false, true, "Product 99", null, 337m, 0m, 0m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 14 },
                    { 72, 72, 4 },
                    { 71, 71, 9 },
                    { 70, 70, 17 },
                    { 69, 69, 9 },
                    { 68, 68, 7 },
                    { 67, 67, 1 },
                    { 66, 66, 9 },
                    { 65, 65, 19 },
                    { 64, 64, 19 },
                    { 63, 63, 5 },
                    { 62, 62, 14 },
                    { 61, 61, 12 },
                    { 60, 60, 15 },
                    { 59, 59, 16 },
                    { 58, 58, 18 },
                    { 57, 57, 11 },
                    { 56, 56, 6 },
                    { 55, 55, 12 },
                    { 54, 54, 11 },
                    { 53, 53, 17 },
                    { 52, 52, 14 },
                    { 73, 73, 12 },
                    { 51, 51, 13 },
                    { 74, 74, 16 },
                    { 76, 76, 0 },
                    { 97, 97, 19 },
                    { 96, 96, 18 },
                    { 95, 95, 14 },
                    { 94, 94, 19 },
                    { 93, 93, 10 },
                    { 92, 92, 6 },
                    { 91, 91, 6 },
                    { 90, 90, 1 },
                    { 89, 89, 8 },
                    { 88, 88, 8 },
                    { 87, 87, 7 },
                    { 86, 86, 3 },
                    { 85, 85, 5 },
                    { 84, 84, 0 },
                    { 83, 83, 11 },
                    { 82, 82, 13 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 81, 81, 10 },
                    { 80, 80, 10 },
                    { 79, 79, 11 },
                    { 78, 78, 9 },
                    { 77, 77, 2 },
                    { 75, 75, 12 },
                    { 98, 98, 6 },
                    { 50, 50, 15 },
                    { 48, 48, 7 },
                    { 22, 22, 8 },
                    { 21, 21, 6 },
                    { 20, 20, 5 },
                    { 19, 19, 4 },
                    { 18, 18, 7 },
                    { 17, 17, 11 },
                    { 16, 16, 14 },
                    { 15, 15, 15 },
                    { 14, 14, 17 },
                    { 13, 13, 8 },
                    { 12, 12, 0 },
                    { 11, 11, 14 },
                    { 10, 10, 17 },
                    { 9, 9, 18 },
                    { 8, 8, 1 },
                    { 7, 7, 17 },
                    { 6, 6, 13 },
                    { 5, 5, 14 },
                    { 4, 4, 13 },
                    { 3, 3, 18 },
                    { 2, 2, 3 },
                    { 23, 23, 11 },
                    { 49, 49, 11 },
                    { 24, 24, 19 },
                    { 26, 26, 19 },
                    { 47, 47, 9 },
                    { 46, 46, 5 },
                    { 45, 45, 8 },
                    { 44, 44, 2 },
                    { 43, 43, 5 },
                    { 42, 42, 5 },
                    { 41, 41, 13 },
                    { 40, 40, 7 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 39, 39, 14 },
                    { 38, 38, 7 },
                    { 37, 37, 5 },
                    { 36, 36, 17 },
                    { 35, 35, 7 },
                    { 34, 34, 0 },
                    { 33, 33, 19 },
                    { 32, 32, 4 },
                    { 31, 31, 18 },
                    { 30, 30, 19 },
                    { 29, 29, 15 },
                    { 28, 28, 2 },
                    { 27, 27, 0 },
                    { 25, 25, 16 },
                    { 99, 99, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductInStockId",
                table: "Stocks",
                column: "ProductInStockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
