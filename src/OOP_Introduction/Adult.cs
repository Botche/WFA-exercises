namespace OOP_Introduction
{
	// Child class of Person
	public class Adult : Person
	{
		public Adult(string name)
			: base(name)
		{
		}

		public Adult(string name, int age)
			: base(name, age)
		{
		}

		public int Salary { get; set; }

		public override string ReturnName()
		{
			throw new System.NotImplementedException();
		}
	}
}
