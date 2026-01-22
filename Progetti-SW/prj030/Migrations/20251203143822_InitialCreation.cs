using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prj030.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datum");

            migrationBuilder.DropColumn(
                name: "Meta_Page",
                table: "Anime");

            migrationBuilder.RenameColumn(
                name: "meta_totalPage",
                table: "Anime",
                newName: "rank");

            migrationBuilder.RenameColumn(
                name: "meta_totalData",
                table: "Anime",
                newName: "myanimelist_id");

            migrationBuilder.RenameColumn(
                name: "Meta_Size",
                table: "Anime",
                newName: "members");

            migrationBuilder.AddColumn<string>(
                name: "aired_on",
                table: "Anime",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "myanimelist_url",
                table: "Anime",
                type: "varchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "picture_url",
                table: "Anime",
                type: "varchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "score",
                table: "Anime",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Anime",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Anime",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aired_on",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "myanimelist_url",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "picture_url",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "score",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "title",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Anime");

            migrationBuilder.RenameColumn(
                name: "rank",
                table: "Anime",
                newName: "meta_totalPage");

            migrationBuilder.RenameColumn(
                name: "myanimelist_id",
                table: "Anime",
                newName: "meta_totalData");

            migrationBuilder.RenameColumn(
                name: "members",
                table: "Anime",
                newName: "Meta_Size");

            migrationBuilder.AddColumn<int>(
                name: "Meta_Page",
                table: "Anime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Datum",
                columns: table => new
                {
                    _id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RootId = table.Column<int>(type: "int", nullable: false),
                    __v = table.Column<int>(type: "int", nullable: false),
                    alternativeTitles = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    episodes = table.Column<int>(type: "int", nullable: false),
                    genres = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hasEpisode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    hasRanking = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    link = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ranking = table.Column<int>(type: "int", nullable: false),
                    score = table.Column<double>(type: "double", nullable: false),
                    status = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    synopsis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thumb = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    updatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    workerId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datum", x => x._id);
                    table.ForeignKey(
                        name: "FK_Datum_Anime_RootId",
                        column: x => x.RootId,
                        principalTable: "Anime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Datum_RootId",
                table: "Datum",
                column: "RootId");
        }
    }
}
