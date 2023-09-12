using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MalamuleleHealth.EFCore.Migrations
{
    public partial class CreatingIdentityScheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "BedId",
                keyValue: new Guid("6ba62bd3-ab14-4bdd-94b9-6bb91b14b6c0"));

            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "BedId",
                keyValue: new Guid("920dfba6-e527-43a4-800e-a1436add7ff1"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("182ce1f4-0a6b-47c5-9978-039d77b27da6"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("781cd3e2-e4e9-40c3-a6ea-2f31df6996a1"));

            migrationBuilder.DeleteData(
                table: "MedicalHistories",
                keyColumn: "MedicalHistoryId",
                keyValue: new Guid("c636ff57-7816-4c8d-a56c-47a6d872487e"));

            migrationBuilder.DeleteData(
                table: "MedicalHistories",
                keyColumn: "MedicalHistoryId",
                keyValue: new Guid("e52b9e22-4e02-4a94-adf2-1f35a0c389d9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: new Guid("921441db-06e1-486f-876e-ab82cb1ca6b4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: new Guid("aec6b6f9-ab5d-44b4-9a6f-776a935b9a79"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: new Guid("08e352e2-281d-4123-8d33-1ab9db276722"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: new Guid("ad12dcef-8a24-4c6e-83ff-42f2831b8fb4"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionId",
                keyValue: new Guid("25d32200-8651-4db7-b3ad-c78070829269"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionId",
                keyValue: new Guid("2b017b05-3bdd-41e2-abc1-d8eaea33de7f"));

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumn: "TestResultId",
                keyValue: new Guid("6331e6ce-d6c2-471b-b06d-403419f790e9"));

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumn: "TestResultId",
                keyValue: new Guid("b227f9e6-e99f-4039-ae60-bcd41f0758a3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: new Guid("56b55b08-1d99-40c3-a6d7-30b1343a27b0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: new Guid("a896f84a-1ed1-44ac-8e39-cf702cb29123"));

            migrationBuilder.DeleteData(
                table: "MedicalTests",
                keyColumn: "MedicalTestId",
                keyValue: new Guid("5d3c266d-1d2c-4fda-b81e-8ed37bbeeb5a"));

            migrationBuilder.DeleteData(
                table: "MedicalTests",
                keyColumn: "MedicalTestId",
                keyValue: new Guid("e131a124-e1ed-4c3a-8439-e6424333f731"));

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "WardId",
                keyValue: new Guid("01d2950a-d07e-4342-8c05-eae2a9e802c6"));

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "WardId",
                keyValue: new Guid("25204199-e961-4eb6-b2e9-781eb9054d14"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("6f93cd11-ea0a-4233-837b-d84ed61b0b1a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("d9421643-354c-4c92-8e8a-0cceb9f58424"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "AppointmentTime", "Purpose", "Status" },
                values: new object[,]
                {
                    { new Guid("f93c9c96-8b35-485a-8133-dc7ecd3706c0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 35, 56, 978, DateTimeKind.Local).AddTicks(1122), "Regular checkup", "Scheduled" },
                    { new Guid("fca8956c-51cb-4dda-8cef-8af45cfff23d"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 35, 56, 978, DateTimeKind.Local).AddTicks(1125), "Follow-up", "Scheduled" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1a3ad739-ee7c-416c-bc17-0d1cc8061e5f"), "Musculoskeletal disorders", "Orthopedics" },
                    { new Guid("a7ecc9c2-3555-4495-81f4-76cc4be0fbf9"), "Heart-related issues", "Cardiology" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "DueDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("1e0b9dad-4afc-4edd-a203-f03dbad262a3"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Paid", 150.25f },
                    { new Guid("bed6edd0-f404-46b7-abc3-aeafd1cfd4df"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Pending", 250.5f }
                });

            migrationBuilder.InsertData(
                table: "MedicalHistories",
                columns: new[] { "MedicalHistoryId", "DiagnosisDate", "MedicalCondition", "Treatment" },
                values: new object[,]
                {
                    { new Guid("109cfc6a-766f-4538-96f5-ffb67011e54e"), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Hypertension", "Medication and lifestyle changes" },
                    { new Guid("467f8328-7a21-4f7b-b058-cad28ae4d135"), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Diabetes", "Insulin therapy" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "AppointmentDate", "AppointmentTime", "Purpose", "Status" },
                values: new object[,]
                {
                    { new Guid("0a4b4ee5-e5f4-44b8-b985-2bd25ee5f113"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 35, 56, 978, DateTimeKind.Local).AddTicks(1532), "Appointment Confirmation", "Sent" },
                    { new Guid("2f465263-a5fd-41fb-8ef5-7ad4b9cd7561"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 13, 35, 56, 978, DateTimeKind.Local).AddTicks(1528), "Appointment Reminder", "Sent" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "PaymentDate" },
                values: new object[,]
                {
                    { new Guid("0bec4e95-534f-4f94-b703-c41f5b0cc55d"), 100.25f, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("bee3252c-4181-4c3d-9476-ef0cf2d47ecd"), 75f, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Wards",
                columns: new[] { "WardId", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("127d9a5e-de40-4221-89ae-ec03d05d33f1"), null, "General Ward" },
                    { new Guid("c36a4447-fe32-4730-9e46-8dcd62647fa0"), null, "Pediatrics Ward" }
                });

            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "BedId", "Availability", "Number", "WardId" },
                values: new object[,]
                {
                    { new Guid("85c88fe7-4d6a-4425-bbfb-0d23de2cb1e9"), true, 101, new Guid("127d9a5e-de40-4221-89ae-ec03d05d33f1") },
                    { new Guid("eb64cfbf-8b4b-43dd-8eb5-ee019feada5c"), false, 102, new Guid("c36a4447-fe32-4730-9e46-8dcd62647fa0") }
                });

            migrationBuilder.InsertData(
                table: "MedicalTests",
                columns: new[] { "MedicalTestId", "Cost", "DepartmentId", "TestName" },
                values: new object[,]
                {
                    { new Guid("53a4f1f6-87c0-49e7-9f2f-430d20bf4846"), 120.5f, new Guid("1a3ad739-ee7c-416c-bc17-0d1cc8061e5f"), "X-Ray" },
                    { new Guid("98eb4918-e379-479f-bd00-a11647121045"), 45f, new Guid("a7ecc9c2-3555-4495-81f4-76cc4be0fbf9"), "Blood Pressure" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionId", "AppointmentId", "Instructions", "Medication", "PrescriptionDate" },
                values: new object[,]
                {
                    { new Guid("ce40bfb5-2087-4ad6-afe9-5f1f8d57898e"), new Guid("f93c9c96-8b35-485a-8133-dc7ecd3706c0"), "Take one tablet daily", "Aspirin", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ee3573bb-e323-4f77-9dae-7cb2fd9bac0f"), new Guid("fca8956c-51cb-4dda-8cef-8af45cfff23d"), "Take as needed for pain", "Ibuprofen", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "TestResultId", "MedicalTestId", "ResultDetails", "TestDate" },
                values: new object[] { new Guid("e10efd31-a1df-4303-b411-dd82f2843358"), new Guid("98eb4918-e379-479f-bd00-a11647121045"), "Normal blood pressure reading", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "TestResultId", "MedicalTestId", "ResultDetails", "TestDate" },
                values: new object[] { new Guid("fe1300d0-72b4-4fac-839c-3d0e010ac7fe"), new Guid("53a4f1f6-87c0-49e7-9f2f-430d20bf4846"), "No fractures detected", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "BedId",
                keyValue: new Guid("85c88fe7-4d6a-4425-bbfb-0d23de2cb1e9"));

            migrationBuilder.DeleteData(
                table: "Beds",
                keyColumn: "BedId",
                keyValue: new Guid("eb64cfbf-8b4b-43dd-8eb5-ee019feada5c"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("1e0b9dad-4afc-4edd-a203-f03dbad262a3"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("bed6edd0-f404-46b7-abc3-aeafd1cfd4df"));

            migrationBuilder.DeleteData(
                table: "MedicalHistories",
                keyColumn: "MedicalHistoryId",
                keyValue: new Guid("109cfc6a-766f-4538-96f5-ffb67011e54e"));

            migrationBuilder.DeleteData(
                table: "MedicalHistories",
                keyColumn: "MedicalHistoryId",
                keyValue: new Guid("467f8328-7a21-4f7b-b058-cad28ae4d135"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: new Guid("0a4b4ee5-e5f4-44b8-b985-2bd25ee5f113"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: new Guid("2f465263-a5fd-41fb-8ef5-7ad4b9cd7561"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: new Guid("0bec4e95-534f-4f94-b703-c41f5b0cc55d"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: new Guid("bee3252c-4181-4c3d-9476-ef0cf2d47ecd"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionId",
                keyValue: new Guid("ce40bfb5-2087-4ad6-afe9-5f1f8d57898e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionId",
                keyValue: new Guid("ee3573bb-e323-4f77-9dae-7cb2fd9bac0f"));

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumn: "TestResultId",
                keyValue: new Guid("e10efd31-a1df-4303-b411-dd82f2843358"));

            migrationBuilder.DeleteData(
                table: "TestResults",
                keyColumn: "TestResultId",
                keyValue: new Guid("fe1300d0-72b4-4fac-839c-3d0e010ac7fe"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: new Guid("f93c9c96-8b35-485a-8133-dc7ecd3706c0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: new Guid("fca8956c-51cb-4dda-8cef-8af45cfff23d"));

            migrationBuilder.DeleteData(
                table: "MedicalTests",
                keyColumn: "MedicalTestId",
                keyValue: new Guid("53a4f1f6-87c0-49e7-9f2f-430d20bf4846"));

            migrationBuilder.DeleteData(
                table: "MedicalTests",
                keyColumn: "MedicalTestId",
                keyValue: new Guid("98eb4918-e379-479f-bd00-a11647121045"));

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "WardId",
                keyValue: new Guid("127d9a5e-de40-4221-89ae-ec03d05d33f1"));

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "WardId",
                keyValue: new Guid("c36a4447-fe32-4730-9e46-8dcd62647fa0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("1a3ad739-ee7c-416c-bc17-0d1cc8061e5f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("a7ecc9c2-3555-4495-81f4-76cc4be0fbf9"));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "AppointmentTime", "Purpose", "Status" },
                values: new object[,]
                {
                    { new Guid("56b55b08-1d99-40c3-a6d7-30b1343a27b0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 12, 51, 2, 428, DateTimeKind.Local).AddTicks(5142), "Follow-up", "Scheduled" },
                    { new Guid("a896f84a-1ed1-44ac-8e39-cf702cb29123"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 12, 51, 2, 428, DateTimeKind.Local).AddTicks(5139), "Regular checkup", "Scheduled" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6f93cd11-ea0a-4233-837b-d84ed61b0b1a"), "Heart-related issues", "Cardiology" },
                    { new Guid("d9421643-354c-4c92-8e8a-0cceb9f58424"), "Musculoskeletal disorders", "Orthopedics" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "DueDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("182ce1f4-0a6b-47c5-9978-039d77b27da6"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Paid", 150.25f },
                    { new Guid("781cd3e2-e4e9-40c3-a6ea-2f31df6996a1"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Pending", 250.5f }
                });

            migrationBuilder.InsertData(
                table: "MedicalHistories",
                columns: new[] { "MedicalHistoryId", "DiagnosisDate", "MedicalCondition", "Treatment" },
                values: new object[,]
                {
                    { new Guid("c636ff57-7816-4c8d-a56c-47a6d872487e"), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Diabetes", "Insulin therapy" },
                    { new Guid("e52b9e22-4e02-4a94-adf2-1f35a0c389d9"), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "Hypertension", "Medication and lifestyle changes" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "AppointmentDate", "AppointmentTime", "Purpose", "Status" },
                values: new object[,]
                {
                    { new Guid("921441db-06e1-486f-876e-ab82cb1ca6b4"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 12, 51, 2, 428, DateTimeKind.Local).AddTicks(5455), "Appointment Reminder", "Sent" },
                    { new Guid("aec6b6f9-ab5d-44b4-9a6f-776a935b9a79"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 9, 12, 12, 51, 2, 428, DateTimeKind.Local).AddTicks(5459), "Appointment Confirmation", "Sent" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "PaymentDate" },
                values: new object[,]
                {
                    { new Guid("08e352e2-281d-4123-8d33-1ab9db276722"), 75f, new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ad12dcef-8a24-4c6e-83ff-42f2831b8fb4"), 100.25f, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Wards",
                columns: new[] { "WardId", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("01d2950a-d07e-4342-8c05-eae2a9e802c6"), null, "General Ward" },
                    { new Guid("25204199-e961-4eb6-b2e9-781eb9054d14"), null, "Pediatrics Ward" }
                });

            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "BedId", "Availability", "Number", "WardId" },
                values: new object[,]
                {
                    { new Guid("6ba62bd3-ab14-4bdd-94b9-6bb91b14b6c0"), false, 102, new Guid("25204199-e961-4eb6-b2e9-781eb9054d14") },
                    { new Guid("920dfba6-e527-43a4-800e-a1436add7ff1"), true, 101, new Guid("01d2950a-d07e-4342-8c05-eae2a9e802c6") }
                });

            migrationBuilder.InsertData(
                table: "MedicalTests",
                columns: new[] { "MedicalTestId", "Cost", "DepartmentId", "TestName" },
                values: new object[,]
                {
                    { new Guid("5d3c266d-1d2c-4fda-b81e-8ed37bbeeb5a"), 45f, new Guid("6f93cd11-ea0a-4233-837b-d84ed61b0b1a"), "Blood Pressure" },
                    { new Guid("e131a124-e1ed-4c3a-8439-e6424333f731"), 120.5f, new Guid("d9421643-354c-4c92-8e8a-0cceb9f58424"), "X-Ray" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionId", "AppointmentId", "Instructions", "Medication", "PrescriptionDate" },
                values: new object[,]
                {
                    { new Guid("25d32200-8651-4db7-b3ad-c78070829269"), new Guid("56b55b08-1d99-40c3-a6d7-30b1343a27b0"), "Take as needed for pain", "Ibuprofen", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2b017b05-3bdd-41e2-abc1-d8eaea33de7f"), new Guid("a896f84a-1ed1-44ac-8e39-cf702cb29123"), "Take one tablet daily", "Aspirin", new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "TestResultId", "MedicalTestId", "ResultDetails", "TestDate" },
                values: new object[] { new Guid("6331e6ce-d6c2-471b-b06d-403419f790e9"), new Guid("e131a124-e1ed-4c3a-8439-e6424333f731"), "No fractures detected", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "TestResults",
                columns: new[] { "TestResultId", "MedicalTestId", "ResultDetails", "TestDate" },
                values: new object[] { new Guid("b227f9e6-e99f-4039-ae60-bcd41f0758a3"), new Guid("5d3c266d-1d2c-4fda-b81e-8ed37bbeeb5a"), "Normal blood pressure reading", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
