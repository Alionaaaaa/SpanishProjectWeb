using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpanishWebProj.Migrations
{
    public partial class ha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ////migrationBuilder.CreateTable(
            ////    name: "AudioLessons",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            ////        ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Level = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_AudioLessons", x => x.Id);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "Courses",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        TypeCourse = table.Column<int>(type: "int", nullable: false),
            ////        Avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_Courses", x => x.Id);
            ////    });

            //migrationBuilder.CreateTable(
            //    name: "ForumCategories",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ForumCategories", x => x.Id);
            //    });

            ////migrationBuilder.CreateTable(
            ////    name: "Quizes",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_Quizes", x => x.Id);
            ////    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        Role = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //    });

            ////migrationBuilder.CreateTable(
            ////    name: "WorksheetCategory",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        NameCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_WorksheetCategory", x => x.Id);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "AudioEntities",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        TextSpanish = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        TextRomanian = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        SoundSpanishPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        SoundRomanianPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        IdAudioLesson = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_AudioEntities", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_AudioEntities_AudioLessons_IdAudioLesson",
            ////            column: x => x.IdAudioLesson,
            ////            principalTable: "AudioLessons",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            //migrationBuilder.CreateTable(
            //    name: "ForumTopics",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ForumCategoryId = table.Column<int>(type: "int", nullable: false)
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

            ////migrationBuilder.CreateTable(
            ////    name: "QuizQuestions",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        A = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        B = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        C = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        D = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        RightAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        QuizId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_QuizQuestions", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_QuizQuestions_Quizes_QuizId",
            ////            column: x => x.QuizId,
            ////            principalTable: "Quizes",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            //migrationBuilder.CreateTable(
            //    name: "Profiles",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Age = table.Column<int>(type: "int", nullable: true),
            //        UserId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Profiles", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Profiles_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            ////migrationBuilder.CreateTable(
            ////    name: "Worksheets",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        Level = table.Column<int>(type: "int", nullable: false),
            ////        WorksheetCategoryId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_Worksheets", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_Worksheets_WorksheetCategory_WorksheetCategoryId",
            ////            column: x => x.WorksheetCategoryId,
            ////            principalTable: "WorksheetCategory",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

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
            //            onDelete: ReferentialAction.Restrict, // Sau NO ACTION, în funcție de logica aplicației tale
            //            onUpdate: ReferentialAction.Restrict); // Sau NO ACTION, în funcție de logica aplicației tale

            //    });

            ////migrationBuilder.InsertData(
            ////    table: "AudioLessons",
            ////    columns: new[] { "Id", "ImagePath", "Level", "Subject" },
            ////    values: new object[,]
            ////    {
            ////        { 1, "/images/audioLesson/animale.jpg", 0, "Animale" },
            ////        { 2, "/images/audioLesson/0.jpg", 0, "Emoții" }
            ////    });

            ////migrationBuilder.InsertData(
            ////    table: "Quizes",
            ////    columns: new[] { "Id", "Name" },
            ////    values: new object[] { 1, "Capitale" });

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "Id", "Name", "Password", "Role" },
            //    values: new object[,]
            //    {
            //        { 1, "Ana", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 },
            //        { 2, "Aliona", "481f6cc0511143ccdd7e2d1b1b94faf0a700a8b49cd13922a70b5ae28acaa8c5", 1 }
            //    });

            ////migrationBuilder.InsertData(
            ////    table: "AudioEntities",
            ////    columns: new[] { "Id", "IdAudioLesson", "ImagePath", "SoundRomanianPath", "SoundSpanishPath", "TextRomanian", "TextSpanish" },
            ////    values: new object[] { 1, 1, null, null, null, "Brosacă țestoasă", "Tortuga" });

            ////migrationBuilder.InsertData(
            ////    table: "QuizQuestions",
            ////    columns: new[] { "Id", "A", "B", "C", "D", "QuestionText", "QuizId", "RightAnswer" },
            ////    values: new object[] { 1, "Moscow", "Moscow", "Moscow", "Paris", "What is the capital of France?", 1, "Paris" });

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_AudioEntities_IdAudioLesson",
            ////    table: "AudioEntities",
            ////    column: "IdAudioLesson");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumMessages_ForumTopicId",
            //    table: "ForumMessages",
            //    column: "ForumTopicId");

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

            //migrationBuilder.CreateIndex(
            //    name: "IX_ForumTopics_ForumCategoryId",
            //    table: "ForumTopics",
            //    column: "ForumCategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Profiles_UserId",
            //    table: "Profiles",
            //    column: "UserId",
            //    unique: true);

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_QuizQuestions_QuizId",
            ////    table: "QuizQuestions",
            ////    column: "QuizId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_Worksheets_WorksheetCategoryId",
            ////    table: "Worksheets",
            ////    column: "WorksheetCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "AudioEntities");

            //migrationBuilder.DropTable(
            //    name: "Courses");

            migrationBuilder.DropTable(
                name: "ForumMessages");

            //migrationBuilder.DropTable(
            //    name: "QuizQuestions");

            //migrationBuilder.DropTable(
            //    name: "Worksheets");

            //migrationBuilder.DropTable(
            //    name: "AudioLessons");

            migrationBuilder.DropTable(
                name: "ForumTopics");

            migrationBuilder.DropTable(
                name: "Profiles");

            //migrationBuilder.DropTable(
            //    name: "Quizes");

            //migrationBuilder.DropTable(
            //    name: "WorksheetCategory");

            migrationBuilder.DropTable(
                name: "ForumCategories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
