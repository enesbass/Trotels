using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trotels.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initd4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_Email",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(6193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(4515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Guests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(2139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 684, DateTimeKind.Local).AddTicks(9794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 796, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 684, DateTimeKind.Local).AddTicks(8024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 796, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_Email",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(5426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(3687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Guests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(1328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 685, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 796, DateTimeKind.Local).AddTicks(8725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 684, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 796, DateTimeKind.Local).AddTicks(7058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 12, 28, 34, 684, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }
    }
}
