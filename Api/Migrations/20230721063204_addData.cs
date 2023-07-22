using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Color", "Created", "Name", "Updated", "Weight" },
                values: new object[] { 1, 2.0, "Gato", "Amarillo", new DateTime(2023, 7, 21, 2, 32, 4, 799, DateTimeKind.Local).AddTicks(9410), "Sam", new DateTime(2023, 7, 21, 2, 32, 4, 799, DateTimeKind.Local).AddTicks(9440), 4f });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Color", "Created", "Name", "Updated", "Weight" },
                values: new object[] { 2, 1.0, "Gato", "Blanco", new DateTime(2023, 7, 21, 2, 32, 4, 799, DateTimeKind.Local).AddTicks(9444), "Lucas", new DateTime(2023, 7, 21, 2, 32, 4, 799, DateTimeKind.Local).AddTicks(9446), 2f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
