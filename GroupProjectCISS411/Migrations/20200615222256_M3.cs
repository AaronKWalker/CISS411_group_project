using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupProjectCISS411.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SessionTitle",
                table: "Sessions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LessonTitle",
                table: "Lessons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionTitle",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "LessonTitle",
                table: "Lessons");
        }
    }
}
