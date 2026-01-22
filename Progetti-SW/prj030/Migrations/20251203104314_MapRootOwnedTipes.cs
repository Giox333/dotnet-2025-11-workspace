using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prj030.Migrations
{
    /// <inheritdoc />
    public partial class MapRootOwnedTipes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anime_Meta_metaId",
                table: "Anime");

            migrationBuilder.DropForeignKey(
                name: "FK_Datum_Anime_RootId",
                table: "Datum");

            migrationBuilder.DropTable(
                name: "Meta");

            migrationBuilder.DropIndex(
                name: "IX_Anime_metaId",
                table: "Anime");

            migrationBuilder.RenameColumn(
                name: "metaId",
                table: "Anime",
                newName: "meta_totalPage");

            migrationBuilder.AlterColumn<int>(
                name: "RootId",
                table: "Datum",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "_id",
                table: "Datum",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Meta_Page",
                table: "Anime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Meta_Size",
                table: "Anime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "meta_totalData",
                table: "Anime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Datum_Anime_RootId",
                table: "Datum",
                column: "RootId",
                principalTable: "Anime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Datum_Anime_RootId",
                table: "Datum");

            migrationBuilder.DropColumn(
                name: "Meta_Page",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "Meta_Size",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "meta_totalData",
                table: "Anime");

            migrationBuilder.RenameColumn(
                name: "meta_totalPage",
                table: "Anime",
                newName: "metaId");

            migrationBuilder.AlterColumn<int>(
                name: "RootId",
                table: "Datum",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "_id",
                table: "Datum",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Meta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    page = table.Column<int>(type: "int", nullable: false),
                    size = table.Column<int>(type: "int", nullable: false),
                    totalData = table.Column<int>(type: "int", nullable: false),
                    totalPage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meta", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Anime_metaId",
                table: "Anime",
                column: "metaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anime_Meta_metaId",
                table: "Anime",
                column: "metaId",
                principalTable: "Meta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Datum_Anime_RootId",
                table: "Datum",
                column: "RootId",
                principalTable: "Anime",
                principalColumn: "Id");
        }
    }
}
