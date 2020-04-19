using Microsoft.EntityFrameworkCore.Migrations;

namespace oSport.Data.Migrations
{
    public partial class AddedRegisterChannelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "9a74645a-d547-48d7-ae02-03d4016fc07f", "f4fe7379-2b98-4f86-8e1a-a18111f2eae9", "League Admin", "LEAGUE Admin" },
                    { "b4e4067a-da36-4aa5-a995-18bfc928d09e", "d5532a65-6618-4d44-9325-8a22bd36aee9", "Coach", "COACH" },
                    { "a5896bd2-7add-454a-8fec-aabd0e7f0084", "ed65b110-7984-4165-a8a7-1e658e343bef", "Referee", "REFEREE" },
                    { "f03c11ea-80f9-4bf1-bf2f-cd1fa4c1ca73", "91c8e525-6ed5-404d-8740-1870158d633b", "Player", "PLAYER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
