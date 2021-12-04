using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transfer.Data.Migrations
{
    public partial class RenameTransferLogtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransferLogs",
                table: "TransferLogs");

            migrationBuilder.RenameTable(
                name: "TransferLogs",
                newName: "TransferLog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransferLog",
                table: "TransferLog",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransferLog",
                table: "TransferLog");

            migrationBuilder.RenameTable(
                name: "TransferLog",
                newName: "TransferLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransferLogs",
                table: "TransferLogs",
                column: "Id");
        }
    }
}
