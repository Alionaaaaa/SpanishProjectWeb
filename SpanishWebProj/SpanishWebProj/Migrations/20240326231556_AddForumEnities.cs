using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpanishWebProj.Migrations
{
    public partial class AddForumEnities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "ForumCategories",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ForumTopicId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ForumCategories", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ForumTopics",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ForumCategoryId = table.Column<int>(type: "int", nullable: false),
            //        ForumMessageId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ForumTopics", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ForumTopics_ForumCategories_ForumCategoryId",
            //            column: x => x.ForumCategoryId,
            //            principalTable: "ForumCategories",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ForumMessages",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PostDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ForumTopicId = table.Column<int>(type: "int", nullable: false),
            //        ProfileId = table.Column<int>(type: "int", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: false)
            //        //ProfileId1 = table.Column<long>(type: "bigint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ForumMessages", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ForumMessages_ForumTopics_ForumTopicId",
            //            column: x => x.ForumTopicId,
            //            principalTable: "ForumTopics",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_ForumMessages_Profiles_ProfileId",
            //            column: x => x.ProfileId,
            //            principalTable: "Profiles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_ForumMessages_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumMessages_ForumTopicId",
            //    table: "ForumMessages",
            //    column: "ForumTopicId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumMessages_ProfileId",
            //    table: "ForumMessages",
            //    column: "ProfileId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumMessages_UserId",
            //    table: "ForumMessages",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumTopics_ForumCategoryId",
            //    table: "ForumTopics",
            //    column: "ForumCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumMessages");

            migrationBuilder.DropTable(
                name: "ForumTopics");

            migrationBuilder.DropTable(
                name: "ForumCategories");
        }
    }
}
