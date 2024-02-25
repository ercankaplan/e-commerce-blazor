namespace EcommerceBlazorAPI.Infrastructure
{
    public class ECommerceDBContext : DbContext
    {
        public ECommerceDBContext(DbContextOptions<ECommerceDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Book Store",
                    Url = "book-store"
                },
                 new Category()
                 {
                     Id = 2,
                     Name = "Electronics",
                     Url = "electronics"
                 },
                 new Category()
                 {
                     Id = 3,
                     Name = "Gaming Store",
                     Url = "gaming-store"
                 },
                   new Category()
                   {
                       Id = 4,
                       Name = "Sports and Outdoors",
                       Url = "sports-outdoors"
                   },
                     new Category
                     {
                         Id = 5,
                         Name = "Movies",
                         Url = "movies"
                     }

                );

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
                    Author = "Dan Brown",
                    CategoryId = 1,

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
                    Author = "Wilbur Smith",
                    CategoryId = 1,

                },
                new Product()
                {

                    Id = 3,
                    Description = "War is peace, freedom is slavery, ignorance is strength.” This is the motto of the authoritarian regime in George Orwell’s classic dystopian novel, Nineteen Eighty-Four. Many of the ideas and words ...",
                    Title = "1984",
                    Price = 3.99m,
                    ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0001907681001-1.jpg",
                    Author = "George Orwell",
                    CategoryId = 1,

                },
                new Product
                {
                    Id = 4,
                    CategoryId = 5,
                    Title = "The Matrix",
                    Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                },
                 new Product
                 {
                     Id = 5,
                     CategoryId = 5,
                     Title = "Back to the Future",
                     Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                     Price = 4.99m,

                 },
                   new Product
                   {
                       Id = 6,
                       CategoryId = 5,
                       Title = "Toy Story",
                       Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                       ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                       Price = 7.39m,

                   },
                    new Product
                    {
                        Id = 7,
                        CategoryId = 3,
                        Title = "Half-Life 2",
                        Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                        Price = 2.00m,

                    },
                      new Product
                      {
                          Id = 8,
                          CategoryId = 3,
                          Title = "Diablo II",
                          Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                          ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                          Price = 50.99m,
                      },
                       new Product
                       {
                           Id = 9,
                           CategoryId = 3,
                           Title = "Day of the Tentacle",
                           Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                           ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                           Price = 5.05m,

                       },
                        new Product
                        {
                            Id = 10,
                            CategoryId = 3,
                            Title = "Xbox",
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Price = 4.00m,
                        },
                         new Product
                         {
                             Id = 11,
                             CategoryId = 3,
                             Title = "Super Nintendo Entertainment System",
                             Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                             ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                             Price = 449.99m,
                         }
                );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
