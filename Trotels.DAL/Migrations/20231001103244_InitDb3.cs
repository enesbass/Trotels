using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trotels.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 13, 32, 44, 913, DateTimeKind.Local).AddTicks(5387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 13, 0, 16, 13, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 13, 32, 44, 913, DateTimeKind.Local).AddTicks(3729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 13, 0, 16, 13, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 13, 32, 44, 913, DateTimeKind.Local).AddTicks(1863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 13, 0, 16, 13, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 13, 32, 44, 913, DateTimeKind.Local).AddTicks(168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 13, 0, 16, 13, DateTimeKind.Local).AddTicks(3032));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 13, 0, 16, 13, DateTimeKind.Local).AddTicks(7984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 13, 32, 44, 913, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 13, 0, 16, 13, DateTimeKind.Local).AddTicks(6359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 13, 32, 44, 913, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 13, 0, 16, 13, DateTimeKind.Local).AddTicks(4636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 13, 32, 44, 913, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 13, 0, 16, 13, DateTimeKind.Local).AddTicks(3032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 13, 32, 44, 913, DateTimeKind.Local).AddTicks(168));
        }
    }
}
