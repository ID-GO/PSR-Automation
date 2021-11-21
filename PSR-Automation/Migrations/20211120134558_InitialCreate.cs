using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSR_Automation.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllSubmissions",
                columns: table => new
                {
                    EvaluatioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SolutionName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ApplicationID = table.Column<string>(type: "TEXT", nullable: true),
                    ExecutiveSponsor = table.Column<string>(type: "TEXT", nullable: true),
                    Forum = table.Column<string>(type: "TEXT", nullable: false),
                    ForumDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BusinessDivision = table.Column<string>(type: "TEXT", nullable: true),
                    BusinessDivisionLevel2 = table.Column<string>(type: "TEXT", nullable: true),
                    DataSteward = table.Column<string>(type: "TEXT", nullable: true),
                    DataOperationsContact = table.Column<string>(type: "TEXT", nullable: false),
                    ReviewType = table.Column<string>(type: "TEXT", nullable: false),
                    RequestType = table.Column<string>(type: "TEXT", nullable: true),
                    ClarityCode = table.Column<string>(type: "TEXT", nullable: true),
                    DataContentSolution = table.Column<string>(type: "TEXT", nullable: false),
                    CriticalityQuestions = table.Column<string>(type: "TEXT", nullable: true),
                    PSRChecklistQuestions = table.Column<string>(type: "TEXT", nullable: true),
                    Comments = table.Column<string>(type: "TEXT", nullable: true),
                    SubmittedDate = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllSubmissions", x => x.EvaluatioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllSubmissions");
        }
    }
}
