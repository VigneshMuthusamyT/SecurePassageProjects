using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurePassageProjects.Migrations
{
    /// <inheritdoc />
    public partial class allConnectionrelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "INSignupId",
                table: "instgramModels");

            migrationBuilder.DropColumn(
                name: "GSignupId",
                table: "googleModels");

            migrationBuilder.DropColumn(
                name: "FSignupId",
                table: "facebookModels");

            migrationBuilder.DropColumn(
                name: "BankSignupId",
                table: "bankingModels");

            migrationBuilder.AddColumn<int>(
                name: "signupModelsignupId",
                table: "instgramModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "signupModelsignupId",
                table: "googleModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "signupModelsignupId",
                table: "facebookModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "signupModelsignupId",
                table: "bankingModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_instgramModels_signupModelsignupId",
                table: "instgramModels",
                column: "signupModelsignupId");

            migrationBuilder.CreateIndex(
                name: "IX_googleModels_signupModelsignupId",
                table: "googleModels",
                column: "signupModelsignupId");

            migrationBuilder.CreateIndex(
                name: "IX_facebookModels_signupModelsignupId",
                table: "facebookModels",
                column: "signupModelsignupId");

            migrationBuilder.CreateIndex(
                name: "IX_bankingModels_signupModelsignupId",
                table: "bankingModels",
                column: "signupModelsignupId");

            migrationBuilder.AddForeignKey(
                name: "FK_bankingModels_signupModels_signupModelsignupId",
                table: "bankingModels",
                column: "signupModelsignupId",
                principalTable: "signupModels",
                principalColumn: "signupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_facebookModels_signupModels_signupModelsignupId",
                table: "facebookModels",
                column: "signupModelsignupId",
                principalTable: "signupModels",
                principalColumn: "signupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_googleModels_signupModels_signupModelsignupId",
                table: "googleModels",
                column: "signupModelsignupId",
                principalTable: "signupModels",
                principalColumn: "signupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_instgramModels_signupModels_signupModelsignupId",
                table: "instgramModels",
                column: "signupModelsignupId",
                principalTable: "signupModels",
                principalColumn: "signupId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bankingModels_signupModels_signupModelsignupId",
                table: "bankingModels");

            migrationBuilder.DropForeignKey(
                name: "FK_facebookModels_signupModels_signupModelsignupId",
                table: "facebookModels");

            migrationBuilder.DropForeignKey(
                name: "FK_googleModels_signupModels_signupModelsignupId",
                table: "googleModels");

            migrationBuilder.DropForeignKey(
                name: "FK_instgramModels_signupModels_signupModelsignupId",
                table: "instgramModels");

            migrationBuilder.DropIndex(
                name: "IX_instgramModels_signupModelsignupId",
                table: "instgramModels");

            migrationBuilder.DropIndex(
                name: "IX_googleModels_signupModelsignupId",
                table: "googleModels");

            migrationBuilder.DropIndex(
                name: "IX_facebookModels_signupModelsignupId",
                table: "facebookModels");

            migrationBuilder.DropIndex(
                name: "IX_bankingModels_signupModelsignupId",
                table: "bankingModels");

            migrationBuilder.DropColumn(
                name: "signupModelsignupId",
                table: "instgramModels");

            migrationBuilder.DropColumn(
                name: "signupModelsignupId",
                table: "googleModels");

            migrationBuilder.DropColumn(
                name: "signupModelsignupId",
                table: "facebookModels");

            migrationBuilder.DropColumn(
                name: "signupModelsignupId",
                table: "bankingModels");

            migrationBuilder.AddColumn<int>(
                name: "INSignupId",
                table: "instgramModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GSignupId",
                table: "googleModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FSignupId",
                table: "facebookModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BankSignupId",
                table: "bankingModels",
                type: "int",
                nullable: true);
        }
    }
}
