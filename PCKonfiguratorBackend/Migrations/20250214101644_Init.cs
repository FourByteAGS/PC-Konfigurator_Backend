using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCKonfiguratorBackend.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CpuFanSpecifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    socket = table.Column<int>(type: "int", nullable: true),
                    connector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    heatpipes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CpuFanSpecifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CPUMemory",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    memoryType = table.Column<int>(type: "int", nullable: true),
                    maxCapacity = table.Column<int>(type: "int", nullable: true),
                    maxSpeed = table.Column<float>(type: "real", nullable: true)
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
                    width = table.Column<float>(type: "real", nullable: true),
                    height = table.Column<float>(type: "real", nullable: true),
                    depth = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FanSpecifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    rpm = table.Column<int>(type: "int", nullable: true),
                    power = table.Column<int>(type: "int", nullable: true),
                    noiseLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    besonderheit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FanSpecifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GPUSpecifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    memory = table.Column<int>(type: "int", nullable: true),
                    speed = table.Column<float>(type: "real", nullable: true),
                    boostclock = table.Column<int>(type: "int", nullable: true),
                    coreclock = table.Column<int>(type: "int", nullable: true),
                    power = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUSpecifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MainboardSpecifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    socket = table.Column<int>(type: "int", nullable: true),
                    chipset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    m2Slot = table.Column<int>(type: "int", nullable: true),
                    sataPorts = table.Column<int>(type: "int", nullable: true),
                    formFactor = table.Column<int>(type: "int", nullable: true),
                    memoryType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainboardSpecifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PSUSpecification",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    rpm = table.Column<int>(type: "int", nullable: true),
                    power = table.Column<int>(type: "int", nullable: true),
                    noiseLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    certifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    connectors = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSUSpecification", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RAMSpecifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemoryType = table.Column<int>(type: "int", nullable: true),
                    speed = table.Column<int>(type: "int", nullable: true),
                    capacity = table.Column<int>(type: "int", nullable: true),
                    voltage = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMSpecifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "StorageSpecifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: true),
                    schnittstelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    readSpeeed = table.Column<int>(type: "int", nullable: true),
                    writeSpeeed = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageSpecifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TowerCompatibility",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    maxCpuCoolerHeight = table.Column<float>(type: "real", nullable: true),
                    maxGpuLenght = table.Column<float>(type: "real", nullable: true)
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
                    l2Cache = table.Column<int>(type: "int", nullable: true),
                    l3Cache = table.Column<int>(type: "int", nullable: true),
                    maxTemp = table.Column<int>(type: "int", nullable: true),
                    threads = table.Column<int>(type: "int", nullable: true),
                    core = table.Column<int>(type: "int", nullable: true),
                    baseClock = table.Column<double>(type: "float", nullable: true),
                    boostClock = table.Column<double>(type: "float", nullable: true),
                    socket = table.Column<int>(type: "int", nullable: true),
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
                name: "CPUFans",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpufanSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUFans", x => x.id);
                    table.ForeignKey(
                        name: "FK_CPUFans_CpuFanSpecifications_cpufanSpecificationsid",
                        column: x => x.cpufanSpecificationsid,
                        principalTable: "CpuFanSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUFans_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fans",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fanSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fans", x => x.id);
                    table.ForeignKey(
                        name: "FK_Fans_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fans_FanSpecifications_fanSpecificationsid",
                        column: x => x.fanSpecificationsid,
                        principalTable: "FanSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GPUs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gpuSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUs", x => x.id);
                    table.ForeignKey(
                        name: "FK_GPUs_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPUs_GPUSpecifications_gpuSpecificationsid",
                        column: x => x.gpuSpecificationsid,
                        principalTable: "GPUSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mainboards",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mainboardSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mainboards", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mainboards_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mainboards_MainboardSpecifications_mainboardSpecificationsid",
                        column: x => x.mainboardSpecificationsid,
                        principalTable: "MainboardSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSUs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    psuSpecificationid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSUs", x => x.id);
                    table.ForeignKey(
                        name: "FK_PSUs_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PSUs_PSUSpecification_psuSpecificationid",
                        column: x => x.psuSpecificationid,
                        principalTable: "PSUSpecification",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ramSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.id);
                    table.ForeignKey(
                        name: "FK_RAMs_RAMSpecifications_ramSpecificationsid",
                        column: x => x.ramSpecificationsid,
                        principalTable: "RAMSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    storageSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.id);
                    table.ForeignKey(
                        name: "FK_Storages_StorageSpecifications_storageSpecificationsid",
                        column: x => x.storageSpecificationsid,
                        principalTable: "StorageSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Towers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    towerType = table.Column<int>(type: "int", nullable: true),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    towerCompatibilityid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Towers_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Towers_TowerCompatibility_towerCompatibilityid",
                        column: x => x.towerCompatibilityid,
                        principalTable: "TowerCompatibility",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpuSpecificationid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cpus_CPUSpecification_cpuSpecificationid",
                        column: x => x.cpuSpecificationid,
                        principalTable: "CPUSpecification",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CPUFans_cpufanSpecificationsid",
                table: "CPUFans",
                column: "cpufanSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_CPUFans_dimensionsid",
                table: "CPUFans",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_Cpus_cpuSpecificationid",
                table: "Cpus",
                column: "cpuSpecificationid");

            migrationBuilder.CreateIndex(
                name: "IX_CPUSpecification_cpuMemoryid",
                table: "CPUSpecification",
                column: "cpuMemoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Fans_dimensionsid",
                table: "Fans",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_Fans_fanSpecificationsid",
                table: "Fans",
                column: "fanSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_GPUs_dimensionsid",
                table: "GPUs",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_GPUs_gpuSpecificationsid",
                table: "GPUs",
                column: "gpuSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_Mainboards_dimensionsid",
                table: "Mainboards",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_Mainboards_mainboardSpecificationsid",
                table: "Mainboards",
                column: "mainboardSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_PSUs_dimensionsid",
                table: "PSUs",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_PSUs_psuSpecificationid",
                table: "PSUs",
                column: "psuSpecificationid");

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_ramSpecificationsid",
                table: "RAMs",
                column: "ramSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_storageSpecificationsid",
                table: "Storages",
                column: "storageSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_Towers_dimensionsid",
                table: "Towers",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_Towers_towerCompatibilityid",
                table: "Towers",
                column: "towerCompatibilityid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPUFans");

            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropTable(
                name: "Fans");

            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "Mainboards");

            migrationBuilder.DropTable(
                name: "PSUs");

            migrationBuilder.DropTable(
                name: "RAMs");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Towers");

            migrationBuilder.DropTable(
                name: "CpuFanSpecifications");

            migrationBuilder.DropTable(
                name: "CPUSpecification");

            migrationBuilder.DropTable(
                name: "FanSpecifications");

            migrationBuilder.DropTable(
                name: "GPUSpecifications");

            migrationBuilder.DropTable(
                name: "MainboardSpecifications");

            migrationBuilder.DropTable(
                name: "PSUSpecification");

            migrationBuilder.DropTable(
                name: "RAMSpecifications");

            migrationBuilder.DropTable(
                name: "StorageSpecifications");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "TowerCompatibility");

            migrationBuilder.DropTable(
                name: "CPUMemory");
        }
    }
}
