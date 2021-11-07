using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentComments_Contents_ContentID",
                table: "ContentComments");

            migrationBuilder.AlterColumn<int>(
                name: "ContentID",
                table: "ContentComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentComments_Contents_ContentID",
                table: "ContentComments",
                column: "ContentID",
                principalTable: "Contents",
                principalColumn: "ContentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentComments_Contents_ContentID",
                table: "ContentComments");

            migrationBuilder.AlterColumn<int>(
                name: "ContentID",
                table: "ContentComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentComments_Contents_ContentID",
                table: "ContentComments",
                column: "ContentID",
                principalTable: "Contents",
                principalColumn: "ContentID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
