using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpanishWebProj.Migrations
{
    public partial class changedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.DropForeignKey(
            //        name: "FK_ForumMessages_Profiles_ProfileId1",
            //        table: "ForumMessages");

            //    migrationBuilder.DropIndex(
            //        name: "IX_ForumMessages_ProfileId1",
            //        table: "ForumMessages");

            //    migrationBuilder.DropColumn(
            //        name: "ProfileId1",
            //        table: "ForumMessages");

            //    migrationBuilder.AlterColumn<int>(
            //        name: "Id",
            //        table: "Profiles",
            //        type: "int",
            //        nullable: false,
            //        oldClrType: typeof(long),
            //        oldType: "bigint")
            //        .Annotation("SqlServer:Identity", "1, 1")
            //        .OldAnnotation("SqlServer:Identity", "1, 1");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_ForumMessages_ProfileId",
            //        table: "ForumMessages",
            //        column: "ProfileId");

            //    migrationBuilder.AddForeignKey(
            //        name: "FK_ForumMessages_Profiles_ProfileId",
            //        table: "ForumMessages",
            //        column: "ProfileId",
            //        principalTable: "Profiles",
            //        principalColumn: "Id",
            //        onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumMessages_Profiles_ProfileId",
                table: "ForumMessages");

            migrationBuilder.DropIndex(
                name: "IX_ForumMessages_ProfileId",
                table: "ForumMessages");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Profiles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "ProfileId1",
                table: "ForumMessages",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_ForumMessages_ProfileId1",
                table: "ForumMessages",
                column: "ProfileId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumMessages_Profiles_ProfileId1",
                table: "ForumMessages",
                column: "ProfileId1",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
