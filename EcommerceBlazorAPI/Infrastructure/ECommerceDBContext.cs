namespace EcommerceBlazorAPI.Infrastructure
{
    public class ECommerceDBContext : DbContext
    {
        public ECommerceDBContext(DbContextOptions<ECommerceDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {

                    Id = 1,
                    Description = @"A shocking scientific discovery. A conspiracy of staggerning brillliance.
            A thriller unlike any you've ever read When a NASA satellite discover's an astonishingly rare object buried deep int the Arctic ice,
            the floundering space agency proclaims a much-needed victory-a victory with profound implications for
            NASA policy and the impending presidential election. To verify the authenticity of the find, the White House calls upon the skills of
            inteligence analyst Rachel Sexton, Accompanied by a team of experts, including the charismatic scholar Michael Tolltant,
            Rachel travels in the Arctic and uncovers the unthinkable: evidence of scientiffic trickery-a bold deception that threatens to plonge
            the worked into controversy. But before she can warn the President, Rachel and Michael are ambushed by a team of assassins. Fleeing
            for their lives across a desolate and lethal landscape, their only hope for survival is to discover who is behind this masterful plet.
            The truth, they willl learn, is the most shacking deception of all.",
                    Title = "Deception Point",
                    Price = 9.99m,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTFVyV1YAElOgtvxqnsrrCI4cUfh7dCMYxNLj7zqv38zcFe14rI",
                    Author = "Dan Brown"

                },
                new Product()
                {

                    Id = 2,
                    Description = @"HECTOR CROSS, ex-SAS officer, private security expert, widower. His wife was taken much too soon, by a cruel man with evil intentions.
            JOHNNY CONGO, psychopath, extortionist, terrorist, the man who murdered Hector’s wife. Cross wants him dead. So does the US government.
            Congo is locked up on Death Row in the most secure prison in the free world, counting down the days until his execution. He’s got two weeks. He wants out. He’s escaped before and knows he can again.
            Cross, still licking his wounds from his last bruising encounter with Congo, is back and ready for work. In the middle of the rough Atlantic stands oil supertanker Bannock A.
            Terrorist activity in the area has triggered panic and there’s only one person they can trust to prot...",
                    Title = "Predator",
                    Price = 6.99m,
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:2782776/wh:true/wi:500",
                    Author = "Wilbur Smith"

                },
                new Product()
                {

                    Id = 3,
                    Description = "War is peace, freedom is slavery, ignorance is strength.” This is the motto of the authoritarian regime in George Orwell’s classic dystopian novel, Nineteen Eighty-Four. Many of the ideas and words ...",
                    Title = "1984",
                    Price = 3.99m,
                    ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0001907681001-1.jpg",
                    Author = "George Orwell"

                });
        }
        public DbSet<Product> Products { get; set; }
    }
}
