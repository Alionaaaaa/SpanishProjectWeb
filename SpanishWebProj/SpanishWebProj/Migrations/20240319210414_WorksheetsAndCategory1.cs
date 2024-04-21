using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpanishWebProj.Migrations
{
    public partial class WorksheetsAndCategory1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.CreateTable(
            //        name: "WorksheetCategory",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(type: "int", nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            NameCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_WorksheetCategory", x => x.Id);
            //        });

            //    migrationBuilder.CreateTable(
            //        name: "Worksheets",
            //        columns: table => new
            //        {
            //            Id = table.Column<int>(type: "int", nullable: false)
            //                .Annotation("SqlServer:Identity", "1, 1"),
            //            Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //            Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //            Level = table.Column<int>(type: "int", nullable: false),
            //            IdWorksheetCategory = table.Column<int>(type: "int", nullable: false)
            //        },
            //        constraints: table =>
            //        {
            //            table.PrimaryKey("PK_Worksheets", x => x.Id);
            //            table.ForeignKey(
            //                name: "FK_Worksheets_WorksheetCategory_IdWorksheetCategory",
            //                column: x => x.IdWorksheetCategory,
            //                principalTable: "WorksheetCategory",
            //                principalColumn: "Id",
            //                onDelete: ReferentialAction.Cascade);
            //        });


            //    migrationBuilder.CreateIndex(
            //        name: "IX_Worksheets_IdWorksheetCategory",
            //        table: "Worksheets",
            //        column: "IdWorksheetCategory");


            //migrationBuilder.DropForeignKey(
            //        name: "FK_Worksheets_WorksheetCategory_IdWorksheetCategory",
            //        table: "Worksheets");

            //    migrationBuilder.DropIndex(
            //        name: "IX_Worksheets_IdWorksheetCategory",
            //        table: "Worksheets");

            //    migrationBuilder.AddColumn<int>(
            //        name: "WorksheetCategoryId",
            //        table: "Worksheets",
            //        type: "int",
            //        nullable: false,
            //        defaultValue: 0);

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Worksheets_WorksheetCategoryId",
            //        table: "Worksheets",
            //        column: "WorksheetCategoryId");

            //    migrationBuilder.AddForeignKey(
            //        name: "FK_Worksheets_WorksheetCategory_WorksheetCategoryId",
            //        table: "Worksheets",
            //        column: "WorksheetCategoryId",
            //        principalTable: "WorksheetCategory",
            //        principalColumn: "Id",
            
            
            
            //        onDelete: ReferentialAction.Cascade);
            //migrationBuilder.DropForeignKey(
            //        name: "FK_Worksheets_WorksheetCategory_WorksheetCategoryId",
            //        table: "Worksheets");

            //migrationBuilder.DropIndex(
            //    name: "IX_Worksheets_WorksheetCategoryId",
            //    table: "Worksheets");

            //migrationBuilder.DropColumn(
            //    name: "WorksheetCategoryId",
            //    table: "Worksheets");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Worksheets_IdWorksheetCategory",
            //    table: "Worksheets",
            //    column: "IdWorksheetCategory");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Worksheets_WorksheetCategory_IdWorksheetCategory",
            //    table: "Worksheets",
            //    column: "IdWorksheetCategory",
            //    principalTable: "WorksheetCategory",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Worksheets_WorksheetCategory_WorksheetCategoryId",
                table: "Worksheets");

            migrationBuilder.DropIndex(
                name: "IX_Worksheets_WorksheetCategoryId",
                table: "Worksheets");

            migrationBuilder.DropColumn(
                name: "WorksheetCategoryId",
                table: "Worksheets");

            migrationBuilder.CreateIndex(
                name: "IX_Worksheets_IdWorksheetCategory",
                table: "Worksheets",
                column: "IdWorksheetCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Worksheets_WorksheetCategory_IdWorksheetCategory",
                table: "Worksheets",
                column: "IdWorksheetCategory",
                principalTable: "WorksheetCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
