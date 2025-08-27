using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIsInvoicedFromAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Invoices_InvoiceId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicationAdministrations_InventoryItems_InventoryItemId",
                table: "MedicationAdministrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_InventoryItems_InventoryItemId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_InvoiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsInvoiced",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryItemId",
                table: "Prescriptions",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "MedicationName",
                table: "Prescriptions",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryItemId",
                table: "MedicationAdministrations",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "MedicationName",
                table: "MedicationAdministrations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Invoices",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PaidAmount",
                table: "Invoices",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_AppointmentId",
                table: "Invoices",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Appointments_AppointmentId",
                table: "Invoices",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationAdministrations_InventoryItems_InventoryItemId",
                table: "MedicationAdministrations",
                column: "InventoryItemId",
                principalTable: "InventoryItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_InventoryItems_InventoryItemId",
                table: "Prescriptions",
                column: "InventoryItemId",
                principalTable: "InventoryItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Appointments_AppointmentId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicationAdministrations_InventoryItems_InventoryItemId",
                table: "MedicationAdministrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_InventoryItems_InventoryItemId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_AppointmentId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "MedicationName",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "MedicationName",
                table: "MedicationAdministrations");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "PaidAmount",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryItemId",
                table: "Prescriptions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InventoryItemId",
                table: "MedicationAdministrations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Appointments",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsInvoiced",
                table: "Appointments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_InvoiceId",
                table: "Appointments",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Invoices_InvoiceId",
                table: "Appointments",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationAdministrations_InventoryItems_InventoryItemId",
                table: "MedicationAdministrations",
                column: "InventoryItemId",
                principalTable: "InventoryItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_InventoryItems_InventoryItemId",
                table: "Prescriptions",
                column: "InventoryItemId",
                principalTable: "InventoryItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
