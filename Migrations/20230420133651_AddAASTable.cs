using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTest.Migrations
{
    public partial class AddAASTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "albums",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    albumName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    totalSongs = table.Column<int>(type: "int", nullable: false),
                    artist = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_albums", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "artists",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    about = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imgPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    earlyLife = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeTown = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artists", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "singles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    singleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    singlArtist = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_singles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "albums");

            migrationBuilder.DropTable(
                name: "artists");

            migrationBuilder.DropTable(
                name: "singles");
        }
    }
}
