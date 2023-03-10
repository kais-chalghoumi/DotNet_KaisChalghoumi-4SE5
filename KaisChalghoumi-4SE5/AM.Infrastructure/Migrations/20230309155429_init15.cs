using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_MyFlight_flightId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passengers_passengerpassportNumber",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_flightId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_passengerpassportNumber",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "flightId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "passengerpassportNumber",
                table: "Ticket");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_flightFK",
                table: "Ticket",
                column: "flightFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_MyFlight_flightFK",
                table: "Ticket",
                column: "flightFK",
                principalTable: "MyFlight",
                principalColumn: "flightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passengers_passengerFK",
                table: "Ticket",
                column: "passengerFK",
                principalTable: "Passengers",
                principalColumn: "passportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_MyFlight_flightFK",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passengers_passengerFK",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_flightFK",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "flightId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "passengerpassportNumber",
                table: "Ticket",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_flightId",
                table: "Ticket",
                column: "flightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_passengerpassportNumber",
                table: "Ticket",
                column: "passengerpassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_MyFlight_flightId",
                table: "Ticket",
                column: "flightId",
                principalTable: "MyFlight",
                principalColumn: "flightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passengers_passengerpassportNumber",
                table: "Ticket",
                column: "passengerpassportNumber",
                principalTable: "Passengers",
                principalColumn: "passportNumber");
        }
    }
}
