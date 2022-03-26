using Microsoft.EntityFrameworkCore.Migrations;

namespace Nav.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Cuisines = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    StartWorkAt = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EndWorkAt = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Lat = table.Column<decimal>(type: "decimal(8,6)", nullable: false),
                    Lng = table.Column<decimal>(type: "decimal(9,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreDetail_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreDetail_StoreId",
                table: "StoreDetail",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreDetail");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
