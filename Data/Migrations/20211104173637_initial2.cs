using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentComments_Contents_SeriesContentID",
                table: "ContentComments");

            migrationBuilder.RenameColumn(
                name: "SeriesContentID",
                table: "ContentComments",
                newName: "ContentID");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "ContentComments",
                newName: "Body");

            migrationBuilder.RenameIndex(
                name: "IX_ContentComments_SeriesContentID",
                table: "ContentComments",
                newName: "IX_ContentComments_ContentID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentComments_Contents_ContentID",
                table: "ContentComments",
                column: "ContentID",
                principalTable: "Contents",
                principalColumn: "ContentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentComments_Contents_ContentID",
                table: "ContentComments");

            migrationBuilder.RenameColumn(
                name: "ContentID",
                table: "ContentComments",
                newName: "SeriesContentID");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "ContentComments",
                newName: "Content");

            migrationBuilder.RenameIndex(
                name: "IX_ContentComments_ContentID",
                table: "ContentComments",
                newName: "IX_ContentComments_SeriesContentID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentComments_Contents_SeriesContentID",
                table: "ContentComments",
                column: "SeriesContentID",
                principalTable: "Contents",
                principalColumn: "ContentID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
