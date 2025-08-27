using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddFormToSurgicalHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicalRecordId",
                table: "SurgicalHistories",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RequiresSurgery",
                table: "MedicalRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_SurgicalHistories_MedicalRecordId",
                table: "SurgicalHistories",
                column: "MedicalRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurgicalHistories_MedicalRecords_MedicalRecordId",
                table: "SurgicalHistories",
                column: "MedicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurgicalHistories_MedicalRecords_MedicalRecordId",
                table: "SurgicalHistories");

            migrationBuilder.DropIndex(
                name: "IX_SurgicalHistories_MedicalRecordId",
                table: "SurgicalHistories");

            migrationBuilder.DropColumn(
                name: "MedicalRecordId",
                table: "SurgicalHistories");

            migrationBuilder.DropColumn(
                name: "RequiresSurgery",
                table: "MedicalRecords");
        }
    }
}
