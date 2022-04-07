using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_MS.Migrations
{
    public partial class relation_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_bookCategories_BookCategoryCategoryID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookCategoryCategoryID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookCategoryCategoryID",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_bookCategories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "bookCategories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_bookCategories_CategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookCategoryCategoryID",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCategoryCategoryID",
                table: "Books",
                column: "BookCategoryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_bookCategories_BookCategoryCategoryID",
                table: "Books",
                column: "BookCategoryCategoryID",
                principalTable: "bookCategories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
