using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AcsIntranet.Migrations
{
    public partial class InsPtDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InsertionPoint",
                table: "Blocks",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "jsonb",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InsertionPoint",
                table: "Blocks",
                type: "jsonb",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
