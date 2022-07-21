namespace DemoEComBlazor.Server.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Title = "The Road Ahead (Gates book)",
                    Description = "he Road Ahead is a book written by Bill Gates, co-founder and previous chairman and CEO of Microsoft software company, together with Microsoft executive Nathan Myhrvold and former Microsoft vice president and Pulitzer Prize winner Peter Rinearson.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e2/The_Road_Ahead_%28Bill_Gates_book%29.jpg",
                    Price = 9.99m
                },

                new Product
                {
                    Id = 2,
                    Title = "How to Avoid a Climate Disaster",
                    Description = "How to Avoid a Climate Disaster: The Solutions We Have and the Breakthroughs We Need is a 2021 book by Bill Gates. In it, Gates presents what he learned in over a decade of studying climate change and investing in innovations to address global warming and recommends strategies to tackle it.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/70/How_to_Avoid_a_Climate_Disaster_%28Bill_Gates%29.png",
                    Price = 9.99m
                },

              new Product
              {
                  Id = 3,
                  Title = "Business @ the Speed of Thought",
                  Description = "Business @ the Speed of Thought[1] is a book written by Bill Gates and Collins Hemingway in 1999. It discusses how business and technology are integrated, and explains how digital infrastructures and information networks can help someone get an edge on the competition.",
                  ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/3d/Business_%40_the_Speed_of_Thought_%28book_cover%29.jpg",
                  Price = 9.99m
              }

                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
