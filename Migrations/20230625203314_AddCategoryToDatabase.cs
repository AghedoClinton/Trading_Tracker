using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBookWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDataTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Index = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Float = table.Column<int>(type: "int", nullable: false),
                    DailyVolume = table.Column<int>(type: "int", nullable: false),
                    PrevClose = table.Column<double>(type: "float", nullable: false),
                    Open = table.Column<double>(type: "float", nullable: false),
                    HighOfDay = table.Column<double>(type: "float", nullable: false),
                    LowOfDay = table.Column<double>(type: "float", nullable: false),
                    Close = table.Column<double>(type: "float", nullable: false),
                    FromOpen10High = table.Column<double>(type: "float", nullable: false),
                    FromOpen30High = table.Column<double>(type: "float", nullable: false),
                    MorningLow = table.Column<double>(type: "float", nullable: false),
                    First2HrsHigh = table.Column<double>(type: "float", nullable: false),
                    MarketCap = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Day2Open = table.Column<double>(type: "float", nullable: false),
                    Day2Close = table.Column<double>(type: "float", nullable: false),
                    Day2Volume = table.Column<double>(type: "float", nullable: false),
                    PrecDay2Open = table.Column<double>(type: "float", nullable: false),
                    PrecHighOfDay = table.Column<double>(type: "float", nullable: false),
                    PrecLowOfDay = table.Column<double>(type: "float", nullable: false),
                    PrecCloseFromOpen = table.Column<double>(type: "float", nullable: false),
                    PrecFromOpen30High = table.Column<double>(type: "float", nullable: false),
                    PrecCompleteRange = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
