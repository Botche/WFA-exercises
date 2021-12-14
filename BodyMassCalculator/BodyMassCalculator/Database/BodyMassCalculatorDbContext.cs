namespace BodyMassCalculator.Database
{
	using BodyMassCalculator.Database.Models;

	using Microsoft.EntityFrameworkCore;

	public class BodyMassCalculatorDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		public DbSet<Gender> Genders { get; set; }

		public DbSet<BodyMassCalculatorStatistic> BodyMassCalculatorStatistics { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			if (optionsBuilder.IsConfigured == false)
			{
				string connectionString = "Server=.;Database=BodyMassCalculator;Integrated security=true;";
				optionsBuilder.UseSqlServer(connectionString);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder
				.Entity<User>()
				.HasOne(u => u.Gender)
				.WithMany(g => g.Users)
				.HasForeignKey(u => u.GenderId);

			modelBuilder
				.Entity<BodyMassCalculatorStatistic>()
				.HasOne(bmcs => bmcs.User)
				.WithMany(u => u.BodyMassCalculatorStatistics)
				.HasForeignKey(bmcs => bmcs.UserId);

			modelBuilder
				.Entity<User>()
				.HasIndex(u => u.Username)
				.IsUnique(true);

			modelBuilder
				.Entity<Gender>()
				.HasIndex(g => g.Name)
				.IsUnique(true);

			// modelBuilder
			//	.Entity<User>()
			//	.Property(u => u.Username)
			//	.IsRequired(true);

			// modelBuilder
			//	.Entity<User>()
			//	.HasMany(u => u.BodyMassCalculatorStatistics)
			//	.WithOne(bmcs => bmcs.User)
			//	.HasForeignKey(bmcs => bmcs.UserId);
		}
	}
}
