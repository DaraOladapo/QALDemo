using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolProject.Web.Migrations
{
    public partial class ModelMoficationAgainAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_CoursesID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CoursesID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CoursesID",
                table: "Courses");

            migrationBuilder.CreateTable(
                name: "CourseRegistration",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRegistration", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CourseRegistration_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseRegistration_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRegistration_CourseID",
                table: "CourseRegistration",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRegistration_StudentID",
                table: "CourseRegistration",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseRegistration");

            migrationBuilder.AddColumn<int>(
                name: "CoursesID",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CoursesID",
                table: "Courses",
                column: "CoursesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_CoursesID",
                table: "Courses",
                column: "CoursesID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
