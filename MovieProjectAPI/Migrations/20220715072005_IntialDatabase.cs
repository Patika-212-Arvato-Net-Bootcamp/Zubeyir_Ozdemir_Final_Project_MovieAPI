using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MovieProjectAPI.Migrations
{
    public partial class IntialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mytable",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    adult = table.Column<string>(type: "text", nullable: false),
                    belongs_to_collection = table.Column<string>(type: "text", nullable: false),
                    budget = table.Column<string>(type: "text", nullable: false),
                    genres = table.Column<string>(type: "text", nullable: false),
                    homepage = table.Column<string>(type: "text", nullable: false),
                    imdb_id = table.Column<string>(type: "text", nullable: false),
                    original_language = table.Column<string>(type: "text", nullable: false),
                    original_title = table.Column<string>(type: "text", nullable: false),
                    overview = table.Column<string>(type: "text", nullable: false),
                    popularity = table.Column<string>(type: "text", nullable: false),
                    poster_path = table.Column<string>(type: "text", nullable: false),
                    production_companies = table.Column<string>(type: "text", nullable: false),
                    production_countries = table.Column<string>(type: "text", nullable: false),
                    release_date = table.Column<string>(type: "text", nullable: false),
                    revenue = table.Column<int>(type: "integer", nullable: false),
                    runtime = table.Column<double>(type: "double precision", nullable: false),
                    spoken_languages = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    tagline = table.Column<string>(type: "text", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    video = table.Column<string>(type: "text", nullable: false),
                    vote_average = table.Column<double>(type: "double precision", nullable: false),
                    vote_count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mytable", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mytable");
        }
    }
}
