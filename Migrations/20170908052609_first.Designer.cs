using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyMovieApi.Models;

namespace MyMovieApi.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20170908052609_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyMovieApi.Models.Movie", b =>
                {
                    b.Property<int>("id");

                    b.Property<string>("overview");

                    b.Property<string>("poster_path");

                    b.Property<string>("release_date");

                    b.Property<string>("title");

                    b.HasKey("id");

                    b.ToTable("movies");
                });
        }
    }
}
