using System;

namespace OOP_Introduction
{
	public abstract class Person : IPerson
	{
		private string name;

		private Person()
		{
			this.Name = "No name";
			this.Age = 10;
		}

		public Person(string name)
			: this()
		{
			this.Name = name;
		}

		public Person(string name, int age)
			: this(name)
		{
			this.Age = age;
		}

		public string Name 
		{ 
			get
			{
				return this.name;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException(nameof(this.Name), "Name cannot be empty or null");
				}

				if (char.IsUpper(value[0]) == false)
				{
					throw new ArgumentException("Name must start with upper letter");
				}

				this.name = value;
			} 
		}

		public int Age { get; set; }

		public Gender Gender { get; set; }

		public void PrinInfo()
		{
			Console.WriteLine(this.Name);
		}

		public abstract string ReturnName();

		public override string ToString()
		{
			string output = $"Hi! My name is {this.Name} and I am {this.Age}yo.";

			return output;
		}
	}
}
