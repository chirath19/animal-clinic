using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSurgicalHistoryToMedicalRecordLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurgicalHistories_MedicalRecords_MedicalRecordId",
                table: "SurgicalHistories");

            migrationBuilder.AlterColumn<int>(
                name: "MedicalRecordId",
                table: "SurgicalHistories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SurgicalHistories_MedicalRecords_MedicalRecordId",
                table: "SurgicalHistories",
                column: "MedicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurgicalHistories_MedicalRecords_MedicalRecordId",
                table: "SurgicalHistories");

            migrationBuilder.AlterColumn<int>(
                name: "MedicalRecordId",
                table: "SurgicalHistories",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_SurgicalHistories_MedicalRecords_MedicalRecordId",
                table: "SurgicalHistories",
                column: "MedicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "Id");
        }
    }
}
