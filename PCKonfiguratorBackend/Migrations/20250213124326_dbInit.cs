using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCKonfiguratorBackend.Migrations
{
    /// <inheritdoc />
    public partial class dbInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CpuFanSpecifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    socket = table.Column<int>(type: "int", nullable: false),
                    connector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    heatpipes = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    memoryType = table.Column<int>(type: "int", nullable: false),
                    maxCapacity = table.Column<int>(type: "int", nullable: false),
                    maxSpeed = table.Column<float>(type: "real", nullable: false)
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
                    width = table.Column<float>(type: "real", nullable: false),
                    height = table.Column<float>(type: "real", nullable: false),
                    depth = table.Column<float>(type: "real", nullable: false)
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
                    rpm = table.Column<int>(type: "int", nullable: false),
                    power = table.Column<int>(type: "int", nullable: false),
                    noiseLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    besonderheit = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    memory = table.Column<int>(type: "int", nullable: false),
                    speed = table.Column<float>(type: "real", nullable: false),
                    boostclock = table.Column<int>(type: "int", nullable: false),
                    coreclock = table.Column<int>(type: "int", nullable: false),
                    power = table.Column<int>(type: "int", nullable: false)
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
                    socket = table.Column<int>(type: "int", nullable: false),
                    chipset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    m2Slot = table.Column<int>(type: "int", nullable: false),
                    sataPorts = table.Column<int>(type: "int", nullable: false),
                    formFactor = table.Column<int>(type: "int", nullable: false),
                    memoryType = table.Column<int>(type: "int", nullable: false)
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
                    rpm = table.Column<int>(type: "int", nullable: false),
                    power = table.Column<int>(type: "int", nullable: false),
                    noiseLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    certifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    connectors = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    MemoryType = table.Column<int>(type: "int", nullable: false),
                    speed = table.Column<int>(type: "int", nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    voltage = table.Column<float>(type: "real", nullable: false)
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
                    capacity = table.Column<int>(type: "int", nullable: false),
                    schnittstelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    readSpeeed = table.Column<int>(type: "int", nullable: false),
                    writeSpeeed = table.Column<int>(type: "int", nullable: false)
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
                    maxCpuCoolerHeight = table.Column<float>(type: "real", nullable: false),
                    maxGpuLenght = table.Column<float>(type: "real", nullable: false)
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
                name: "CPUFan",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpufanSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUFan", x => x.id);
                    table.ForeignKey(
                        name: "FK_CPUFan_CpuFanSpecifications_cpufanSpecificationsid",
                        column: x => x.cpufanSpecificationsid,
                        principalTable: "CpuFanSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUFan_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fan",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fanSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fan", x => x.id);
                    table.ForeignKey(
                        name: "FK_Fan_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fan_FanSpecifications_fanSpecificationsid",
                        column: x => x.fanSpecificationsid,
                        principalTable: "FanSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GPU",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gpuSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPU", x => x.id);
                    table.ForeignKey(
                        name: "FK_GPU_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPU_GPUSpecifications_gpuSpecificationsid",
                        column: x => x.gpuSpecificationsid,
                        principalTable: "GPUSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mainboard",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mainboardSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mainboard", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mainboard_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mainboard_MainboardSpecifications_mainboardSpecificationsid",
                        column: x => x.mainboardSpecificationsid,
                        principalTable: "MainboardSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSU",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    psuSpecificationid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dimensionsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSU", x => x.id);
                    table.ForeignKey(
                        name: "FK_PSU_Dimensions_dimensionsid",
                        column: x => x.dimensionsid,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PSU_PSUSpecification_psuSpecificationid",
                        column: x => x.psuSpecificationid,
                        principalTable: "PSUSpecification",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RAM",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ramSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAM", x => x.id);
                    table.ForeignKey(
                        name: "FK_RAM_RAMSpecifications_ramSpecificationsid",
                        column: x => x.ramSpecificationsid,
                        principalTable: "RAMSpecifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    storageSpecificationsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.id);
                    table.ForeignKey(
                        name: "FK_Storage_StorageSpecifications_storageSpecificationsid",
                        column: x => x.storageSpecificationsid,
                        principalTable: "StorageSpecifications",
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
                    price = table.Column<float>(type: "real", nullable: false),
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
                    price = table.Column<float>(type: "real", nullable: false),
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
                    selectedTowerid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    selectedCPUFanid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    selectedMainboardid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    selectedRAMid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    selectedFanid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    selectedStorageid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    selectedPSUid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    selectedGPUid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCollection", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductCollection_CPUFan_selectedCPUFanid",
                        column: x => x.selectedCPUFanid,
                        principalTable: "CPUFan",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ProductCollection_CPU_selectedCPUid",
                        column: x => x.selectedCPUid,
                        principalTable: "CPU",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ProductCollection_Fan_selectedFanid",
                        column: x => x.selectedFanid,
                        principalTable: "Fan",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ProductCollection_GPU_selectedGPUid",
                        column: x => x.selectedGPUid,
                        principalTable: "GPU",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ProductCollection_Mainboard_selectedMainboardid",
                        column: x => x.selectedMainboardid,
                        principalTable: "Mainboard",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ProductCollection_PSU_selectedPSUid",
                        column: x => x.selectedPSUid,
                        principalTable: "PSU",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ProductCollection_RAM_selectedRAMid",
                        column: x => x.selectedRAMid,
                        principalTable: "RAM",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ProductCollection_Storage_selectedStorageid",
                        column: x => x.selectedStorageid,
                        principalTable: "Storage",
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
                name: "IX_CPUFan_cpufanSpecificationsid",
                table: "CPUFan",
                column: "cpufanSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_CPUFan_dimensionsid",
                table: "CPUFan",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_CPUSpecification_cpuMemoryid",
                table: "CPUSpecification",
                column: "cpuMemoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Fan_dimensionsid",
                table: "Fan",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_Fan_fanSpecificationsid",
                table: "Fan",
                column: "fanSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_dimensionsid",
                table: "GPU",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_gpuSpecificationsid",
                table: "GPU",
                column: "gpuSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_Mainboard_dimensionsid",
                table: "Mainboard",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_Mainboard_mainboardSpecificationsid",
                table: "Mainboard",
                column: "mainboardSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedCPUFanid",
                table: "ProductCollection",
                column: "selectedCPUFanid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedCPUid",
                table: "ProductCollection",
                column: "selectedCPUid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedFanid",
                table: "ProductCollection",
                column: "selectedFanid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedGPUid",
                table: "ProductCollection",
                column: "selectedGPUid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedMainboardid",
                table: "ProductCollection",
                column: "selectedMainboardid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedPSUid",
                table: "ProductCollection",
                column: "selectedPSUid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedRAMid",
                table: "ProductCollection",
                column: "selectedRAMid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedStorageid",
                table: "ProductCollection",
                column: "selectedStorageid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedTowerid",
                table: "ProductCollection",
                column: "selectedTowerid");

            migrationBuilder.CreateIndex(
                name: "IX_PSU_dimensionsid",
                table: "PSU",
                column: "dimensionsid");

            migrationBuilder.CreateIndex(
                name: "IX_PSU_psuSpecificationid",
                table: "PSU",
                column: "psuSpecificationid");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_ramSpecificationsid",
                table: "RAM",
                column: "ramSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_storageSpecificationsid",
                table: "Storage",
                column: "storageSpecificationsid");

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
                name: "CPUFan");

            migrationBuilder.DropTable(
                name: "CPU");

            migrationBuilder.DropTable(
                name: "Fan");

            migrationBuilder.DropTable(
                name: "GPU");

            migrationBuilder.DropTable(
                name: "Mainboard");

            migrationBuilder.DropTable(
                name: "PSU");

            migrationBuilder.DropTable(
                name: "RAM");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Tower");

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
