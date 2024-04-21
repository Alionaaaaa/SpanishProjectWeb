using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpanishWebProj.Migrations
{
    public partial class changeUserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.DeleteData(
            //        table: "Profiles",
            //        keyColumn: "Id",
            //        keyValue: 1L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Age", "Image", "UserId" },
                values: new object[] { 1L, 0, null, 1 });
        }
    }
}
