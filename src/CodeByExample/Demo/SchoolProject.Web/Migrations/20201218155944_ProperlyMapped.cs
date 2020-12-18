using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolProject.Web.Migrations
{
    public partial class ProperlyMapped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseRegistration_Courses_CourseID",
                table: "CourseRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRegistration_Students_StudentID",
                table: "CourseRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseRegistration",
                table: "CourseRegistration");

            migrationBuilder.RenameTable(
                name: "CourseRegistration",
                newName: "CourseRegistrations");

            migrationBuilder.RenameIndex(
                name: "IX_CourseRegistration_StudentID",
                table: "CourseRegistrations",
                newName: "IX_CourseRegistrations_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseRegistration_CourseID",
                table: "CourseRegistrations",
                newName: "IX_CourseRegistrations_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseRegistrations",
                table: "CourseRegistrations",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRegistrations_Courses_CourseID",
                table: "CourseRegistrations",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRegistrations_Students_StudentID",
                table: "CourseRegistrations",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseRegistrations_Courses_CourseID",
                table: "CourseRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRegistrations_Students_StudentID",
                table: "CourseRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseRegistrations",
                table: "CourseRegistrations");

            migrationBuilder.RenameTable(
                name: "CourseRegistrations",
                newName: "CourseRegistration");

            migrationBuilder.RenameIndex(
                name: "IX_CourseRegistrations_StudentID",
                table: "CourseRegistration",
                newName: "IX_CourseRegistration_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseRegistrations_CourseID",
                table: "CourseRegistration",
                newName: "IX_CourseRegistration_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseRegistration",
                table: "CourseRegistration",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRegistration_Courses_CourseID",
                table: "CourseRegistration",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRegistration_Students_StudentID",
                table: "CourseRegistration",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
