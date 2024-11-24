using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    public partial class OptionsEntity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(607), new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(613), new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(616), new DateTime(2024, 11, 24, 5, 59, 22, 408, DateTimeKind.Utc).AddTicks(617) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 24, 5, 55, 39, 863, DateTimeKind.Utc).AddTicks(6837), new DateTime(2024, 11, 24, 5, 55, 39, 863, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 24, 5, 55, 39, 863, DateTimeKind.Utc).AddTicks(6840), new DateTime(2024, 11, 24, 5, 55, 39, 863, DateTimeKind.Utc).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 11, 24, 5, 55, 39, 863, DateTimeKind.Utc).AddTicks(6843), new DateTime(2024, 11, 24, 5, 55, 39, 863, DateTimeKind.Utc).AddTicks(6844) });
        }
    }
}
