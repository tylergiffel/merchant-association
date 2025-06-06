using Microsoft.EntityFrameworkCore;
using MerchantAssociation.API.Models;

namespace MerchantAssociation.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Business> Businesses { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<BusinessOwner> BusinessOwners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BusinessOwner>()
                .HasKey(bo => new { bo.BusinessId, bo.OwnerId });

            modelBuilder.Entity<BusinessOwner>()
                .HasOne(bo => bo.Business)
                .WithMany(b => b.BusinessOwners)
                .HasForeignKey(bo => bo.BusinessId);

            modelBuilder.Entity<BusinessOwner>()
                .HasOne(bo => bo.Owner)
                .WithMany(o => o.BusinessOwners)
                .HasForeignKey(bo => bo.OwnerId);
        }
    }
}