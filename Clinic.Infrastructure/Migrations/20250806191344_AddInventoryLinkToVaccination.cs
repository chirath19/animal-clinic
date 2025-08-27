using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInventoryLinkToVaccination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InventoryItemId",
                table: "VaccinationRecords",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RequiresMedicationAdmin",
                table: "MedicalRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RequiresPrescription",
                table: "MedicalRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RequiresVaccination",
                table: "MedicalRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "MedicalRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationRecords_InventoryItemId",
                table: "VaccinationRecords",
                column: "InventoryItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationRecords_InventoryItems_InventoryItemId",
                table: "VaccinationRecords",
                column: "InventoryItemId",
                principalTable: "InventoryItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationRecords_InventoryItems_InventoryItemId",
                table: "VaccinationRecords");

            migrationBuilder.DropIndex(
                name: "IX_VaccinationRecords_InventoryItemId",
                table: "VaccinationRecords");

            migrationBuilder.DropColumn(
                name: "InventoryItemId",
                table: "VaccinationRecords");

            migrationBuilder.DropColumn(
                name: "RequiresMedicationAdmin",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "RequiresPrescription",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "RequiresVaccination",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "MedicalRecords");
        }
    }
}
