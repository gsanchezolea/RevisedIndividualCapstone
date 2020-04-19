using Microsoft.EntityFrameworkCore.Migrations;

namespace oSport.Data.Migrations
{
    public partial class AddedSportModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e5a7523-d39d-457a-9ede-e73d6bca37b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f8fae40-4c75-4a5e-8c72-bb4a28b55144");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba2d51a8-a8bf-4535-9d37-9bc65381c7ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c316635c-dae3-4b3e-a79c-a902a3910fa3");

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Soccer" },
                    { 2, "Football" },
                    { 3, "Basketball" },
                    { 4, "Hockey" },
                    { 5, "Rugby" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sports");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e5a7523-d39d-457a-9ede-e73d6bca37b6", "78ff0664-2acc-43f5-bfb5-54a6a6cdb0f8", "League Admin", "LEAGUE ADMIN" },
                    { "ba2d51a8-a8bf-4535-9d37-9bc65381c7ed", "dff49cd8-e296-435e-982b-38d2f498568e", "Coach", "COACH" },
                    { "5f8fae40-4c75-4a5e-8c72-bb4a28b55144", "42bbfe4a-c34a-4f01-9c32-1a6a20d0d4c8", "Referee", "REFEREE" },
                    { "c316635c-dae3-4b3e-a79c-a902a3910fa3", "cbe64610-0c49-4d70-a7fd-d956426adb07", "Player", "PLAYER" }
                });
        }
    }
}
