using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    public partial class ComplexEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ComplexEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 24, 5, 30, 56, 978, DateTimeKind.Utc).AddTicks(1370), new DateTime(2024, 11, 24, 5, 30, 56, 978, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 24, 5, 30, 56, 978, DateTimeKind.Utc).AddTicks(1374), new DateTime(2024, 11, 24, 5, 30, 56, 978, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 24, 5, 30, 56, 978, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 11, 24, 5, 30, 56, 978, DateTimeKind.Utc).AddTicks(1378) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ComplexEntity");

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7414), new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7419), new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7422), new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7422) });
        }
    }
}
