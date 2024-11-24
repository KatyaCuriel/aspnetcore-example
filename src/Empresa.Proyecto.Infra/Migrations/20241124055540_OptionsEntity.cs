using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    public partial class OptionsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
