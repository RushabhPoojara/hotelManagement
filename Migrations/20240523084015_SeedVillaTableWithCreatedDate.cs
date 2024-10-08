using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo_Asp_DotNetCoreWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableWithCreatedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Details = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Rate = table.Column<double>(type: "double precision", nullable: false),
                    Sqft = table.Column<int>(type: "integer", nullable: false),
                    Occupancy = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Amenity = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 5, 23, 8, 40, 15, 341, DateTimeKind.Utc).AddTicks(3181), "Fmaspef ;xvsdpf pvbfpjgm mpgkpdfkbcp pfbvdfp pgkdpbk", "https://images.freeimages.com/images/large-previews/56d/peacock-1169961.jpg?fmt=webp&w=500", "Royale Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2024, 5, 23, 8, 40, 15, 341, DateTimeKind.Utc).AddTicks(3184), "Fmaspef ;xvsdpf pvbfpjgm mpgkpdfkbcp pfbvdfp pgkdpbk", "https://images.freeimages.com/images/large-previews/56d/peacock-1169961.jpg?fmt=webp&w=500", "Premium Pool Villa", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2024, 5, 23, 8, 40, 15, 341, DateTimeKind.Utc).AddTicks(3185), "Fmaspef ;xvsdpf pvbfpjgm mpgkpdfkbcp pfbvdfp pgkdpbk", "https://images.freeimages.com/images/large-previews/56d/peacock-1169961.jpg?fmt=webp&w=500", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(2024, 5, 23, 8, 40, 15, 341, DateTimeKind.Utc).AddTicks(3187), "Fmaspef ;xvsdpf pvbfpjgm mpgkpdfkbcp pfbvdfp pgkdpbk", "https://images.freeimages.com/images/large-previews/56d/peacock-1169961.jpg?fmt=webp&w=500", "Diamond Villa", 4, 550.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(2024, 5, 23, 8, 40, 15, 341, DateTimeKind.Utc).AddTicks(3188), "Fmaspef ;xvsdpf pvbfpjgm mpgkpdfkbcp pfbvdfp pgkdpbk", "https://images.freeimages.com/images/large-previews/56d/peacock-1169961.jpg?fmt=webp&w=500", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
