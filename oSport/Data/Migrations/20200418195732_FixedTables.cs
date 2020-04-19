using Microsoft.EntityFrameworkCore.Migrations;

namespace oSport.Data.Migrations
{
    public partial class FixedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
