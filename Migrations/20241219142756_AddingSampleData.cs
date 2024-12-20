using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewDiary.Migrations
{
    /// <inheritdoc />
    public partial class AddingSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "CreatedDate", "Title" },
                values: new object[] { 1, "Went to the library to go and read on some Science and Chemistry stuffs", new DateTime(2024, 12, 19, 14, 27, 56, 256, DateTimeKind.Local).AddTicks(3174), "Went to the Library" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
