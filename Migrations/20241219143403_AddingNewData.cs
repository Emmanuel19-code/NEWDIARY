using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewDiary.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 14, 34, 2, 785, DateTimeKind.Local).AddTicks(9083));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 14, 29, 29, 164, DateTimeKind.Local).AddTicks(1239));
        }
    }
}
