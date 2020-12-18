using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolProject.Web.Migrations
{
    public partial class ModelMoficationAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_StudentID",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Courses",
                newName: "CoursesID");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_StudentID",
                table: "Courses",
                newName: "IX_Courses_CoursesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_CoursesID",
                table: "Courses",
                column: "CoursesID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_CoursesID",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "CoursesID",
                table: "Courses",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_CoursesID",
                table: "Courses",
                newName: "IX_Courses_StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_StudentID",
                table: "Courses",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
