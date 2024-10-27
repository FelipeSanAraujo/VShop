using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VShop.ProductApi.Migrations
{
    public partial class PopulandoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId) values('Tênis Nike', 350.89, 'Tênis de corrida', 10, 'tenis1.jpg', 2)");
            migrationBuilder
                .Sql("insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId) values('Tênis Adidas', 550.89, 'Tênis de treino', 15, 'tenis2.jpg', 2)");
            migrationBuilder
                .Sql("insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId) values('Camisa Lascoste', 150.89, 'Camisa casual', 30, 'camisa.jpg', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("delete from Products");
        }
    }
}
