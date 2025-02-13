using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCKonfiguratorBackend.Migrations
{
    /// <inheritdoc />
    public partial class blaupause : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "selectedCPUFanid",
                table: "ProductCollection",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "selectedFanid",
                table: "ProductCollection",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "selectedGPUid",
                table: "ProductCollection",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "selectedMainboardid",
                table: "ProductCollection",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "selectedPSUid",
                table: "ProductCollection",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "selectedRAMid",
                table: "ProductCollection",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "selectedStorageid",
                table: "ProductCollection",
                type: "uniqueidentifier",
                nullable: true);

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
                    speed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    voltage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                name: "CPUFan",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_ProductCollection_selectedCPUFanid",
                table: "ProductCollection",
                column: "selectedCPUFanid");

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
                name: "IX_CPUFan_cpufanSpecificationsid",
                table: "CPUFan",
                column: "cpufanSpecificationsid");

            migrationBuilder.CreateIndex(
                name: "IX_CPUFan_dimensionsid",
                table: "CPUFan",
                column: "dimensionsid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCollection_CPUFan_selectedCPUFanid",
                table: "ProductCollection",
                column: "selectedCPUFanid",
                principalTable: "CPUFan",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCollection_Fan_selectedFanid",
                table: "ProductCollection",
                column: "selectedFanid",
                principalTable: "Fan",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCollection_GPU_selectedGPUid",
                table: "ProductCollection",
                column: "selectedGPUid",
                principalTable: "GPU",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCollection_Mainboard_selectedMainboardid",
                table: "ProductCollection",
                column: "selectedMainboardid",
                principalTable: "Mainboard",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCollection_PSU_selectedPSUid",
                table: "ProductCollection",
                column: "selectedPSUid",
                principalTable: "PSU",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCollection_RAM_selectedRAMid",
                table: "ProductCollection",
                column: "selectedRAMid",
                principalTable: "RAM",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCollection_Storage_selectedStorageid",
                table: "ProductCollection",
                column: "selectedStorageid",
                principalTable: "Storage",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCollection_CPUFan_selectedCPUFanid",
                table: "ProductCollection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCollection_Fan_selectedFanid",
                table: "ProductCollection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCollection_GPU_selectedGPUid",
                table: "ProductCollection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCollection_Mainboard_selectedMainboardid",
                table: "ProductCollection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCollection_PSU_selectedPSUid",
                table: "ProductCollection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCollection_RAM_selectedRAMid",
                table: "ProductCollection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCollection_Storage_selectedStorageid",
                table: "ProductCollection");

            migrationBuilder.DropTable(
                name: "CPUFan");

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
                name: "CpuFanSpecifications");

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

            migrationBuilder.DropIndex(
                name: "IX_ProductCollection_selectedCPUFanid",
                table: "ProductCollection");

            migrationBuilder.DropIndex(
                name: "IX_ProductCollection_selectedFanid",
                table: "ProductCollection");

            migrationBuilder.DropIndex(
                name: "IX_ProductCollection_selectedGPUid",
                table: "ProductCollection");

            migrationBuilder.DropIndex(
                name: "IX_ProductCollection_selectedMainboardid",
                table: "ProductCollection");

            migrationBuilder.DropIndex(
                name: "IX_ProductCollection_selectedPSUid",
                table: "ProductCollection");

            migrationBuilder.DropIndex(
                name: "IX_ProductCollection_selectedRAMid",
                table: "ProductCollection");

            migrationBuilder.DropIndex(
                name: "IX_ProductCollection_selectedStorageid",
                table: "ProductCollection");

            migrationBuilder.DropColumn(
                name: "selectedCPUFanid",
                table: "ProductCollection");

            migrationBuilder.DropColumn(
                name: "selectedFanid",
                table: "ProductCollection");

            migrationBuilder.DropColumn(
                name: "selectedGPUid",
                table: "ProductCollection");

            migrationBuilder.DropColumn(
                name: "selectedMainboardid",
                table: "ProductCollection");

            migrationBuilder.DropColumn(
                name: "selectedPSUid",
                table: "ProductCollection");

            migrationBuilder.DropColumn(
                name: "selectedRAMid",
                table: "ProductCollection");

            migrationBuilder.DropColumn(
                name: "selectedStorageid",
                table: "ProductCollection");
        }
    }
}
