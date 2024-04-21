using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpanishWebProj.Migrations
{
    public partial class AddQuiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Quizes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Quizes", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "QuizQuestions",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        A = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        B = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        C = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        D = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        RightAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        QuizId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_QuizQuestions", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_QuizQuestions_Quizes_QuizId",
            //            column: x => x.QuizId,
            //            principalTable: "Quizes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.InsertData(
            //    table: "Quizes",
            //    columns: new[] { "Id", "Name" },
            //    values: new object[] { 1, "Capitale" });

            //migrationBuilder.InsertData(
            //    table: "QuizQuestions",
            //    columns: new[] { "Id", "A", "B", "C", "D", "QuestionText", "QuizId", "RightAnswer" },
            //    values: new object[] { 1, "Moscow", "Moscow", "Moscow", "Paris", "What is the capital of France?", 1, "Paris" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_QuizQuestions_QuizId",
            //    table: "QuizQuestions",
            //    column: "QuizId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuizQuestions");

            migrationBuilder.DropTable(
                name: "Quizes");
        }
    }
}
