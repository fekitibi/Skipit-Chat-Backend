using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkipitChat.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accessiblities",
                columns: new[] { "Id", "BikeParking", "Comment", "DisabledService", "Elevator", "Escalator", "Stairs", "StationName", "TicketMachine", "Toilet", "WaitingRoom" },
                values: new object[] { new Guid("76038447-f535-48d0-a34e-7ddb314204ab"), true, "", true, true, true, true, "Station 1", true, true, true });

            migrationBuilder.InsertData(
                table: "Accessiblities",
                columns: new[] { "Id", "BikeParking", "Comment", "DisabledService", "Elevator", "Escalator", "Stairs", "StationName", "TicketMachine", "Toilet", "WaitingRoom" },
                values: new object[] { new Guid("a3519699-c1bf-4152-a89e-19ef1ba3db5c"), false, "", false, false, false, false, "Station 2", false, false, false });

            migrationBuilder.InsertData(
                table: "Accessiblities",
                columns: new[] { "Id", "BikeParking", "Comment", "DisabledService", "Elevator", "Escalator", "Stairs", "StationName", "TicketMachine", "Toilet", "WaitingRoom" },
                values: new object[] { new Guid("ab126c7e-cbbe-4ffb-9591-b7c45e6a28f0"), false, "", false, true, false, false, "Station 3", true, true, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accessiblities",
                keyColumn: "Id",
                keyValue: new Guid("76038447-f535-48d0-a34e-7ddb314204ab"));

            migrationBuilder.DeleteData(
                table: "Accessiblities",
                keyColumn: "Id",
                keyValue: new Guid("a3519699-c1bf-4152-a89e-19ef1ba3db5c"));

            migrationBuilder.DeleteData(
                table: "Accessiblities",
                keyColumn: "Id",
                keyValue: new Guid("ab126c7e-cbbe-4ffb-9591-b7c45e6a28f0"));
        }
    }
}
