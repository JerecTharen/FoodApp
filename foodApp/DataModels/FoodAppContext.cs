using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace foodApp.DataModels
{
    public partial class FoodAppContext : DbContext
    {
        public FoodAppContext()
        {
        }

        public FoodAppContext(DbContextOptions<FoodAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=FoodApp;Username=postgres;Password=mantine94");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("users_pkey");

                entity.ToTable("users");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddedRecipesTable).HasColumnName("added_recipes_table");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.FirstName).HasColumnName("first_name");

                entity.Property(e => e.FriendsTable).HasColumnName("friends_table");

                entity.Property(e => e.LastName).HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.ProfilePicutre).HasColumnName("profile_picutre");

                entity.Property(e => e.SavedRecipesTable).HasColumnName("saved_recipes_table");
            });
        }
    }
}
