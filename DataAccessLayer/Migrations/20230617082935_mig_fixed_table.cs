using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_fixed_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_AspNetUsers_AppUserID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_AppUserID",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Teachers");

            migrationBuilder.AlterColumn<decimal>(
                name: "CourseTotalTime",
                table: "Courses",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CourseDescription",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CourseImageUrl",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "CourseTotalPrice",
                table: "Courses",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "CourseTime",
                table: "CourseDetails",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CourseDescription",
                table: "CourseDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CourseImageUrl",
                table: "CourseDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "CoursePrice",
                table: "CourseDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseDescription",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseImageUrl",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseTotalPrice",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseDescription",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "CourseImageUrl",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "CoursePrice",
                table: "CourseDetails");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CourseTotalTime",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "CourseTime",
                table: "CourseDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_AppUserID",
                table: "Teachers",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_AspNetUsers_AppUserID",
                table: "Teachers",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
