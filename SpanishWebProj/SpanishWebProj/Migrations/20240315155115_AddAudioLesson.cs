using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpanishWebProj.Migrations
{
    public partial class AddAudioLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.CreateTable(
        //        name: "AudioLessons",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
        //            ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Level = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AudioLessons", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AudioEntities",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            TextSpanish = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            TextRomanian = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            SoundSpanishPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SoundRomanianPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IdAudioLesson = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AudioEntities", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_AudioEntities_AudioLessons_IdAudioLesson",
        //                column: x => x.IdAudioLesson,
        //                principalTable: "AudioLessons",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.InsertData(
        //        table: "AudioLessons",
        //        columns: new[] { "Id", "ImagePath", "Level", "Subject" },
        //        values: new object[] { 1, "/images/audioLesson/animale.jpg", 0, "Animale" });

        //    migrationBuilder.InsertData(
        //        table: "AudioLessons",
        //        columns: new[] { "Id", "ImagePath", "Level", "Subject" },
        //        values: new object[] { 2, "/images/audioLesson/0.jpg", 1, "Emoții" });

        //    //migrationBuilder.InsertData(
        //    //    table: "Courses",
        //    //    columns: new[] { "Id", "Avatar", "Description", "Name", "TypeCourse" },
        //    //    values: new object[] { 1, null, "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "curs", 0 });

        //    migrationBuilder.InsertData(
        //        table: "AudioEntities",
        //        columns: new[] { "Id", "IdAudioLesson", "ImagePath", "SoundRomanianPath", "SoundSpanishPath", "TextRomanian", "TextSpanish" },
        //        values: new object[] { 1, 1, null, null, null, "Brosacă țestoasă", "Tortuga" });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AudioEntities_IdAudioLesson",
        //        table: "AudioEntities",
        //        column: "IdAudioLesson");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AudioEntities");

            migrationBuilder.DropTable(
                name: "AudioLessons");

            //migrationBuilder.DeleteData(
            //    table: "Courses",
            //    keyColumn: "Id",
            //    keyValue: 1);
        }
    }
}
