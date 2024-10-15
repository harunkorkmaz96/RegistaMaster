using System;
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
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 1, 59, 673, DateTimeKind.Local).AddTicks(6146), new DateTime(2024, 10, 15, 16, 1, 59, 673, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Email", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 1, 59, 673, DateTimeKind.Local).AddTicks(6042), "Admin@Admin.com", new DateTime(2024, 10, 15, 16, 1, 59, 673, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 1, 59, 673, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 10, 15, 16, 1, 59, 673, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 1, 59, 673, DateTimeKind.Local).AddTicks(6079), new DateTime(2024, 10, 15, 16, 1, 59, 673, DateTimeKind.Local).AddTicks(6080) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 7, 6, 14, 5, 44, 71, DateTimeKind.Local).AddTicks(730), new DateTime(2024, 7, 6, 14, 5, 44, 71, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Email", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 7, 6, 14, 5, 44, 71, DateTimeKind.Local).AddTicks(606), "admin@admin.com", new DateTime(2024, 7, 6, 14, 5, 44, 71, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 7, 6, 14, 5, 44, 71, DateTimeKind.Local).AddTicks(645), new DateTime(2024, 7, 6, 14, 5, 44, 71, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2024, 7, 6, 14, 5, 44, 71, DateTimeKind.Local).AddTicks(651), new DateTime(2024, 7, 6, 14, 5, 44, 71, DateTimeKind.Local).AddTicks(652) });
        }
    }
}
