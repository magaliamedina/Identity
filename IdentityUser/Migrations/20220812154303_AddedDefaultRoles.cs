using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityUsuario.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64bcdf1f-1295-433e-9755-8fa4e2910f72", "7417f276-3c94-4853-842d-e9b249226f6b", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8863e91e-ae3b-41b5-bddb-727d1b863d2f", "445d2572-4fdc-446f-ba62-e0e5f5ca7666", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64bcdf1f-1295-433e-9755-8fa4e2910f72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8863e91e-ae3b-41b5-bddb-727d1b863d2f");
        }
    }
}
