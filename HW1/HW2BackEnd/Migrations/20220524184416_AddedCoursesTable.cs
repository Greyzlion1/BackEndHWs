using Microsoft.EntityFrameworkCore.Migrations;

namespace HW1.Migrations
{
    public partial class AddedCoursesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseImage = table.Column<string>(nullable: true),
                    CourseName = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    ContentName = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Users = table.Column<int>(nullable: false),
                    Userslike = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
