using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpanishWebProj.Migrations
{
    public partial class bbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropIndex(
            //    name: "IX_ForumMessages_ProfileId",
            //    table: "ForumMessages");

            //migrationBuilder.DropIndex(
            //    name: "IX_ForumMessages_UserId",
            //    table: "ForumMessages");

            //migrationBuilder.DropColumn(
            //    name: "ForumMessageId",
            //    table: "ForumTopics");

            //migrationBuilder.DropColumn(
            //    name: "ForumTopicId",
            //    table: "ForumCategories");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Age",
            //    table: "Profiles",
            //    type: "int",
            //    nullable: true,
            //    oldClrType: typeof(int),
            //    oldType: "int");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumMessages_ProfileId",
            //    table: "ForumMessages",
            //    column: "ProfileId",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumMessages_UserId",
            //    table: "ForumMessages",
            //    column: "UserId",
            //    unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ForumMessages_ProfileId",
                table: "ForumMessages");

            migrationBuilder.DropIndex(
                name: "IX_ForumMessages_UserId",
                table: "ForumMessages");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ForumMessageId",
                table: "ForumTopics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ForumTopicId",
                table: "ForumCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ForumMessages_ProfileId",
                table: "ForumMessages",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumMessages_UserId",
                table: "ForumMessages",
                column: "UserId");
        }
    }
}
