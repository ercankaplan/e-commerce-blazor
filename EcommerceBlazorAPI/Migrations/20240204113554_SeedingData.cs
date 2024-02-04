using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceBlazorAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Category", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Dan Brown", "", "A shocking scientific discovery. A conspiracy of staggerning brillliance.\r\n            A thriller unlike any you've ever read When a NASA satellite discover's an astonishingly rare object buried deep int the Arctic ice,\r\n            the floundering space agency proclaims a much-needed victory-a victory with profound implications for\r\n            NASA policy and the impending presidential election. To verify the authenticity of the find, the White House calls upon the skills of\r\n            inteligence analyst Rachel Sexton, Accompanied by a team of experts, including the charismatic scholar Michael Tolltant,\r\n            Rachel travels in the Arctic and uncovers the unthinkable: evidence of scientiffic trickery-a bold deception that threatens to plonge\r\n            the worked into controversy. But before she can warn the President, Rachel and Michael are ambushed by a team of assassins. Fleeing\r\n            for their lives across a desolate and lethal landscape, their only hope for survival is to discover who is behind this masterful plet.\r\n            The truth, they willl learn, is the most shacking deception of all.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTFVyV1YAElOgtvxqnsrrCI4cUfh7dCMYxNLj7zqv38zcFe14rI", 9.99m, "Deception Point" },
                    { 2, "Wilbur Smith", "", "HECTOR CROSS, ex-SAS officer, private security expert, widower. His wife was taken much too soon, by a cruel man with evil intentions.\r\n            JOHNNY CONGO, psychopath, extortionist, terrorist, the man who murdered Hector’s wife. Cross wants him dead. So does the US government.\r\n            Congo is locked up on Death Row in the most secure prison in the free world, counting down the days until his execution. He’s got two weeks. He wants out. He’s escaped before and knows he can again.\r\n            Cross, still licking his wounds from his last bruising encounter with Congo, is back and ready for work. In the middle of the rough Atlantic stands oil supertanker Bannock A.\r\n            Terrorist activity in the area has triggered panic and there’s only one person they can trust to prot...", "https://img.kitapyurdu.com/v1/getImage/fn:2782776/wh:true/wi:500", 6.99m, "Predator" },
                    { 3, "George Orwell", "", "War is peace, freedom is slavery, ignorance is strength.” This is the motto of the authoritarian regime in George Orwell’s classic dystopian novel, Nineteen Eighty-Four. Many of the ideas and words ...", "https://i.dr.com.tr/cache/600x600-0/originals/0001907681001-1.jpg", 3.99m, "1984" }
                });
        }

        /// <inheritdoc />
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
