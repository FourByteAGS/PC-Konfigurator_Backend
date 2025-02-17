using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCKonfiguratorBackend.Migrations
{
    /// <inheritdoc />
    public partial class PowerAndFormFactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "formFactor",
                table: "Towers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "power",
                table: "StorageSpecifications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "power",
                table: "RAMSpecifications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "power",
                table: "MainboardSpecifications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "power",
                table: "CPUSpecification",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "formFactor",
                table: "Towers");

            migrationBuilder.DropColumn(
                name: "power",
                table: "StorageSpecifications");

            migrationBuilder.DropColumn(
                name: "power",
                table: "RAMSpecifications");

            migrationBuilder.DropColumn(
                name: "power",
                table: "MainboardSpecifications");

            migrationBuilder.DropColumn(
                name: "power",
                table: "CPUSpecification");
        }
    }
}
