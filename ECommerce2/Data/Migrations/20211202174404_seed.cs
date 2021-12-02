using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce2.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Product_ID", "Product_Description", "Product_Name", "Product_Photo", "Product_Price" },
                values: new object[] { 1, "Crisp Apple", "Apple", "apple.jpg", 2.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Product_ID", "Product_Description", "Product_Name", "Product_Photo", "Product_Price" },
                values: new object[] { 2, "Sweet Orange", "Orange", "orange.jpg", 1.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Product_ID", "Product_Description", "Product_Name", "Product_Photo", "Product_Price" },
                values: new object[] { 3, "Delicious Pear", "Pear", "pear.jpg", 3.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Product_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Product_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Product_ID",
                keyValue: 3);
        }
    }
}
