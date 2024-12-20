using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewDiary.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnToDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate" },
                values: new object[] { "Went to the library to read about Science and Chemistry", new DateTime(2024, 12, 19, 14, 38, 47, 571, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "CreatedDate", "Title" },
                values: new object[] { 2, "Had a great time exploring historical artifacts.", new DateTime(2024, 12, 18, 14, 38, 47, 572, DateTimeKind.Local).AddTicks(340), "Visited the Museum" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDate" },
                values: new object[] { "Went to the library to go and read on some Science and Chemistry stuffs", new DateTime(2024, 12, 19, 14, 34, 2, 785, DateTimeKind.Local).AddTicks(9083) });
        }
    }
}
