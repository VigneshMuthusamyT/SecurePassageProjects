using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurePassageProjects.Migrations
{
    /// <inheritdoc />
    public partial class allDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bankingModels",
                columns: table => new
                {
                    bankId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bankname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankPhonenumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPIPin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankSignupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bankingModels", x => x.bankId);
                });

            migrationBuilder.CreateTable(
                name: "facebookModels",
                columns: table => new
                {
                    FacebookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccounttypeFb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FBuserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FBPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FSignupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facebookModels", x => x.FacebookId);
                });

            migrationBuilder.CreateTable(
                name: "googleModels",
                columns: table => new
                {
                    GoogleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accounttypego = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoogleuserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GooglePassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GSignupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_googleModels", x => x.GoogleId);
                });

            migrationBuilder.CreateTable(
                name: "instgramModels",
                columns: table => new
                {
                    InstaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccounttypeIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    INuserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    INPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    INSignupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instgramModels", x => x.InstaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bankingModels");

            migrationBuilder.DropTable(
                name: "facebookModels");

            migrationBuilder.DropTable(
                name: "googleModels");

            migrationBuilder.DropTable(
                name: "instgramModels");
        }
    }
}
