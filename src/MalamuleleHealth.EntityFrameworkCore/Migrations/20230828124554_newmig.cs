using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.Migrations
{
    public partial class newmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Prescriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Prescriptions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Prescriptions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Prescriptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Prescriptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Prescriptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Prescriptions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Departments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Departments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Departments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Appointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Appointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Appointments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Appointments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Appointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "ba9b9f5f-c768-4a58-b0da-3254fb7c66da", new DateTime(2023, 8, 28, 14, 45, 54, 67, DateTimeKind.Local).AddTicks(8183), "46979AFE7F764B0381C0AA80CE7D6AAB" });

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "950d54aa-b999-43d0-93dc-39c99b51f732", new DateTime(2023, 8, 28, 14, 45, 54, 67, DateTimeKind.Local).AddTicks(8260), "523D81A2D0054D719EAC1EFC945C1ED4" });

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "f22acd0e-ecc6-4751-b43f-b76ceb340abe", new DateTime(2023, 8, 28, 14, 45, 54, 67, DateTimeKind.Local).AddTicks(8269), "83F7D355B11847DA9045F2DF5D6140A8" });

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "3e70746b-6a7c-4c56-9547-33b653b09053", new DateTime(2023, 8, 28, 14, 45, 54, 67, DateTimeKind.Local).AddTicks(8277), "8DF81C19170E4168870B1821C10A5E3E" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "37e931da-805f-41d5-91e7-09f3ff8fda19", new DateTime(2023, 8, 24, 16, 48, 34, 935, DateTimeKind.Local).AddTicks(672), "5A7E730BF7554FE3A6094730CAE54E92" });

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "9e58f31c-8b4e-4d66-a17c-72068e07a99f", new DateTime(2023, 8, 24, 16, 48, 34, 935, DateTimeKind.Local).AddTicks(706), "3FFBC01B63864FE697A6946954F9A43D" });

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "cef2845c-2941-41b3-aee8-df33528b2737", new DateTime(2023, 8, 24, 16, 48, 34, 935, DateTimeKind.Local).AddTicks(740), "EA9851F3D9E84E309DB272C2FDA5A0F4" });

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "691a84b1-67e4-4eed-9395-e70f0aca794b", new DateTime(2023, 8, 24, 16, 48, 34, 935, DateTimeKind.Local).AddTicks(748), "A2F55578137244D7BED350926A32DFCA" });
        }
    }
}
