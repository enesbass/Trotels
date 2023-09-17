using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trotels.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initdb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(9363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 21, 34, 601, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(7766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 21, 34, 601, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Guests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(5573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 21, 34, 600, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(3355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 21, 34, 600, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(1662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 21, 34, 600, DateTimeKind.Local).AddTicks(1916));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Rooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 21, 34, 601, DateTimeKind.Local).AddTicks(3242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hotels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 21, 34, 601, DateTimeKind.Local).AddTicks(1007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Guests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 21, 34, 600, DateTimeKind.Local).AddTicks(7792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 21, 34, 600, DateTimeKind.Local).AddTicks(4243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 11, 21, 34, 600, DateTimeKind.Local).AddTicks(1916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 11, 39, 57, 615, DateTimeKind.Local).AddTicks(1662));
        }
    }
}
