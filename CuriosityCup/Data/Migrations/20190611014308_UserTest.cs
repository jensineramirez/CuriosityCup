using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CuriosityCup.Data.Migrations
{
    public partial class UserTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_testAnswers_Tests_TestId",
                table: "testAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_testAnswers_TestQuestions_TestQuestionId",
                table: "testAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_testAnswers",
                table: "testAnswers");

            migrationBuilder.RenameTable(
                name: "testAnswers",
                newName: "TestAnswers");

            migrationBuilder.RenameIndex(
                name: "IX_testAnswers_TestQuestionId",
                table: "TestAnswers",
                newName: "IX_TestAnswers_TestQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_testAnswers_TestId",
                table: "TestAnswers",
                newName: "IX_TestAnswers_TestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestAnswers",
                table: "TestAnswers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    TestId = table.Column<int>(nullable: false),
                    DateTaken = table.Column<DateTime>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    PassFail = table.Column<bool>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTests_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTests_UserProfiles_UserId1",
                        column: x => x.UserId1,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTests_TestId",
                table: "UserTests",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTests_UserId1",
                table: "UserTests",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TestAnswers_Tests_TestId",
                table: "TestAnswers",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestAnswers_TestQuestions_TestQuestionId",
                table: "TestAnswers",
                column: "TestQuestionId",
                principalTable: "TestQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestAnswers_Tests_TestId",
                table: "TestAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_TestAnswers_TestQuestions_TestQuestionId",
                table: "TestAnswers");

            migrationBuilder.DropTable(
                name: "UserTests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestAnswers",
                table: "TestAnswers");

            migrationBuilder.RenameTable(
                name: "TestAnswers",
                newName: "testAnswers");

            migrationBuilder.RenameIndex(
                name: "IX_TestAnswers_TestQuestionId",
                table: "testAnswers",
                newName: "IX_testAnswers_TestQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_TestAnswers_TestId",
                table: "testAnswers",
                newName: "IX_testAnswers_TestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_testAnswers",
                table: "testAnswers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_testAnswers_Tests_TestId",
                table: "testAnswers",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_testAnswers_TestQuestions_TestQuestionId",
                table: "testAnswers",
                column: "TestQuestionId",
                principalTable: "TestQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
