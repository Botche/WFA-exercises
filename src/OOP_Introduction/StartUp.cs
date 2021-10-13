using System;

namespace OOP_Introduction
{
	class StartUp
	{
		static void Main(string[] args)
		{
			Child child = new Child("Gosho");

			child.Gender = (Gender)Enum.Parse(typeof(Gender), "male", true);

			Console.WriteLine(child);
		}
	}
}
