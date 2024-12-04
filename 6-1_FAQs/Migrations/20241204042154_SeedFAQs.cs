using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _6_1_FAQs.Migrations
{
    /// <inheritdoc />
    public partial class SeedFAQs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Answer", "CategoryId", "Question", "TopicId" },
                values: new object[] { "A general-purpose scripting language that executes in a web browser.", "general", "What is JavaScript?", "javascript" });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "Id", "Answer", "CategoryId", "Question", "TopicId" },
                values: new object[,]
                {
                    { 4, "In 2011.", "history", "When was Bootstrap first released?", "bootstrap" },
                    { 5, "In 2002.", "history", "When was C# first released?", "csharp" },
                    { 6, "In 1995.", "history", "When was JavaScript first released?", "javascript" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Answer", "CategoryId", "Question", "TopicId" },
                values: new object[] { "In 2011.", "history", "When was Bootstrap first released?", "bootstrap" });
        }
    }
}
