using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreApiStarter.Migrations
{
    public partial class addproduct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Title");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "IsComplete", "Price", "Priority", "Title" },
                values: new object[] { 1, new DateTime(2020, 1, 27, 11, 20, 49, 875, DateTimeKind.Local).AddTicks(932), false, 10.5m, 1, "Monitor" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "IsComplete", "Price", "Priority", "Title" },
                values: new object[] { 2, new DateTime(2020, 1, 27, 11, 20, 49, 875, DateTimeKind.Local).AddTicks(1927), false, 15.2m, 3, "USB dirve" });

            migrationBuilder.UpdateData(
                table: "ToDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 27, 11, 20, 49, 873, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "ToDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 27, 11, 20, 49, 874, DateTimeKind.Local).AddTicks(9722));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Products",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "ToDos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 27, 11, 9, 32, 615, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "ToDos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2020, 1, 27, 11, 9, 32, 616, DateTimeKind.Local).AddTicks(7125));
        }
    }
}
