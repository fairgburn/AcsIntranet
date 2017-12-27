using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AcsIntranet.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    BlockName = table.Column<string>(nullable: false),
                    Class = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InsertionPoint = table.Column<string>(type: "jsonb", nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Qflag = table.Column<int>(nullable: false),
                    SpecNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.BlockName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blocks");
        }
    }
}
