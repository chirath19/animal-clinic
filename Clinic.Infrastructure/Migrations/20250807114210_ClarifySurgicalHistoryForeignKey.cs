using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ClarifySurgicalHistoryForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurgicalHistories_Staff_SurgeonId",
                table: "SurgicalHistories");

            migrationBuilder.DropIndex(
                name: "IX_SurgicalHistories_SurgeonId",
                table: "SurgicalHistories");

            migrationBuilder.DropColumn(
                name: "SurgeonId",
                table: "SurgicalHistories");

            migrationBuilder.CreateIndex(
                name: "IX_SurgicalHistories_SurgeonStaffId",
                table: "SurgicalHistories",
                column: "SurgeonStaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurgicalHistories_Staff_SurgeonStaffId",
                table: "SurgicalHistories",
                column: "SurgeonStaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SurgicalHistories_Staff_SurgeonStaffId",
                table: "SurgicalHistories");

            migrationBuilder.DropIndex(
                name: "IX_SurgicalHistories_SurgeonStaffId",
                table: "SurgicalHistories");

            migrationBuilder.AddColumn<int>(
                name: "SurgeonId",
                table: "SurgicalHistories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SurgicalHistories_SurgeonId",
                table: "SurgicalHistories",
                column: "SurgeonId");

            migrationBuilder.AddForeignKey(
                name: "FK_SurgicalHistories_Staff_SurgeonId",
                table: "SurgicalHistories",
                column: "SurgeonId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
