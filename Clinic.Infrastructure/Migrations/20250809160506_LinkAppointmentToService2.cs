using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LinkAppointmentToService2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "VaccinationRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "SurgicalHistories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "MedicationAdministrations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationRecords_ServiceId",
                table: "VaccinationRecords",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgicalHistories_ServiceId",
                table: "SurgicalHistories",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationAdministrations_ServiceId",
                table: "MedicationAdministrations",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationAdministrations_Services_ServiceId",
                table: "MedicationAdministrations",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgicalHistories_Services_ServiceId",
                table: "SurgicalHistories",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationRecords_Services_ServiceId",
                table: "VaccinationRecords",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicationAdministrations_Services_ServiceId",
                table: "MedicationAdministrations");

            migrationBuilder.DropForeignKey(
                name: "FK_SurgicalHistories_Services_ServiceId",
                table: "SurgicalHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationRecords_Services_ServiceId",
                table: "VaccinationRecords");

            migrationBuilder.DropIndex(
                name: "IX_VaccinationRecords_ServiceId",
                table: "VaccinationRecords");

            migrationBuilder.DropIndex(
                name: "IX_SurgicalHistories_ServiceId",
                table: "SurgicalHistories");

            migrationBuilder.DropIndex(
                name: "IX_MedicationAdministrations_ServiceId",
                table: "MedicationAdministrations");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "VaccinationRecords");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "SurgicalHistories");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "MedicationAdministrations");
        }
    }
}
