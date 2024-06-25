using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistaMaster.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class init_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "Versions",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "Users",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "UserLogs",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "Requests",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "RequestFiles",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "Projects",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "ProjectNotes",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "Modules",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "HealthChecks",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "FoodCharts",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "ErrorLogs",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "Customers",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "Actions",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifedBy",
                table: "ActionNotes",
                newName: "LastModifiedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Versions",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Users",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "UserLogs",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Requests",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "RequestFiles",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Projects",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "ProjectNotes",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Modules",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "HealthChecks",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "FoodCharts",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "ErrorLogs",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Customers",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Actions",
                newName: "LastModifedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "ActionNotes",
                newName: "LastModifedBy");
        }
    }
}
