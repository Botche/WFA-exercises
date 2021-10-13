namespace Intorduction
{
	using System;

	using OOP_Introduction;

	class StartUp
	{
		const string LINE_SEPARATOR = "====================================";

		static void Main(string[] args)
		{
			Child child = new Child("Pesho");

			int countOfNumbers = ReadIntegerFromConsole();

			int[] result = CalculateOddEvenSumForNumbers(countOfNumbers);

			int oddSum = result[0];
			int evenSum = result[1];

			string evenSumOutput = $"Even sum = {evenSum}";
			string oddSumOutput = $"Odd sum = {oddSum}";

			//output = String.Format("Sum = {1} {0} {1}", sum, "BGN");
			//output = "Sum = " + sum.ToString() + " leva";
			Console.WriteLine(LINE_SEPARATOR);
			Console.WriteLine(evenSumOutput);
			Console.WriteLine(oddSumOutput);

			//Console.WriteLine(Substract(3, 4));
			//Console.WriteLine(Method(4, 4));
			//Console.WriteLine(Method(5, 4));
			//Console.WriteLine(Method(5, 4, 3));

			//int[] arr = { 1, 2, 3 };
			//Console.WriteLine(String.Join(", ", arr));

			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.Write(arr[i]);

			//	if (i != arr.Length - 1)
			//	{
			//		Console.Write(", ");
			//	}
			//}

			//Console.WriteLine();
		}

		public static int ReadIntegerFromConsole()
		{
			Console.Write("Enter a number: ");
			string input = Console.ReadLine();
			bool isParsed = int.TryParse(input, out int countOfNumbers);

			while (isParsed == false)
			{
				Console.WriteLine("The entered value is incorrect.");
				Console.Write("Enter a valid number: ");
				input = Console.ReadLine();
				isParsed = int.TryParse(input, out countOfNumbers);
			}

			return countOfNumbers;
		}

		public static int[] CalculateOddEvenSumForNumbers(int countOfNumbers)
		{
			int oddSum = 0;
			int evenSum = 0;

			Console.WriteLine(LINE_SEPARATOR);
			Console.WriteLine("Find odd and even sum of n-th numbers");
			for (int index = 0; index < countOfNumbers; index++)
			{
				int number = ReadIntegerFromConsole();

				string logInfo = number % 2 == 0 ? "even" : "odd";
				Console.WriteLine(logInfo);

				if (number % 2 == 0)
				{
					evenSum += number;
				}
				else
				{
					oddSum += number;
				}
			}

			// int[] result = { oddSum, evenSum }; 
			int[] result = new int[2];
			result[0] = oddSum;
			result[1] = evenSum;

			return result;
		}

		public static int Substract(int a, int b)
		{
			int diff = a - b;

			return diff;
		}

		public static double Method(double number1, int number2)
		{
			double sum = number1 + number2;

			return sum;
		}

		public static int Method(int a, int b, int c)
		{
			int sum = a + b + c;

			return sum;
		}
	}
}
