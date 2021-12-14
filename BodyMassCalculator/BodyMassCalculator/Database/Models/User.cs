namespace BodyMassCalculator.Database.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class User
	{
		public User()
		{
			this.CreatedAt = DateTime.UtcNow;
			this.BodyMassCalculatorStatistics = new HashSet<BodyMassCalculatorStatistic>();
		}

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(32)]
		public string Username { get; set; }

		[Required]
		public string PasswordHash { get; set; }

		public DateTime CreatedAt { get; set; }

		[Required]
		public int GenderId { get; set; }
		public Gender Gender { get; set; }

		public ICollection<BodyMassCalculatorStatistic> BodyMassCalculatorStatistics { get; set; }
	}
}
