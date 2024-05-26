using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PotionShop.Migrations
{
    /// <inheritdoc />
    public partial class inisisl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Property = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    WarehouseLocation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Result = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    WarehouseLocation = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Potions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PowerLevel = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    WarehouseLocation = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Potions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Potions_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "Property", "Stock", "WarehouseLocation" },
                values: new object[,]
                {
                    { 1, "Hazlenut", 6, 50, 0 },
                    { 2, "Mandrake Root", 8, 30, 6 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "IngredientId", "Result", "Stock", "WarehouseLocation" },
                values: new object[,]
                {
                    { 1, 1, "Charmcaster Elixir", 50, 0 },
                    { 2, 1, "Love Elixir", 0, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Potions_RecipeId",
                table: "Potions",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_IngredientId",
                table: "Recipes",
                column: "IngredientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Potions");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
