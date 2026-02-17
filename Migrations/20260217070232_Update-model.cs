using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS_Web_App_Version.Migrations
{
    /// <inheritdoc />
    public partial class Updatemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cource",
                table: "students",
                newName: "Course");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Course",
                table: "students",
                newName: "cource");
        }
    }
}
