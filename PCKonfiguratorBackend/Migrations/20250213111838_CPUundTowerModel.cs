using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCKonfiguratorBackend.Migrations
{
    /// <inheritdoc />
    public partial class CPUundTowerModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CPUMemory",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    memoryType = table.Column<int>(type: "int", nullable: false),
                    maxCapacity = table.Column<int>(type: "int", nullable: false),
                    maxSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUMemory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    depth = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TowerCompatibility",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    maxCpuCoolerHeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    maxGpuLenght = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowerCompatibility", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CPUSpecification",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    l2Cache = table.Column<int>(type: "int", nullable: false),
                    l3Cache = table.Column<int>(type: "int", nullable: false),
                    maxTemp = table.Column<int>(type: "int", nullable: false),
                    threads = table.Column<int>(type: "int", nullable: false),
                    core = table.Column<int>(type: "int", nullable: false),
                    baseClock = table.Column<double>(type: "float", nullable: false),
                    boostClock = table.Column<double>(type: "float", nullable: false),
                    socket = table.Column<int>(type: "int", nullable: false),
                    cpuMemoryid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUSpecification", x => x.id);
                    table.ForeignKey(
                        name: "FK_CPUSpecification_CPUMemory_cpuMemoryid",
                        column: x => x.cpuMemoryid,
                        principalTable: "CPUMemory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tower",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    towerType = table.Column<int>(type: "int", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    towerCompatibilityid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tower", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tower_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tower_TowerCompatibility_towerCompatibilityid",
                        column: x => x.towerCompatibilityid,
                        principalTable: "TowerCompatibility",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CPU",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpuSpecificationid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPU", x => x.id);
                    table.ForeignKey(
                        name: "FK_CPU_CPUSpecification_cpuSpecificationid",
                        column: x => x.cpuSpecificationid,
                        principalTable: "CPUSpecification",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCollection",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    token = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    selectedCPUid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    selectedTowerid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCollection", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductCollection_CPU_selectedCPUid",
                        column: x => x.selectedCPUid,
                        principalTable: "CPU",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ProductCollection_Tower_selectedTowerid",
                        column: x => x.selectedTowerid,
                        principalTable: "Tower",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CPU_cpuSpecificationid",
                table: "CPU",
                column: "cpuSpecificationid");

            migrationBuilder.CreateIndex(
                name: "IX_CPUSpecification_cpuMemoryid",
                table: "CPUSpecification",
                column: "cpuMemoryid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedCPUid",
                table: "ProductCollection",
                column: "selectedCPUid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedTowerid",
                table: "ProductCollection",
                column: "selectedTowerid");

            migrationBuilder.CreateIndex(
                name: "IX_Tower_dimensionsid",
                table: "Tower",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_Tower_towerCompatibilityid",
                table: "Tower",
                column: "towerCompatibilityid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCollection");

            migrationBuilder.DropTable(
                name: "CPU");

            migrationBuilder.DropTable(
                name: "Tower");

            migrationBuilder.DropTable(
                name: "CPUSpecification");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "TowerCompatibility");

            migrationBuilder.DropTable(
                name: "CPUMemory");
        }
    }
}
