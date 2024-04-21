using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpanishWebProj.Migrations
{
    public partial class forum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: 1L);

            //migrationBuilder.DeleteData(
            //    table: "Users",
            //    keyColumn: "Id",
            //    keyValue: 2L);

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "Users",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(long),
            //    oldType: "bigint")
            //    .Annotation("SqlServer:Identity", "1, 1")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AlterColumn<int>(
            //    name: "UserId",
            //    table: "Profiles",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(long),
            //    oldType: "bigint");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Age",
            //    table: "Profiles",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(byte),
            //    oldType: "tinyint");

            //migrationBuilder.AddColumn<string>(
            //    name: "Image",
            //    table: "Profiles",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "Id", "Name", "Password", "Role" },
            //    values: new object[] { 1, "Ana", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 });

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "Id", "Name", "Password", "Role" },
            //    values: new object[] { 2, "Aliona", "481f6cc0511143ccdd7e2d1b1b94faf0a700a8b49cd13922a70b5ae28acaa8c5", 1 });

            //migrationBuilder.UpdateData(
            //    table: "Profiles",
            //    keyColumn: "Id",
            //    keyValue: 1L,
            //    columns: new[] { "Age", "UserId" },
            //    values: new object[] { 0, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Profiles");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Users",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Profiles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Age",
                table: "Profiles",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "Role" },
                values: new object[] { 1L, "Ana", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "Role" },
                values: new object[] { 2L, "Aliona", "481f6cc0511143ccdd7e2d1b1b94faf0a700a8b49cd13922a70b5ae28acaa8c5", 1 });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Age", "UserId" },
                values: new object[] { (byte)0, 1L });
        }
    }
}
