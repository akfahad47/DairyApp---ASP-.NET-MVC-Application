using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DairyApp.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Title" },
                values: new object[] { new DateTime(2024, 1, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), "Went Shopping" });

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 1, 3, 15, 45, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 5, 2, 19, 25, 15, 87, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Title" },
                values: new object[] { new DateTime(2025, 5, 2, 19, 25, 15, 87, DateTimeKind.Local).AddTicks(6482), "Went Shoping" });

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 5, 2, 19, 25, 15, 87, DateTimeKind.Local).AddTicks(6486));
        }
    }
}
