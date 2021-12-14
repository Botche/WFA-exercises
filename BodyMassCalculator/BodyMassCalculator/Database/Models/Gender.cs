namespace BodyMassCalculator.Database.Models
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Gender
	{
		public Gender()
		{
			this.Users = new HashSet<User>();
		}

		public int Id { get; set; }

		[Required]
		[MaxLength(64)]
		public string Name { get; set; }

		public ICollection<User> Users { get; set; }
	}
}
