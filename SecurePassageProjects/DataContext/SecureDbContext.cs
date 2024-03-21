using Microsoft.EntityFrameworkCore;
using SecurePassageProjects.Models;

namespace SecurePassageProjects.DataContext
{
    public class SecureDbContext : DbContext
    {

        public SecureDbContext(DbContextOptions options) : base(options)
        {




        }

        public DbSet<signupModel> signupModels { get; set; }
        public DbSet<GoogleModel> googleModels { get; set; }
        public DbSet<FacebookModel> facebookModels { get; set; }

        public DbSet<InstgramModel> instgramModels { get; set; }

        public DbSet<BankingModel> bankingModels { get; set; }
       





    }
}
