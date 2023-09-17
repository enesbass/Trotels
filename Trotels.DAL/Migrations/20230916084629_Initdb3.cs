using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trotels.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initdb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(5426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(3687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Guests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(1328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 796, DateTimeKind.Local).AddTicks(8725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 796, DateTimeKind.Local).AddTicks(7058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(1662));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(9363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(7766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Guests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(5573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 797, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(3355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 796, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(1662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 46, 29, 796, DateTimeKind.Local).AddTicks(7058));
        }
    }
}
