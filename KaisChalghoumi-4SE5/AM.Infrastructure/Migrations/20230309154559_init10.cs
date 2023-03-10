using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init10 : Migration
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
                    birthDate = table.Column<DateTime>(type: "date", nullable: false),
                    FullName_FirstName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    FullName_LastName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    emailAdress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    telNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
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
                    manufactureDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.planeId);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    passportNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    employementDate = table.Column<DateTime>(type: "date", nullable: false),
                    function = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    salary = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.passportNumber);
                    table.ForeignKey(
                        name: "FK_Staffs_Passengers_passportNumber",
                        column: x => x.passportNumber,
                        principalTable: "Passengers",
                        principalColumn: "passportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Travellers",
                columns: table => new
                {
                    passportNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    healthInfomation = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    nationality = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travellers", x => x.passportNumber);
                    table.ForeignKey(
                        name: "FK_Travellers_Passengers_passportNumber",
                        column: x => x.passportNumber,
                        principalTable: "Passengers",
                        principalColumn: "passportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyFlight",
                columns: table => new
                {
                    flightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    destination = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Depart = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false, defaultValue: "Tunis"),
                    flightDate = table.Column<DateTime>(type: "date", nullable: false),
                    effectiveArrival = table.Column<DateTime>(type: "date", nullable: false),
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
                name: "Ticket",
                columns: table => new
                {
                    flightFK = table.Column<int>(type: "int", nullable: false),
                    passengerFK = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    Siege = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    flightId = table.Column<int>(type: "int", nullable: false),
                    passengerpassportNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => new { x.passengerFK, x.flightFK });
                    table.ForeignKey(
                        name: "FK_Ticket_MyFlight_flightId",
                        column: x => x.flightId,
                        principalTable: "MyFlight",
                        principalColumn: "flightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Passengers_passengerpassportNumber",
                        column: x => x.passengerpassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "passportNumber");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyFlight_planeFk",
                table: "MyFlight",
                column: "planeFk");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_flightId",
                table: "Ticket",
                column: "flightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_passengerpassportNumber",
                table: "Ticket",
                column: "passengerpassportNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Travellers");

            migrationBuilder.DropTable(
                name: "MyFlight");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}
