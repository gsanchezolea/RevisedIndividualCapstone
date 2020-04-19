using Microsoft.EntityFrameworkCore.Migrations;

namespace oSport.Data.Migrations
{
    public partial class SecondFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "League_Admins");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a74645a-d547-48d7-ae02-03d4016fc07f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5896bd2-7add-454a-8fec-aabd0e7f0084");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e4067a-da36-4aa5-a995-18bfc928d09e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f03c11ea-80f9-4bf1-bf2f-cd1fa4c1ca73");

            migrationBuilder.CreateTable(
                name: "LeagueAdmins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueAdmins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeagueAdmins_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "77c6733d-4d58-4ebd-8505-1ae29545f0fa", "bee7e158-e314-4fdd-b86b-a854eb95dd31", "League Admin", "LEAGUE ADMIN" },
                    { "3f3f189d-2bf9-4742-858d-e21f56d4ba4e", "8d8516dd-4894-4e41-8578-750672879cd0", "Coach", "COACH" },
                    { "cdf6f66a-c8eb-46d8-b29c-317fa8f6bc8e", "9b7cb790-57e9-4c59-9370-93b310fe535d", "Referee", "REFEREE" },
                    { "82c7a814-6e90-4482-892c-d95c53abad8e", "1ba564b2-6d0e-45ba-b8ec-bb045b72de0e", "Player", "PLAYER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeagueAdmins_IdentityUserId",
                table: "LeagueAdmins",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeagueAdmins");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f3f189d-2bf9-4742-858d-e21f56d4ba4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77c6733d-4d58-4ebd-8505-1ae29545f0fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82c7a814-6e90-4482-892c-d95c53abad8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdf6f66a-c8eb-46d8-b29c-317fa8f6bc8e");

            migrationBuilder.CreateTable(
                name: "League_Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_League_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_League_Admins_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9a74645a-d547-48d7-ae02-03d4016fc07f", "f4fe7379-2b98-4f86-8e1a-a18111f2eae9", "League Admin", "LEAGUE Admin" },
                    { "b4e4067a-da36-4aa5-a995-18bfc928d09e", "d5532a65-6618-4d44-9325-8a22bd36aee9", "Coach", "COACH" },
                    { "a5896bd2-7add-454a-8fec-aabd0e7f0084", "ed65b110-7984-4165-a8a7-1e658e343bef", "Referee", "REFEREE" },
                    { "f03c11ea-80f9-4bf1-bf2f-cd1fa4c1ca73", "91c8e525-6ed5-404d-8740-1870158d633b", "Player", "PLAYER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_League_Admins_IdentityUserId",
                table: "League_Admins",
                column: "IdentityUserId");
        }
    }
}
