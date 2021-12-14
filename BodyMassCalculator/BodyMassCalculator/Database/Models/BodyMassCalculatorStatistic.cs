namespace BodyMassCalculator.Database.Models
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class BodyMassCalculatorStatistic
	{
		public BodyMassCalculatorStatistic()
		{
			this.CreatedAt = DateTime.UtcNow;
		}

		public int Id { get; set; }

		[Required]
		public double Weight { get; set; }

		[Required]
		public double Height { get; set; }

		public DateTime CreatedAt { get; set; }

		[Required]
		public int UserId { get; set; }
		public User User { get; set; }
	}
}
