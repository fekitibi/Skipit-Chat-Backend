using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkipitChat.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accessiblities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StationName = table.Column<string>(nullable: false),
                    Elevator = table.Column<bool>(nullable: false),
                    DisabledService = table.Column<bool>(nullable: false),
                    Stairs = table.Column<bool>(nullable: false),
                    Escalator = table.Column<bool>(nullable: false),
                    Toilet = table.Column<bool>(nullable: false),
                    WaitingRoom = table.Column<bool>(nullable: false),
                    BikeParking = table.Column<bool>(nullable: false),
                    TicketMachine = table.Column<bool>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessiblities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CityPasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DurationInHour = table.Column<int>(nullable: false),
                    CityPass4Price = table.Column<float>(nullable: false),
                    CityPass99Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityPasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ZoneValue = table.Column<int>(nullable: false),
                    DurationInMinute = table.Column<int>(nullable: false),
                    PriceChildren = table.Column<float>(nullable: false),
                    PriceDisabled = table.Column<float>(nullable: false),
                    PriceAdult = table.Column<float>(nullable: false),
                    PriceElderly = table.Column<float>(nullable: false),
                    Animal = table.Column<float>(nullable: false),
                    Bycicle = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessiblities");

            migrationBuilder.DropTable(
                name: "CityPasses");

            migrationBuilder.DropTable(
                name: "Zones");
        }
    }
}
