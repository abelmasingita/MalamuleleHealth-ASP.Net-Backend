using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.EFCore.Migrations
{
    public partial class initMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22a454ee-f2a4-4989-a84c-8ca31989bd34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f80112c-0512-4c04-a921-7ddc4e0e502a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95c33e9f-2743-4c19-987f-1c373503e5df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97abac53-92de-4486-921e-fc7a1ca3f8cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c45c2c36-0177-4517-bf51-c241db2041e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb2c1291-a7ba-4641-abd3-c8e17d79852a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c790f32-1d98-445a-8bf4-c960bdc2e365", "e99ee865-c2e1-4217-bb09-758012f302eb", "Nurse", "NURSE" },
                    { "2478a9c8-2e73-44ea-98e7-ac4e62fbd488", "ce242d35-5a91-4278-9ab6-cd85ef40f632", "Patient", "PATIENT" },
                    { "455a1df2-785e-44cc-b8af-709accdf2eea", "49eb3630-d4ca-41d5-89c0-fcc609924ef7", "Pharmacist", "PHARMACIST" },
                    { "6aa445d3-726e-4700-9954-5040bf384131", "a753e8a0-da83-4a96-9006-a04892eda2b4", "Administrator", "ADMINISTRATOR" },
                    { "e8d66692-ade8-4f9a-864f-600819319ad6", "722b3c2f-2f49-4f3a-8945-f1d9731fbef4", "LabTechnician", "LATTECHNICIAN" },
                    { "f1004083-4e3f-4993-b888-0bd66444bf4b", "c8472337-8ec9-434f-ba0c-7f3396a48ca0", "Doctor", "DOCTOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c790f32-1d98-445a-8bf4-c960bdc2e365");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2478a9c8-2e73-44ea-98e7-ac4e62fbd488");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "455a1df2-785e-44cc-b8af-709accdf2eea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aa445d3-726e-4700-9954-5040bf384131");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8d66692-ade8-4f9a-864f-600819319ad6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1004083-4e3f-4993-b888-0bd66444bf4b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22a454ee-f2a4-4989-a84c-8ca31989bd34", "ccbc01fc-d0be-44aa-964e-b9547c35b250", "Pharmacist", "PHARMACIST" },
                    { "7f80112c-0512-4c04-a921-7ddc4e0e502a", "0ead6611-67b4-408a-b59a-5e0bc5129e2d", "LabTechnician", "LATTECHNICIAN" },
                    { "95c33e9f-2743-4c19-987f-1c373503e5df", "f48b11ab-71b6-4f01-87d4-fe88da5f58da", "Doctor", "DOCTOR" },
                    { "97abac53-92de-4486-921e-fc7a1ca3f8cc", "044d00d7-0d55-4ac2-b412-bc380c7cb604", "Patient", "PATIENT" },
                    { "c45c2c36-0177-4517-bf51-c241db2041e5", "e0b4399d-e55c-4f38-ba7a-ea30f5828762", "Administrator", "ADMINISTRATOR" },
                    { "eb2c1291-a7ba-4641-abd3-c8e17d79852a", "987b7126-e95a-439d-bc41-9e64a8ae4a08", "Nurse", "NURSE" }
                });
        }
    }
}
