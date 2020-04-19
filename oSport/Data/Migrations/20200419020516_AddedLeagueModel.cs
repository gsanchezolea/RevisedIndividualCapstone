using Microsoft.EntityFrameworkCore.Migrations;

namespace oSport.Data.Migrations
{
    public partial class AddedLeagueModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e31918e-c878-42c3-9a11-6ded01472f6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f726995-9d3b-48c4-a922-b9eed8ca6b48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edadd503-3287-4539-a389-b8e14a49bd59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffab4d37-8d75-47b6-8b82-466b02fdc98e");

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueAdminId = table.Column<int>(nullable: false),
                    SportId = table.Column<int>(nullable: false),
                    LeagueName = table.Column<string>(nullable: false),
                    TeamCapacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leagues_LeagueAdmins_LeagueAdminId",
                        column: x => x.LeagueAdminId,
                        principalTable: "LeagueAdmins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leagues_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6055c0fd-f3e0-495f-b2e5-92d3c62d0089", "0366f1e1-8d09-4819-b1d6-2e445141213d", "League Admin", "LEAGUE ADMIN" },
                    { "ec1ab161-07ef-4286-aef0-3be96091f41f", "b69934b8-61de-4e8d-8cdf-97d563bf50c3", "Coach", "COACH" },
                    { "3ac388b1-e610-47a4-9659-1543bb97a1a3", "008dcaca-7981-456f-a4a3-c03a84cc7bde", "Referee", "REFEREE" },
                    { "8c399974-2a83-4e79-b1a2-3112e5f35be7", "e502e666-baf2-44d6-97c5-8f63b85ff723", "Player", "PLAYER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leagues_LeagueAdminId",
                table: "Leagues",
                column: "LeagueAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Leagues_SportId",
                table: "Leagues",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ac388b1-e610-47a4-9659-1543bb97a1a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6055c0fd-f3e0-495f-b2e5-92d3c62d0089");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c399974-2a83-4e79-b1a2-3112e5f35be7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec1ab161-07ef-4286-aef0-3be96091f41f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ffab4d37-8d75-47b6-8b82-466b02fdc98e", "66778f3a-beb6-416e-ad6a-ebaf4c3fbea2", "League Admin", "LEAGUE ADMIN" },
                    { "9f726995-9d3b-48c4-a922-b9eed8ca6b48", "c8c9715c-c378-4eb8-a4a3-ae80b458b721", "Coach", "COACH" },
                    { "edadd503-3287-4539-a389-b8e14a49bd59", "599e7602-1a71-4b52-80ce-88865148bb67", "Referee", "REFEREE" },
                    { "8e31918e-c878-42c3-9a11-6ded01472f6b", "f2700ca3-97cc-4444-94a8-2cddb02a87b9", "Player", "PLAYER" }
                });
        }
    }
}
