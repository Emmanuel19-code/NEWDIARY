using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewDiary.Migrations
{
    /// <inheritdoc />
    public partial class AddingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 14, 29, 29, 164, DateTimeKind.Local).AddTicks(1239));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 14, 27, 56, 256, DateTimeKind.Local).AddTicks(3174));
        }
    }
}
