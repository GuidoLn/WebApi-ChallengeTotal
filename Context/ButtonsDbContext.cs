using ChallengeTotalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeTotalApi.Context
{
    public class ButtonsDbContext : DbContext
    {
        public DbSet<ButtonModel> Buttons { get; set; }
        public ButtonsDbContext(DbContextOptions<ButtonsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ButtonModel>()
                .HasKey(b => b.button_id);
        }

    }
}
