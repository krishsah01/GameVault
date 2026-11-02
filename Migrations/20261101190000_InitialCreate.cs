using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameVault.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FoundedYear = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    MyRating = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    DeveloperId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Developers_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Developers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Country", "FoundedYear", "Name" },
                values: new object[,]
                {
                    { 1, "Japan", 1889, "Nintendo" },
                    { 2, "Sweden", 2009, "Mojang Studios" },
                    { 3, "Poland", 2002, "CD Projekt Red" },
                    { 4, "Japan", 1986, "FromSoftware" },
                    { 5, "United States", 1996, "Valve" },
                    { 6, "United States", 1998, "Rockstar Games" },
                    { 7, "United States", 2006, "Riot Games" },
                    { 8, "United States", 2001, "Bethesda Game Studios" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action-Adventure" },
                    { 2, "RPG" },
                    { 3, "Shooter" },
                    { 4, "Sandbox" },
                    { 5, "Strategy" },
                    { 6, "Platformer" },
                    { 7, "Puzzle" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "DeveloperId", "Description", "GenreId", "MyRating", "Platform", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Open-air adventure where you can climb almost anything and tackle the world in nearly any order.", 1, 10, "Nintendo Switch", 2017, "The Legend of Zelda: Breath of the Wild" },
                    { 2, 2, "A sandbox of endless creativity: mine, craft, build and survive in a procedurally generated world.", 4, 9, "PC", 2011, "Minecraft" },
                    { 3, 3, "Story-driven open-world RPG following monster hunter Geralt of Rivia.", 2, 10, "PC", 2015, "The Witcher 3: Wild Hunt" },
                    { 4, 4, "Challenging open-world action RPG set in the Lands Between.", 2, 9, "PC", 2022, "Elden Ring" },
                    { 5, 5, "First-person puzzle game built around the portal gun, with sharp humor and clever level design.", 7, 10, "PC", 2011, "Portal 2" },
                    { 6, 5, "Competitive tactical shooter built on teamwork, economy and precise aim.", 3, 8, "PC", 2023, "Counter-Strike 2" },
                    { 7, 6, "Western epic with a richly detailed open world and a cinematic story.", 1, 9, "PC", 2018, "Red Dead Redemption 2" },
                    { 8, 5, "Virtual-reality return to the Half-Life universe, praised for immersive interaction.", 3, 9, "PC (VR)", 2020, "Half-Life: Alyx" },
                    { 9, 1, "Globe-trotting 3D platformer featuring Mario and his sentient hat, Cappy.", 6, 9, "Nintendo Switch", 2017, "Super Mario Odyssey" },
                    { 10, 8, "Open-world fantasy RPG with dragons, deep mod support and near-endless exploration.", 2, 9, "PC", 2011, "The Elder Scrolls V: Skyrim" },
                    { 11, 6, "Open-world crime game following three protagonists in the city of Los Santos.", 1, 8, "PC", 2013, "Grand Theft Auto V" },
                    { 12, 7, "Team-based MOBA where two teams of five battle to destroy the opposing Nexus.", 5, 7, "PC", 2009, "League of Legends" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_DeveloperId",
                table: "Games",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
