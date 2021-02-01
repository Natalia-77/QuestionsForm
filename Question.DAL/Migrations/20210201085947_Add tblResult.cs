using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Question.Migrations
{
    public partial class AddtblResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SessionId = table.Column<int>(nullable: false),
                    AnswerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblResult_tblAnswers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "tblAnswers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblResult_tblSession_SessionId",
                        column: x => x.SessionId,
                        principalTable: "tblSession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblResult_AnswerId",
                table: "tblResult",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblResult_SessionId",
                table: "tblResult",
                column: "SessionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblResult");
        }
    }
}
