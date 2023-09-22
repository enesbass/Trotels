using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Trotels.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDb5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guests_Phone",
                table: "Guests");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 12, 42, 30, 133, DateTimeKind.Local).AddTicks(505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(8761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Guests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Guests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(6107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(3654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 684, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(1943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 684, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "Adress", "City", "Country", "Email", "FirstName", "Gender", "GuestAmount", "LastName", "Password", "Phone", "TcNo" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "Ali@gmail.com", "Ali", null, null, "Yılmaz", "ali123", null, null },
                    { 2, null, null, null, null, "Veli@gmail.com", "Veli", null, null, "Kaya", "veli123", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guests_Phone",
                table: "Guests",
                column: "Phone",
                unique: true,
                filter: "[Phone] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guests_Phone",
                table: "Guests");

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(6193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 12, 42, 30, 133, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(4515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Guests",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Guests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(2139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 684, DateTimeKind.Local).AddTicks(9794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 684, DateTimeKind.Local).AddTicks(8024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.CreateIndex(
                name: "IX_Guests_Phone",
                table: "Guests",
                column: "Phone",
                unique: true);
        }
    }
}
