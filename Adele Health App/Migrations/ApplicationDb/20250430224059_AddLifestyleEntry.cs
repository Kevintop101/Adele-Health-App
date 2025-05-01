using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adele_Health_App.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class AddLifestyleEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LifestyleEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Glucose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealTiming = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedGlucose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedExercise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedNutrition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedMedication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedHydration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedSleep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedStress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedTags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifestyleEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Glucose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealTiming = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogEntries", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LifestyleEntries");

            migrationBuilder.DropTable(
                name: "LogEntries");
        }
    }
}
