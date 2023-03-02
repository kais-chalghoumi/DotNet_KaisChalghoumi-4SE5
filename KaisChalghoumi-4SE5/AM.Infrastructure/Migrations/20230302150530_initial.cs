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
                    passportNumber = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    passengerId = table.Column<int>(type: "int", nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telNumber = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    healthInfomation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.passportNumber);
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
                name: "MyFlight",
                columns: table => new
                {
                    flightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    villededepart = table.Column<string>(name: "ville de depart", type: "nchar(100)", maxLength: 100, nullable: false, defaultValue: "TUN"),
                    flightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    effectiveArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estimatedDuration = table.Column<int>(type: "int", nullable: false),
                    PlaneFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyFlight", x => x.flightId);
                    table.ForeignKey(
                        name: "FK_MyFlight_Planes_PlaneFK",
                        column: x => x.PlaneFK,
                        principalTable: "Planes",
                        principalColumn: "planeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightPassenger",
                columns: table => new
                {
                    flightsflightId = table.Column<int>(type: "int", nullable: false),
                    passengerspassportNumber = table.Column<string>(type: "nvarchar(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPassenger", x => new { x.flightsflightId, x.passengerspassportNumber });
                    table.ForeignKey(
                        name: "FK_FlightPassenger_MyFlight_flightsflightId",
                        column: x => x.flightsflightId,
                        principalTable: "MyFlight",
                        principalColumn: "flightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightPassenger_Passengers_passengerspassportNumber",
                        column: x => x.passengerspassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "passportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_passengerspassportNumber",
                table: "FlightPassenger",
                column: "passengerspassportNumber");

            migrationBuilder.CreateIndex(
                name: "IX_MyFlight_PlaneFK",
                table: "MyFlight",
                column: "PlaneFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPassenger");

            migrationBuilder.DropTable(
                name: "MyFlight");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}
