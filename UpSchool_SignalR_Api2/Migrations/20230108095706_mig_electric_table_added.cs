﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UpSchool_SignalR_Api2.Migrations
{
    public partial class mig_electric_table_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Electrics",
                columns: table => new
                {
                    ElectricID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    ElectricDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Electrics", x => x.ElectricID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Electrics");
        }
    }
}
