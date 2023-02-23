using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PW_4_3_ModuleTask.Migrations
{
    public partial class ChangedDuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Song",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                column: "Duration",
                value: new TimeSpan(0, 0, 3, 0, 0));

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Duration", "Title" },
                values: new object[] { new TimeSpan(0, 0, 2, 0, 0), "Title2" });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Duration", "Title" },
                values: new object[] { new TimeSpan(0, 0, 3, 0, 0), "Title3" });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Duration", "Title" },
                values: new object[] { new TimeSpan(0, 0, 4, 0, 0), "Title4" });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Duration", "Title" },
                values: new object[] { new TimeSpan(0, 0, 3, 0, 0), "Title5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Duration",
                table: "Song",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                column: "Duration",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Duration", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title1" });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Duration", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title1" });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Duration", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title1" });

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Duration", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title1" });
        }
    }
}
