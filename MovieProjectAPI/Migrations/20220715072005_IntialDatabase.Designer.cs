// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieProjectAPI.EfCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MovieProjectAPI.Migrations
{
    [DbContext(typeof(EF_DataContext))]
    [Migration("20220715072005_IntialDatabase")]
    partial class IntialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MovieProjectAPI.EfCore.Movie", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<string>("adult")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("belongs_to_collection")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("budget")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("genres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("homepage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("imdb_id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("original_language")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("original_title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("overview")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("popularity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("poster_path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("production_companies")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("production_countries")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("release_date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("revenue")
                        .HasColumnType("integer");

                    b.Property<double>("runtime")
                        .HasColumnType("double precision");

                    b.Property<string>("spoken_languages")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("tagline")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("video")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("vote_average")
                        .HasColumnType("double precision");

                    b.Property<int>("vote_count")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("mytable");
                });
#pragma warning restore 612, 618
        }
    }
}
