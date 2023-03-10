using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    passengerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employementDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<float>(type: "real", nullable: true),
                    healthInfomation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.passengerId);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    planeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    planeType = table.Column<int>(type: "int", nullable: false),
                    manufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.planeId);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    flightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    flightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    effectiveArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estimatedDuration = table.Column<int>(type: "int", nullable: false),
                    planeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.flightId);
                    table.ForeignKey(
                        name: "FK_Flights_Planes_planeId",
                        column: x => x.planeId,
                        principalTable: "Planes",
                        principalColumn: "planeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightPassenger",
                columns: table => new
                {
                    flightsflightId = table.Column<int>(type: "int", nullable: false),
                    passengerspassengerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPassenger", x => new { x.flightsflightId, x.passengerspassengerId });
                    table.ForeignKey(
                        name: "FK_FlightPassenger_Flights_flightsflightId",
                        column: x => x.flightsflightId,
                        principalTable: "Flights",
                        principalColumn: "flightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightPassenger_Passengers_passengerspassengerId",
                        column: x => x.passengerspassengerId,
                        principalTable: "Passengers",
                        principalColumn: "passengerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_passengerspassengerId",
                table: "FlightPassenger",
                column: "passengerspassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_planeId",
                table: "Flights",
                column: "planeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPassenger");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}
