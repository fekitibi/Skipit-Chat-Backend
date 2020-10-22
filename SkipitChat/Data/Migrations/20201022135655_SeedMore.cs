using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SkipitChat.Migrations
{
    public partial class SeedMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Accessiblities",
                columns: new[] { "Id", "BikeParking", "Comment", "DisabledService", "Elevator", "Escalator", "Stairs", "StationName", "TicketMachine", "Toilet", "WaitingRoom" },
                values: new object[,]
                {
                    { new Guid("bb38fc53-bf4d-4d07-9d9d-882e5b84fa67"), true, "", true, true, true, true, "Station 1", true, true, true },
                    { new Guid("3aa9b509-fed5-43c5-8f2c-f46440e26804"), false, "", false, false, false, false, "Station 2", false, false, false },
                    { new Guid("2fb35348-618c-4bd8-ba16-e342c7041a75"), false, "", false, true, false, false, "Station 3", true, true, false }
                });

            migrationBuilder.InsertData(
                table: "CityPasses",
                columns: new[] { "Id", "CityPass4Price", "CityPass99Price", "DurationInHour" },
                values: new object[,]
                {
                    { new Guid("363aef28-0261-469b-a428-488979bee6fa"), 2345f, 3000f, 244 },
                    { new Guid("5e00fc58-3bb1-4aec-ba1c-c372abe71a00"), 55f, 90f, 4 },
                    { new Guid("7dbf1d64-f612-4812-be57-5d834e172190"), 599f, 700f, 24 }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "Id", "Animal", "Bycicle", "DurationInMinute", "PriceAdult", "PriceChildren", "PriceDisabled", "PriceElderly" },
                values: new object[,]
                {
                    { 2, 20f, 20f, 120, 10f, 5f, 5f, 5f },
                    { 3, 20f, 9f, 170, 6f, 4f, 5f, 7f },
                    { 4, 20f, 20f, 120, 17f, 7f, 5f, 7f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accessiblities",
                keyColumn: "Id",
                keyValue: new Guid("2fb35348-618c-4bd8-ba16-e342c7041a75"));

            migrationBuilder.DeleteData(
                table: "Accessiblities",
                keyColumn: "Id",
                keyValue: new Guid("3aa9b509-fed5-43c5-8f2c-f46440e26804"));

            migrationBuilder.DeleteData(
                table: "Accessiblities",
                keyColumn: "Id",
                keyValue: new Guid("bb38fc53-bf4d-4d07-9d9d-882e5b84fa67"));

            migrationBuilder.DeleteData(
                table: "CityPasses",
                keyColumn: "Id",
                keyValue: new Guid("363aef28-0261-469b-a428-488979bee6fa"));

            migrationBuilder.DeleteData(
                table: "CityPasses",
                keyColumn: "Id",
                keyValue: new Guid("5e00fc58-3bb1-4aec-ba1c-c372abe71a00"));

            migrationBuilder.DeleteData(
                table: "CityPasses",
                keyColumn: "Id",
                keyValue: new Guid("7dbf1d64-f612-4812-be57-5d834e172190"));

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: 4);

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
    }
}
