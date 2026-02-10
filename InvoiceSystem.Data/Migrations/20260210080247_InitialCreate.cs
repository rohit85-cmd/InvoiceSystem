using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItems", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
