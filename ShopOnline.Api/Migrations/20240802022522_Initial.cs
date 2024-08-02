using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IconCSS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IconCSS", "Name" },
                values: new object[,]
                {
                    { 1, "fas fa-spa", "Beauty" },
                    { 2, "fas fa-couch", "Furniture" },
                    { 3, "fas fa-headphones", "Electronics" },
                    { 4, "fas fa-shoe-prints", "Footwear" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Macoratti" },
                    { 2, "Janice" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "A kit provided by Natura, containing skincare products", "/Imagens/Beleza/Beleza1.png", "Glossier - Beauty Kit", 100m, 100 },
                    { 2, 1, "A kit provided by Curology, containing skincare products", "/Imagens/Beleza/Beleza2.png", "Curology - Skin Care Kit", 50m, 45 },
                    { 3, 1, "A kit provided by Glossier, containing skincare products", "/Imagens/Beleza/Beleza3.png", "Organic Coconut Oil", 20m, 30 },
                    { 4, 1, "A kit provided by Curology, containing skincare products", "/Imagens/Beleza/Beleza4.png", "Schwarzkopf - Skin and Hair Care Kit", 50m, 60 },
                    { 5, 1, "Skin care kit, containing skincare and haircare products", "/Imagens/Beleza/Beleza5.png", "Skin Care Kit", 30m, 85 },
                    { 6, 3, "Air Pods - wireless in-ear earbuds", "/Imagens/Eletronicos/eletronico1.png", "Earbuds", 100m, 120 },
                    { 7, 3, "Golden over-ear headphones - these headphones are not wireless", "/Imagens/Eletronicos/eletronico2.png", "Golden Headphones", 40m, 200 },
                    { 8, 3, "Black over-ear headphones - these headphones are not wireless", "/Imagens/Eletronicos/eletronico3.png", "Black Headphones", 40m, 300 },
                    { 9, 3, "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Imagens/Eletronicos/eletronico4.png", "Sennheiser Digital Camera with Tripod", 600m, 20 },
                    { 10, 3, "Canon Digital Camera - High quality digital camera provided by Canon", "/Imagens/Eletronicos/eletronico5.png", "Canon Digital Camera", 500m, 15 },
                    { 11, 3, "Gameboy - Provided by Nintendo", "/Imagens/Eletronicos/tecnologia6.png", "Nintendo Gameboy", 100m, 60 },
                    { 12, 2, "Very comfortable black leather office chair", "/Imagens/Moveis/moveis1.png", "Black Leather Office Chair", 50m, 212 },
                    { 13, 2, "Very comfortable pink leather office chair", "/Imagens/Moveis/moveis2.png", "Pink Leather Office Chair", 50m, 112 },
                    { 14, 2, "Very comfortable recliner chair", "/Imagens/Moveis/moveis3.png", "Recliner Chair", 70m, 90 },
                    { 15, 2, "Very comfortable silver lounge chair", "/Imagens/Moveis/moveis4.png", "Silver Lounge Chair", 120m, 95 },
                    { 16, 2, "White and blue porcelain table lamp", "/Imagens/Moveis/moveis6.png", "Porcelain Table Lamp", 15m, 100 },
                    { 17, 2, "Office table lamp", "/Imagens/Moveis/moveis7.png", "Office Table Lamp", 20m, 73 },
                    { 18, 4, "Comfortable Puma sneakers in most sizes", "/Imagens/Calcados/calcado1.png", "Puma Sneakers", 100m, 50 },
                    { 19, 4, "Colorful sneakers - available in most sizes", "/Imagens/Calcados/calcado2.png", "Colorful Sneakers", 150m, 60 },
                    { 20, 4, "Blue Nike sneakers - available in most sizes", "/Imagens/Calcados/calcado3.png", "Blue Nike Sneakers", 200m, 70 },
                    { 21, 4, "Colorful Hummel trainers - available in most sizes", "/Imagens/Calcados/calcado4.png", "Colorful Hummel Trainers", 120m, 120 },
                    { 22, 4, "Red Nike sneakers - available in most sizes", "/Imagens/Calcados/calcado5.png", "Red Nike Sneakers", 200m, 100 },
                    { 23, 4, "Birkenstock sandals - available in most sizes", "/Imagens/Calcados/calcado6.png", "Birkenstock Sandals", 50m, 150 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
