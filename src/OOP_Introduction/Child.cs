namespace OOP_Introduction
{
	public class Child : Person
	{
		public Child(string name)
			: base(name)
		{
		}

		public Child(string name, int age)
			: base(name, age)
		{
		}

		public override string ReturnName()
		{
			throw new System.NotImplementedException();
		}
	}
}
