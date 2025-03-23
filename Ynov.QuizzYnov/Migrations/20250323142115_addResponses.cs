using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ynov.QuizzYnov.Migrations
{
    /// <inheritdoc />
    public partial class addResponses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Response_Questions_QuestionId",
                table: "Response");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Response",
                table: "Response");

            migrationBuilder.RenameTable(
                name: "Response",
                newName: "Responses");

            migrationBuilder.RenameIndex(
                name: "IX_Response_QuestionId",
                table: "Responses",
                newName: "IX_Responses_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Responses",
                table: "Responses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Questions_QuestionId",
                table: "Responses",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Questions_QuestionId",
                table: "Responses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Responses",
                table: "Responses");

            migrationBuilder.RenameTable(
                name: "Responses",
                newName: "Response");

            migrationBuilder.RenameIndex(
                name: "IX_Responses_QuestionId",
                table: "Response",
                newName: "IX_Response_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Response",
                table: "Response",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Response_Questions_QuestionId",
                table: "Response",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
