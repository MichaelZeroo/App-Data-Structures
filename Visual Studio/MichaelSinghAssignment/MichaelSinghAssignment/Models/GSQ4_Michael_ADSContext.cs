using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MichaelSinghAssignment.Models
{
    public partial class GSQ4_Michael_ADSContext : DbContext
    {
        public GSQ4_Michael_ADSContext()
        {
        }

        public GSQ4_Michael_ADSContext(DbContextOptions<GSQ4_Michael_ADSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=xmsql04.australiaeast.cloudapp.azure.com,6302;Initial Catalog=GSQ4_Michael_ADS;Persist Security Info=True;User ID=GSQ4_Michael;Password=fBit$60563;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.BookName).HasMaxLength(50);

                entity.Property(e => e.Publisher).HasMaxLength(50);

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.Category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Category");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category1)
                    .HasColumnName("Category")
                    .HasMaxLength(50);
            });
        }
    }
}
