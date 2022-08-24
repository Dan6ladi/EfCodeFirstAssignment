using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCodeFirst.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesAssociate",
                columns: table => new
                {
                    SalesAssociateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesAssociateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesAssociate", x => x.SalesAssociateId);
                });

            migrationBuilder.CreateTable(
                name: "Subsidiary",
                columns: table => new
                {
                    SubsidiaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubsidiaryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesAssociateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subsidiary", x => x.SubsidiaryId);
                    table.ForeignKey(
                        name: "FK_Subsidiary_SalesAssociate_SalesAssociateId",
                        column: x => x.SalesAssociateId,
                        principalTable: "SalesAssociate",
                        principalColumn: "SalesAssociateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subsidiary_SalesAssociateId",
                table: "Subsidiary",
                column: "SalesAssociateId");
        }
         
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subsidiary");

            migrationBuilder.DropTable(
                name: "SalesAssociate");
        }
    }
}
