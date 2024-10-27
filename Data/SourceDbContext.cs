using DatabaseSync.Models.Source;
using Microsoft.EntityFrameworkCore;

namespace DatabaseSync.Data
{
    public class SourceDbContext : DbContext
    {
        public DbSet<SourceCustomer> Customers { get; set; }
        public DbSet<SourceLocation> Locations { get; set; }

        public SourceDbContext(DbContextOptions<SourceDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<SourceCustomer>()
            //    .Property(c => c.LastModified)
            //    .IsConcurrencyToken();

            //modelBuilder.Entity<SourceLocation>()
            //    .Property(l => l.LastModified)
            //    .IsConcurrencyToken();

            modelBuilder.Entity<SourceCustomer>()
            .HasMany(c => c.Locations)
            .WithOne(l => l.Customer)
            .HasForeignKey(l => l.CustomerID)
            .OnDelete(DeleteBehavior.Cascade);

            // Seed data for Customers and Locations
            modelBuilder.Entity<SourceCustomer>().HasData(
                new SourceCustomer { CustomerID = 1, Name = "Sapana Shrestha", Email = "sapana@gmail.com", Phone = "9811111111" },
                new SourceCustomer { CustomerID = 2, Name = "Sahil Shrestha", Email = "sahil@gmail.com", Phone = "9822222222" },
                new SourceCustomer { CustomerID = 3, Name = "Aayush Khadka", Email = "aayush@gmail.com", Phone = "9833333333" },
                new SourceCustomer { CustomerID = 4, Name = "Sneha Sharma", Email = "sneha@gmail.com", Phone = "9844444444" },
                new SourceCustomer { CustomerID = 5, Name = "Rajesh Karki", Email = "rajesh@gmail.com", Phone = "9855555555" },
                new SourceCustomer { CustomerID = 6, Name = "Ramesh Bhandari", Email = "ramesh@gmail.com", Phone = "9866666666" },
                new SourceCustomer { CustomerID = 7, Name = "Nabin Rijal", Email = "nabin@gmail.com", Phone = "9877777777" },
                new SourceCustomer { CustomerID = 8, Name = "Sita Rai", Email = "sita@gmail.com", Phone = "9888888888" },
                new SourceCustomer { CustomerID = 9, Name = "Pratiksha Joshi", Email = "pratiksha@gmail.com", Phone = "9899999999" },
                new SourceCustomer { CustomerID = 10, Name = "Bikash Acharya", Email = "bikash@gmail.com", Phone = "9800000001" },
                new SourceCustomer { CustomerID = 11, Name = "Santosh Yadav", Email = "santosh@gmail.com", Phone = "9800000002" },
                new SourceCustomer { CustomerID = 12, Name = "Niraj Gurung", Email = "niraj@gmail.com", Phone = "9800000003" },
                new SourceCustomer { CustomerID = 13, Name = "Kriti Maharjan", Email = "kriti@gmail.com", Phone = "9800000004" },
                new SourceCustomer { CustomerID = 14, Name = "Binita Kunwar", Email = "binita@gmail.com", Phone = "9800000005" },
                new SourceCustomer { CustomerID = 15, Name = "Saroj Luitel", Email = "saroj@gmail.com", Phone = "9800000006" },
                new SourceCustomer { CustomerID = 16, Name = "Asmita Lama", Email = "asmita@gmail.com", Phone = "9800000007" },
                new SourceCustomer { CustomerID = 17, Name = "Kiran Sapkota", Email = "kiran@gmail.com", Phone = "9800000008" },
                new SourceCustomer { CustomerID = 18, Name = "Bhawana Adhikari", Email = "bhawana@gmail.com", Phone = "9800000009" },
                new SourceCustomer { CustomerID = 19, Name = "Arjun Adhikari", Email = "arjun@gmail.com", Phone = "9800000010" },
                new SourceCustomer { CustomerID = 20, Name = "Mina Magar", Email = "mina@gmail.com", Phone = "9800000011" }
            );

            modelBuilder.Entity<SourceLocation>().HasData(
            new SourceLocation { LocationID = 1, CustomerID = 1, Address = "Kathmandu" },
            new SourceLocation { LocationID = 2, CustomerID = 1, Address = "Bhaktapur" },
            new SourceLocation { LocationID = 3, CustomerID = 2, Address = "Dang" },
            new SourceLocation { LocationID = 4, CustomerID = 3, Address = "Chitwan" },
            new SourceLocation { LocationID = 5, CustomerID = 3, Address = "Butwal" },
            new SourceLocation { LocationID = 6, CustomerID = 4, Address = "Dharan" },
            new SourceLocation { LocationID = 7, CustomerID = 5, Address = "Janakpur" },
            new SourceLocation { LocationID = 8, CustomerID = 6, Address = "Nepalgunj" },
            new SourceLocation { LocationID = 9, CustomerID = 7, Address = "Birgunj" },
            new SourceLocation { LocationID = 10, CustomerID = 7, Address = "Hetauda" },
            new SourceLocation { LocationID = 11, CustomerID = 8, Address = "Gorkha" },
            new SourceLocation { LocationID = 12, CustomerID = 9, Address = "Lamjung" },
            new SourceLocation { LocationID = 13, CustomerID = 10, Address = "Palpa" },
            new SourceLocation { LocationID = 14, CustomerID = 10, Address = "Syangja" },
            new SourceLocation { LocationID = 15, CustomerID = 11, Address = "Baglung" },
            new SourceLocation { LocationID = 16, CustomerID = 12, Address = "Damauli" },
            new SourceLocation { LocationID = 17, CustomerID = 13, Address = "Tanahun" },
            new SourceLocation { LocationID = 18, CustomerID = 14, Address = "Ilam" },
            new SourceLocation { LocationID = 19, CustomerID = 15, Address = "Jhapa" },
            new SourceLocation { LocationID = 20, CustomerID = 16, Address = "Kavre" },
            new SourceLocation { LocationID = 21, CustomerID = 16, Address = "Banepa" },
            new SourceLocation { LocationID = 22, CustomerID = 17, Address = "Sindhuli" },
            new SourceLocation { LocationID = 23, CustomerID = 18, Address = "Nuwakot" },
            new SourceLocation { LocationID = 24, CustomerID = 19, Address = "Ramechhap" },
            new SourceLocation { LocationID = 25, CustomerID = 20, Address = "Dolakha" }
        );
        }
    }
}
