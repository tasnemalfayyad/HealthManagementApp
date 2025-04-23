using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeathData.Migrations
{
    /// <inheritdoc />
    public partial class AddressPatientClinician : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Addresses_ClinicianId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PatientId",
                table: "Addresses");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ClinicianId",
                table: "Addresses",
                column: "ClinicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PatientId",
                table: "Addresses",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Addresses_ClinicianId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PatientId",
                table: "Addresses");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ClinicianId",
                table: "Addresses",
                column: "ClinicianId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PatientId",
                table: "Addresses",
                column: "PatientId",
                unique: true);
        }
    }
}
