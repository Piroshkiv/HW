using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_4_3.Migrations
{
    public partial class AddClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "ArturPiroshkiv@gmail.com", "Artur", "Piroshkiv", "+380786847267" },
                    { 2, "IhorJakirov@gmail.com", "Ihor", "Jakirov", "+380987878783" },
                    { 3, "DaniilMorphovich@gmail.com", "Daniil", "Morphovich", "+380926402640" },
                    { 4, "MaximNalivaiko@gmail.com", "Maxim", "Nalivaiko", "+380027397293" },
                    { 5, "DenisProlivaiko@gmail.com", "Denis", "Prolivaiko", "+380027397293" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 8000m, 1, "Name1", new DateTime(2023, 2, 15, 0, 25, 31, 478, DateTimeKind.Local).AddTicks(7755) },
                    { 2, 7000m, 1, "Name2", new DateTime(2023, 2, 15, 0, 25, 31, 478, DateTimeKind.Local).AddTicks(7794) },
                    { 3, 9000m, 1, "Name3", new DateTime(2023, 2, 15, 0, 25, 31, 478, DateTimeKind.Local).AddTicks(7797) },
                    { 4, 3000m, 1, "Name4", new DateTime(2023, 2, 15, 0, 25, 31, 478, DateTimeKind.Local).AddTicks(7799) },
                    { 5, 10000m, 1, "Name5", new DateTime(2023, 2, 15, 0, 25, 31, 478, DateTimeKind.Local).AddTicks(7801) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Clients_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Clients_ClientId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientId",
                table: "Project");

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");
        }
    }
}
