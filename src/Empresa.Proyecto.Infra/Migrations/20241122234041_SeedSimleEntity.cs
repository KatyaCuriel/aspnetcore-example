using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    public partial class SeedSimleEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailTranslation");

            migrationBuilder.DropTable(
                name: "EmailNotifications");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SimpleEntity",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ComplexEntity",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ComplexEntity",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "ComplexEntity",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.InsertData(
                table: "SimpleEntity",
                columns: new[] { "Id", "Created", "Modified", "Name", "Value" },
                values: new object[] { 1, new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7414), new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7417), "Nuevo", "Valor inicial 1" });

            migrationBuilder.InsertData(
                table: "SimpleEntity",
                columns: new[] { "Id", "Created", "Modified", "Name", "Value" },
                values: new object[] { 2, new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7419), new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7420), "Existente", "Valor inicial 2" });

            migrationBuilder.InsertData(
                table: "SimpleEntity",
                columns: new[] { "Id", "Created", "Modified", "Name", "Value" },
                values: new object[] { 3, new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7422), new DateTime(2024, 11, 22, 23, 40, 40, 958, DateTimeKind.Utc).AddTicks(7422), "Reconstruido", "Valor inicial 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SimpleEntity",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ComplexEntity",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ComplexEntity",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "ComplexEntity",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "EmailNotifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailNotifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTranslation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailNotificationId = table.Column<int>(type: "int", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailTranslation_EmailNotifications_EmailNotificationId",
                        column: x => x.EmailNotificationId,
                        principalTable: "EmailNotifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailTranslation_EmailNotificationId",
                table: "EmailTranslation",
                column: "EmailNotificationId");
        }
    }
}
