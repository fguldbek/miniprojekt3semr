using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace minireddit.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Posts",
                newName: "Votes");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Posts",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Comment",
                newName: "Votes");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Comment",
                newName: "User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Votes",
                table: "Posts",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Posts",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "Votes",
                table: "Comment",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Comment",
                newName: "Author");
        }
    }
}
