using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEComBlazor.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "he Road Ahead is a book written by Bill Gates, co-founder and previous chairman and CEO of Microsoft software company, together with Microsoft executive Nathan Myhrvold and former Microsoft vice president and Pulitzer Prize winner Peter Rinearson.", "https://upload.wikimedia.org/wikipedia/en/e/e2/The_Road_Ahead_%28Bill_Gates_book%29.jpg", 9.99m, "The Road Ahead (Gates book)" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "How to Avoid a Climate Disaster: The Solutions We Have and the Breakthroughs We Need is a 2021 book by Bill Gates. In it, Gates presents what he learned in over a decade of studying climate change and investing in innovations to address global warming and recommends strategies to tackle it.", "https://upload.wikimedia.org/wikipedia/commons/7/70/How_to_Avoid_a_Climate_Disaster_%28Bill_Gates%29.png", 9.99m, "How to Avoid a Climate Disaster" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Business @ the Speed of Thought[1] is a book written by Bill Gates and Collins Hemingway in 1999. It discusses how business and technology are integrated, and explains how digital infrastructures and information networks can help someone get an edge on the competition.", "https://upload.wikimedia.org/wikipedia/en/3/3d/Business_%40_the_Speed_of_Thought_%28book_cover%29.jpg", 9.99m, "Business @ the Speed of Thought" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
