using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolProject.Web.Migrations
{
    public partial class RemodelledWithControllers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
