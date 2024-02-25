namespace Loops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			 ForLoop();

			 WhileLoop();

		     DoWhileLoop();

			ForeachLoop();

			if (IsPrimeNumber(6))
			{
                Console.WriteLine("This is a prime number");
			}
			else
			{
				Console.WriteLine("This is not a prime number");
			}

			Console.ReadLine();
		}


		//sayımız asal mı?
		private static bool IsPrimeNumber(int number)
		{

			bool result = true;
			for (int i = 2; i < number - 1; i++)
			{
				if (number % i == 0)
				{
					result = false;
					break;
				}
			}
			return result;
		}
		private static void ForeachLoop()
		{
			string[] students = new[] { "Çagla", "Ayşe", "Deniz" };
			foreach (var student in students)
			{

				Console.WriteLine(student);
			}
		}

		private static void DoWhileLoop()
		{
			int number = 10;
			do
			{
				Console.WriteLine(number);
				number--;
			} while (number >= 0);
		}

		private static void WhileLoop()
		{
			int number = 100;
			while (number >= 100)
			{
				Console.WriteLine(number);
				number--;
			}
		}

		private static void ForLoop()
		{
			for (int i = 1; i < 100; i += 2)
			{
				Console.WriteLine(i);
			}
		}
	}
}
