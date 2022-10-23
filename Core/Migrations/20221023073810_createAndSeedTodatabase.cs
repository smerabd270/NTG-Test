using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class createAndSeedTodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LasttName = table.Column<string>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoursesTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursesTeachers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesTeachers_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    CourseTeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_CoursesTeachers_CourseTeacherId",
                        column: x => x.CourseTeacherId,
                        principalTable: "CoursesTeachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedDate", "EndDate", "Name", "StartDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 23, 10, 38, 10, 648, DateTimeKind.Local).AddTicks(1349), new DateTime(2023, 1, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6363), "English", new DateTime(2022, 7, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6109), null },
                    { 2, new DateTime(2022, 10, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 1, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6584), "French", new DateTime(2022, 7, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6576), null },
                    { 3, new DateTime(2022, 10, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6591), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1988), "Business Administration", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2019), null },
                    { 4, new DateTime(2022, 10, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6608), new DateTime(2023, 1, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6614), "ICDL", new DateTime(2022, 7, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6611), null },
                    { 5, new DateTime(2022, 10, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6616), new DateTime(2023, 1, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6621), "Communication skills", new DateTime(2022, 7, 23, 10, 38, 10, 649, DateTimeKind.Local).AddTicks(6619), null }
                });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "Id", "CreatedDate", "MobileNumber", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 23, 10, 38, 10, 650, DateTimeKind.Local).AddTicks(6327), "0932222789", "Gary Cabrera", null },
                    { 2, new DateTime(2022, 10, 23, 10, 38, 10, 650, DateTimeKind.Local).AddTicks(6902), "0932222789", "Stacy Logan", null },
                    { 3, new DateTime(2022, 10, 23, 10, 38, 10, 650, DateTimeKind.Local).AddTicks(6932), "0965123456", "Priscilla Phelps", null },
                    { 4, new DateTime(2022, 10, 23, 10, 38, 10, 650, DateTimeKind.Local).AddTicks(6936), "0965123456", "Aliza Vance", null },
                    { 5, new DateTime(2022, 10, 23, 10, 38, 10, 650, DateTimeKind.Local).AddTicks(6938), "096514577", "Averie Carter", null },
                    { 6, new DateTime(2022, 10, 23, 10, 38, 10, 650, DateTimeKind.Local).AddTicks(6941), "0988123577", "Savannah Brooks", null },
                    { 7, new DateTime(2022, 10, 23, 10, 38, 10, 650, DateTimeKind.Local).AddTicks(6943), "09651234577", "Belen Fox", null },
                    { 8, new DateTime(2022, 10, 23, 10, 38, 10, 650, DateTimeKind.Local).AddTicks(6946), "09671234577", "Yadira Mcintyre", null },
                    { 9, new DateTime(2022, 10, 23, 10, 38, 10, 650, DateTimeKind.Local).AddTicks(6949), "09631234577", "Grayson Stout", null }
                });

            migrationBuilder.InsertData(
                table: "CoursesTeachers",
                columns: new[] { "Id", "CourseId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 5, 2, 3 },
                    { 4, 2, 4 },
                    { 6, 3, 5 },
                    { 7, 4, 6 },
                    { 8, 4, 7 },
                    { 10, 5, 7 },
                    { 9, 5, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursesTeachers_CourseId",
                table: "CoursesTeachers",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesTeachers_TeacherId",
                table: "CoursesTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_CourseTeacherId",
                table: "StudentsCourses",
                column: "CourseTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_StudentId",
                table: "StudentsCourses",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsCourses");

            migrationBuilder.DropTable(
                name: "CoursesTeachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "teachers");
        }
    }
}
