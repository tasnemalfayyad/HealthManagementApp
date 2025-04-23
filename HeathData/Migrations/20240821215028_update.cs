using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeathData.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Appointments",
                newName: "Data");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Appointments",
                newName: "Date");
        }
    }
}
