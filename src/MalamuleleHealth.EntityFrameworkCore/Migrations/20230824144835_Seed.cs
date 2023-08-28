using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "DisplayName", "Name", "NormalizedName" },
                values: new object[] { "37e931da-805f-41d5-91e7-09f3ff8fda19", new DateTime(2023, 8, 24, 16, 48, 34, 935, DateTimeKind.Local).AddTicks(672), "Staff", "Staff", "5A7E730BF7554FE3A6094730CAE54E92" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "DisplayName", "Name", "NormalizedName" },
                values: new object[] { "74957665-e452-4ee2-98ec-a9017627ec91", new DateTime(2023, 8, 23, 14, 8, 53, 769, DateTimeKind.Local).AddTicks(4343), "Administrator", "Admin", "D24D3CC5E2184FBBBEBC83ECF867D5F1" });

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "b2f05314-107e-42f9-8c7b-d2a42da63bc4", new DateTime(2023, 8, 23, 14, 8, 53, 769, DateTimeKind.Local).AddTicks(4378), "AC410A05725C464091B76EC38677425D" });

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "58cf0b6f-157a-4874-97a1-67d65cdfe5c0", new DateTime(2023, 8, 23, 14, 8, 53, 769, DateTimeKind.Local).AddTicks(4385), "11512C9CBD8246578E0434CCC8498EF1" });

            migrationBuilder.UpdateData(
                table: "AbpRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "NormalizedName" },
                values: new object[] { "9b10e873-1c86-42ff-82dc-1df2cdc2152f", new DateTime(2023, 8, 23, 14, 8, 53, 769, DateTimeKind.Local).AddTicks(4406), "282547FE1302404D9A3BBE99E3E388C3" });
        }
    }
}
