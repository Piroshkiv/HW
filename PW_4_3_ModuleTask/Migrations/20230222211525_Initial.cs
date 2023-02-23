using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PW_4_3_ModuleTask.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfDeath = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSong",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSong", x => new { x.ArtistId, x.SongId });
                    table.ForeignKey(
                        name: "FK_ArtistSong_Artist_SongId",
                        column: x => x.SongId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Song_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "DateOfBirth", "DateOfDeath", "Email", "InstagramUrl", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, "Name1", null },
                    { 2, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), null, null, "Name2", null },
                    { 3, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, "Name3", null },
                    { 4, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), null, null, "Name4", null },
                    { 5, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, "Name5", null }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Rock" },
                    { 2, "Metal" },
                    { 3, "Rap" },
                    { 4, "Chanson" },
                    { 5, "Classical" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Title1" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Title1" }
                });

            migrationBuilder.InsertData(
                table: "ArtistSong",
                columns: new[] { "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Title1" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Title1" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "Title1" }
                });

            migrationBuilder.InsertData(
                table: "ArtistSong",
                columns: new[] { "ArtistId", "SongId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "ArtistSong",
                columns: new[] { "ArtistId", "SongId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "ArtistSong",
                columns: new[] { "ArtistId", "SongId" },
                values: new object[] { 4, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_SongId",
                table: "ArtistSong",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_GenreId",
                table: "Song",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistSong");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
