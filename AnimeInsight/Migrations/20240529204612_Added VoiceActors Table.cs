using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeInsight.Migrations
{
    /// <inheritdoc />
    public partial class AddedVoiceActorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VoiceActors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "nvarchar2(250)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar2(50)", nullable: false),
                    DOB = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoiceActors", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VoiceActors");
        }
    }
}
