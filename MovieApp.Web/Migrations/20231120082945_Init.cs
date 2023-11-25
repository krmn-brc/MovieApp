using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Biography = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GenreId = table.Column<int>(type: "integer", nullable: true),
                    DirectorId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Biography", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Matt Eskandari is an Iranian-born American film director and screenwriter. His films include Victim, The Gauntlet, and 12 Feet Deep. He was also a contestant on the Fox Studios and Steven Spielberg filmmaker competition On the Lot.", "d1.jpg", "Matt Eskandari" },
                    { 2, "Zoe Lister-Jones is an American actress and filmmaker who co-starred as Jen Collins Short in the CBS sitcom Life in Pieces from 2015 to 2019. She is also known for her roles in the television shows Delocated, Whitney, and New Girl. Lister-Jones made her directorial debut with the 2017 comedy-drama film Band Aid.", "d2.jpeg", "Zoe Lister-Jones" },
                    { 3, "Christopher Edward Nolan CBE is a British and American filmmaker. Known for his Hollywood blockbusters with complex storytelling, Nolan is considered a leading filmmaker of the 21st century. His films have grossed more than $6 billion worldwide.", "d3.jpeg", "Christopher Nolan" },
                    { 4, "Christopher Kip Forbes is vice chairman of the Forbes Publishing company. He attended St. Mark's School in Southborough, Massachusetts, and Princeton University. His brother is Steve Forbes, who has made multiple runs for the U.S. presidency and written some in-depth political and economic narratives.", "d4.jpg", "Christopher Forbes" },
                    { 5, "Writers/Directors Eshom and Ian Nelms, grew up in central California waging two hundred man G.I. Joe wars and dreaming in John Ford Landscapes. Though their evolving passions temporarily took them in different directions - Ian went to college on a wrestling scholarship, along the way discovering a new interest for English and Literature, and Eshom pursued an education in fine art painting, but found the illustration of comic books better suited to his tastes - the two would always find themselves returning to their love of film. While Ian has produced various projects independently and Eshom has worked as a professional storyboard artist for over a decade, the Nelms Brothers always write and direct together and have made multiple award-winning short and feature films.", "d5.jpg", "Eshom Nelms" },
                    { 6, "Logothetis was born in Athens, Greece,[3] and immigrated to the United States of America at the age of six with his mother, Anna, and his father, Euthymios. Euthymios moved to the United States to join his family, spending eight years working as a mechanic in Los Angeles and becoming an American citizen.", "d6.jpg", "Dimitri Logothetis" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Romantik" },
                    { 2, "Komedi" },
                    { 3, "Macera" },
                    { 4, "Savaş" },
                    { 5, "Animasyon" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "DirectorId", "GenreId", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of alien invaders. But when a celebrated war hero goes down in defeat, the fate of the planet and mankind hangs in the balance.", 6, 4, "jiujitsu.jpg", "Jiu Jitsu" },
                    { 2, "A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit man to kill Santa after receiving a lump of coal in his stocking.", 5, 2, "fatman.jpg", "Fatman" },
                    { 3, "When their brother is killed by an outlaw, three Dalton brothers join their sheriff's dept. When they're cheated by the law, they turn to crime. Trying to outdo Jesse James, they try to rob two banks at once in 1892. Things get ugly.", 4, 4, "tdaltong.jpg", "The Dalton Gang" },
                    { 4, "Armed with only one word, Tenet, and fighting for the survival of the entire world, a Protagonist journeys through a twilight world of international espionage on a mission that will unfold in something beyond real time.", 3, 4, "tenet.jpg", "Tenet" },
                    { 5, "A group of high school students form a coven of witches.", 2, 3, "tcraft.jpg", "Film 5" },
                    { 6, "The work of billionaire tech CEO Donovan Chalmers (Willis) is so valuable that he hires mercenaries to protect it, and a terrorist group kidnaps his daughter just to get it.", 1, 3, "hardkill.jpeg", "Hard Kill" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
