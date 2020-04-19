using Microsoft.EntityFrameworkCore.Migrations;

namespace oSport.Data.Migrations
{
    public partial class AddedFourModelsAndGlobalRouting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2df65992-dec6-455c-a9c5-1e1362f37707");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac7f10ca-3bb0-4a0f-941a-d60c4d7f1dea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0b69623-ede8-4d1c-8b9a-c87dda51e9ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd67eb7-c71e-4ed0-bbdd-459f8bde4aef");

            migrationBuilder.CreateTable(
                name: "Coaches",
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
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coaches_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "League_Admins",
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
                    table.PrimaryKey("PK_League_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_League_Admins_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Players",
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
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Referees",
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
                    table.PrimaryKey("PK_Referees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referees_AspNetUsers_IdentityUserId",
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
                    { "669bacdf-114e-4d6e-87ff-21b2e9de523f", "0a5bcd42-e767-4476-bab1-93706a3956e2", "League Admin", "LEAGUE Admin" },
                    { "eccfc8a0-c708-4c68-9bde-69e869443b12", "a96fcdc0-527e-4a36-85f8-1ad256ddc2e1", "Coach", "COACH" },
                    { "91309a07-e632-400e-aa49-e6ce2624ed32", "3888a75b-4cfb-4044-ba8c-df9ab10c85a1", "Referee", "REFEREE" },
                    { "003531fe-e2bc-4930-b775-f312c00a05d2", "fa09b306-dae5-45a4-84bf-4c50bed1307f", "Player", "PLAYER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_IdentityUserId",
                table: "Coaches",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_League_Admins_IdentityUserId",
                table: "League_Admins",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_IdentityUserId",
                table: "Players",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Referees_IdentityUserId",
                table: "Referees",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "League_Admins");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Referees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "003531fe-e2bc-4930-b775-f312c00a05d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "669bacdf-114e-4d6e-87ff-21b2e9de523f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91309a07-e632-400e-aa49-e6ce2624ed32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eccfc8a0-c708-4c68-9bde-69e869443b12");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2df65992-dec6-455c-a9c5-1e1362f37707", "6fcc41e0-b7a0-4244-807c-7a6f6931bc4d", "League Admin", "LEAGUE Admin" },
                    { "ffd67eb7-c71e-4ed0-bbdd-459f8bde4aef", "e8be01ea-90e1-4f88-89d8-f8c66c7813a1", "Coach", "COACH" },
                    { "c0b69623-ede8-4d1c-8b9a-c87dda51e9ec", "da6de49d-d07d-44ab-a703-728642a4b3db", "Referee", "REFEREE" },
                    { "ac7f10ca-3bb0-4a0f-941a-d60c4d7f1dea", "90cda2ee-2981-49bd-b154-d57ce791376f", "Player", "PLAYER" }
                });
        }
    }
}
