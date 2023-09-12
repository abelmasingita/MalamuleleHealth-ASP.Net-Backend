using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.EFCore.Migrations
{
    public partial class Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "Wards",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MedicalTestId",
                table: "TestResults",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AppointmentId",
                table: "Prescriptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "MedicalTests",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WardId",
                table: "Beds",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Wards_DepartmentId",
                table: "Wards",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_MedicalTestId",
                table: "TestResults",
                column: "MedicalTestId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_AppointmentId",
                table: "Prescriptions",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalTests_DepartmentId",
                table: "MedicalTests",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Beds_WardId",
                table: "Beds",
                column: "WardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beds_Wards_WardId",
                table: "Beds",
                column: "WardId",
                principalTable: "Wards",
                principalColumn: "WardId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalTests_Departments_DepartmentId",
                table: "MedicalTests",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Appointments_AppointmentId",
                table: "Prescriptions",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestResults_MedicalTests_MedicalTestId",
                table: "TestResults",
                column: "MedicalTestId",
                principalTable: "MedicalTests",
                principalColumn: "MedicalTestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_Departments_DepartmentId",
                table: "Wards",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beds_Wards_WardId",
                table: "Beds");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalTests_Departments_DepartmentId",
                table: "MedicalTests");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Appointments_AppointmentId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_TestResults_MedicalTests_MedicalTestId",
                table: "TestResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Departments_DepartmentId",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_Wards_DepartmentId",
                table: "Wards");

            migrationBuilder.DropIndex(
                name: "IX_TestResults_MedicalTestId",
                table: "TestResults");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_AppointmentId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_MedicalTests_DepartmentId",
                table: "MedicalTests");

            migrationBuilder.DropIndex(
                name: "IX_Beds_WardId",
                table: "Beds");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Wards");

            migrationBuilder.DropColumn(
                name: "MedicalTestId",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "MedicalTests");

            migrationBuilder.DropColumn(
                name: "WardId",
                table: "Beds");
        }
    }
}
