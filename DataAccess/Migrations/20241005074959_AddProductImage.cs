using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "https://static1.squarespace.com/static/5c56a66665019fdb54fb83be/t/637f1fd84aea254bc9a93a25/1669275613716/GOOGLE_PIXEL_7PRO_MAIN.jpg?format=1500w");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "https://cdn.new-brz.net/app/public/models/MQ183SX-A/large/w/221108190028339335.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "https://world-smartphones.com.ua/image/data/phones/Motorola/Moto-G8-Power/motorola-moto-g8-power-prev.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "https://stark.kiev.ua/wa-data/public/shop/products/24/24/2424/images/1080/1080.970.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "https://belker.com.ua/content/images/14/536x536l50nn0/besprovodnye-naushniki-xiaomi-redmi-airdots-black-zbw4480gl-16031737044081.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Products");
        }
    }
}
