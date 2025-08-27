using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ClarifySurgicalHistoryStaff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurgicalHistories_Staff_SurgeonStaffId",
                table: "SurgicalHistories");

            migrationBuilder.RenameColumn(
                name: "SurgeonStaffId",
                table: "SurgicalHistories",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_SurgicalHistories_SurgeonStaffId",
                table: "SurgicalHistories",
                newName: "IX_SurgicalHistories_StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurgicalHistories_Staff_StaffId",
                table: "SurgicalHistories",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurgicalHistories_Staff_StaffId",
                table: "SurgicalHistories");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "SurgicalHistories",
                newName: "SurgeonStaffId");

            migrationBuilder.RenameIndex(
                name: "IX_SurgicalHistories_StaffId",
                table: "SurgicalHistories",
                newName: "IX_SurgicalHistories_SurgeonStaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurgicalHistories_Staff_SurgeonStaffId",
                table: "SurgicalHistories",
                column: "SurgeonStaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
