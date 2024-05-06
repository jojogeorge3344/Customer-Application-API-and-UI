using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerApplication.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pincode1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flag1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pincode2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flag2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
