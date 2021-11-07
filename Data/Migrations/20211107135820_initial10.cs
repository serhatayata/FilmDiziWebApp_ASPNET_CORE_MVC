using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentComments_Users_UserID",
                table: "ContentComments");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "ContentComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentComments_Users_UserID",
                table: "ContentComments",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentComments_Users_UserID",
                table: "ContentComments");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "ContentComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentComments_Users_UserID",
                table: "ContentComments",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
