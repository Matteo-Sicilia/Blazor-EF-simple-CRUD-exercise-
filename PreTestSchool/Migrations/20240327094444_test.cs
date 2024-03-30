using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreTestSchool.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.EnsureSchema(
                name: "schooltest");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "teachers",
                newSchema: "schooltest");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "schooltest",
                table: "teachers",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teachers",
                schema: "schooltest",
                table: "teachers",
                column: "teacher_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_teachers",
                schema: "schooltest",
                table: "teachers");

            migrationBuilder.RenameTable(
                name: "teachers",
                schema: "schooltest",
                newName: "Teachers");

            migrationBuilder.AlterColumn<int>(
                name: "name",
                table: "Teachers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "teacher_id");
        }
    }
}
