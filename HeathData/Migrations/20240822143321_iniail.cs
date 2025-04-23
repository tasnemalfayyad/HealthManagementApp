using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeathData.Migrations
{
    /// <inheritdoc />
    public partial class iniail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Patients_PatientId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PatientId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Addresses");

            migrationBuilder.CreateTable(
                name: "ClinicianPatient",
                columns: table => new
                {
                    CliniciansId = table.Column<int>(type: "int", nullable: false),
                    PatientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicianPatient", x => new { x.CliniciansId, x.PatientsId });
                    table.ForeignKey(
                        name: "FK_ClinicianPatient_Clinicians_CliniciansId",
                        column: x => x.CliniciansId,
                        principalTable: "Clinicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClinicianPatient_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClinicianPatient_PatientsId",
                table: "ClinicianPatient",
                column: "PatientsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClinicianPatient");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PatientId",
                table: "Addresses",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Patients_PatientId",
                table: "Addresses",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");
        }
    }
}
