using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpanishWebProj.Migrations
{
    public partial class ForumRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_ForumMessages_Profiles_ProfileId",
            //    table: "ForumMessages");

            //migrationBuilder.DropIndex(
            //    name: "IX_ForumMessages_ProfileId",
            //    table: "ForumMessages");

            //migrationBuilder.DropIndex(
            //    name: "IX_ForumMessages_UserId",
            //    table: "ForumMessages");

            //migrationBuilder.DropColumn(
            //    name: "ProfileId",
            //    table: "ForumMessages");

            //migrationBuilder.AddColumn<int>(
            //    name: "Level",
            //    table: "Profiles",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Description",
            //    table: "ForumTopics",
            //    type: "nvarchar(max)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)");

            //migrationBuilder.AddColumn<int>(
            //    name: "UserId",
            //    table: "ForumTopics",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<int>(
            //    name: "UserId",
            //    table: "ForumCategories",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumTopics_UserId",
            //    table: "ForumTopics",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumMessages_UserId",
            //    table: "ForumMessages",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumCategories_UserId",
            //    table: "ForumCategories",
            //    column: "UserId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ForumCategories_Users_UserId",
            //    table: "ForumCategories",
            //    column: "UserId",
            //    principalTable: "Users",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ForumTopics_Users_UserId",
            //    table: "ForumTopics",
            //    column: "UserId",
            //    principalTable: "Users",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumCategories_Users_UserId",
                table: "ForumCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumTopics_Users_UserId",
                table: "ForumTopics");

            migrationBuilder.DropIndex(
                name: "IX_ForumTopics_UserId",
                table: "ForumTopics");

            migrationBuilder.DropIndex(
                name: "IX_ForumMessages_UserId",
                table: "ForumMessages");

            migrationBuilder.DropIndex(
                name: "IX_ForumCategories_UserId",
                table: "ForumCategories");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ForumTopics");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ForumCategories");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ForumTopics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "ForumMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ForumMessages_ProfileId",
                table: "ForumMessages",
                column: "ProfileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ForumMessages_UserId",
                table: "ForumMessages",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumMessages_Profiles_ProfileId",
                table: "ForumMessages",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
