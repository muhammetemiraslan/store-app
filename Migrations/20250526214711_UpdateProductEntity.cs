using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHome",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "IsHome" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", "1.jpeg", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "IsHome" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", "2.jpeg", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "IsHome" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", "3.jpeg", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "IsHome" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", "4.jpeg", false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "IsHome" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", "5.jpeg", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Image", "IsActive", "IsHome", "ProductName" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", "6.jpeg", false, false, "Apple Watch 12" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "IsActive", "IsHome", "Price", "ProductName" },
                values: new object[,]
                {
                    { 7, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", "7.jpeg", true, true, 70000.0, "Apple Watch 13" },
                    { 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", "8.jpeg", false, false, 80000.0, "Apple Watch 14" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsHome",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsActive", "ProductName" },
                values: new object[] { true, "Apple Watch 22" });
        }
    }
}
