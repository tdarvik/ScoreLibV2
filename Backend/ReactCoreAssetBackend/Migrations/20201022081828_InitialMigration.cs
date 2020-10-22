using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactCoreAssetBackend.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    OpusNr = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    Published = table.Column<int>(nullable: false),
                    PhysicalForm = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Bind = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.EntityId);
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "EntityId", "Bind", "Location", "OpusNr", "PhysicalForm", "Published", "Title", "Type", "Version" },
                values: new object[] { new Guid("d214e4d3-0519-48a1-a055-1b35cf369451"), "", "Folder 1", "84", "Paperback", 2004, "Beethoven", "Opera", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scores");
        }
    }
}
