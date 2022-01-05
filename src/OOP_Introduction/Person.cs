using System;

namespace OOP_Introduction
{
	// Class Person which is implementing the interface IPerson
	// The class is abstract so it can't be instanced with the keyword "new"
	// and has properties Name, Age, Gender
	public abstract class Person : IPerson
	{
		private string name;

		// This is a constructor. This method is called every this when
		// a instance is created from this class
		private Person()
		{
			this.Name = "No name";
			this.Age = 10;
		}

		// If a method or a property is descripted as protected only
		// the classes that are children to this class can have access
		// to these methods/properties
		protected Person(string name)
			: this()
		{
			this.Name = name;
		}

		protected Person(string name, int age)
			: this(name)
		{
			this.Age = age;
		}

		// This is property. It has extended getter and setter
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

		// Every property/method that is marked as abstract should be implemented by every child
		public abstract string ReturnName();

		public override string ToString()
		{
			string output = $"Hi! My name is {this.Name} and I am {this.Age}yo.";

			return output;
		}
	}
}
