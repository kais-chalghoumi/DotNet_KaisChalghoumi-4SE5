using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    passportNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    passengerId = table.Column<int>(type: "int", nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    emailAdress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    telNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    IdTest2 = table.Column<int>(type: "int", nullable: true),
                    employementDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    function = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    salary = table.Column<float>(type: "real", nullable: true),
                    healthInfomation = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    nationality = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
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
                    destination = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Depart = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false, defaultValue: "Tunis"),
                    flightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    effectiveArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estimatedDuration = table.Column<int>(type: "int", nullable: false),
                    planeFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyFlight", x => x.flightId);
                    table.ForeignKey(
                        name: "FK_MyFlight_Planes_planeFk",
                        column: x => x.planeFk,
                        principalTable: "Planes",
                        principalColumn: "planeId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "MyReservation",
                columns: table => new
                {
                    flightsflightId = table.Column<int>(type: "int", nullable: false),
                    passengerspassportNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyReservation", x => new { x.flightsflightId, x.passengerspassportNumber });
                    table.ForeignKey(
                        name: "FK_MyReservation_MyFlight_flightsflightId",
                        column: x => x.flightsflightId,
                        principalTable: "MyFlight",
                        principalColumn: "flightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyReservation_Passengers_passengerspassportNumber",
                        column: x => x.passengerspassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "passportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyFlight_planeFk",
                table: "MyFlight",
                column: "planeFk");

            migrationBuilder.CreateIndex(
                name: "IX_MyReservation_passengerspassportNumber",
                table: "MyReservation",
                column: "passengerspassportNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyReservation");

            migrationBuilder.DropTable(
                name: "MyFlight");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}
