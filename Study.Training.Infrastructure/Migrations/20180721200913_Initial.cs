using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Study.Training.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "StudyTraining");

            migrationBuilder.CreateTable(
                name: "Subject",
                schema: "StudyTraining",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SubjectId", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                schema: "StudyTraining",
                columns: table => new
                {
                    QuestionId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    SubjectId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("QuestionId", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Question_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "StudyTraining",
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                schema: "StudyTraining",
                columns: table => new
                {
                    AnswerId = table.Column<Guid>(nullable: false),
                    Text = table.Column<string>(maxLength: 200, nullable: false),
                    IsCorrect = table.Column<bool>(nullable: false),
                    QuestionId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("AnswerId", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answer_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalSchema: "StudyTraining",
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                schema: "StudyTraining",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_SubjectId",
                schema: "StudyTraining",
                table: "Question",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer",
                schema: "StudyTraining");

            migrationBuilder.DropTable(
                name: "Question",
                schema: "StudyTraining");

            migrationBuilder.DropTable(
                name: "Subject",
                schema: "StudyTraining");
        }
    }
}
