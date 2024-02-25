namespace Conditionals
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var number = 10;
			
			if (number == 0)
			{
				Console.WriteLine("Number is 10");
			}
			else if (number == 20)
			{
				Console.WriteLine("Number is 20");
			}
			else
			{
				Console.WriteLine("NUmber is not 10 or 20");
			}

			Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

			
			switch (number)
			{
				case 10:
					Console.WriteLine("Number is 10");
					break;
				case 20:
					Console.WriteLine("Number is 20");
					break;
				default: 
					Console.WriteLine("NUmber is not 10 or 20");
					break;

			}

			if(number>=0 && number<=100)
			{
                Console.WriteLine("Number is between 0-100");
            }
			else if (number>101 && number<=200)
			{
				Console.WriteLine("Number is between 101-200");
			}
			else if (number>200 || number < 0)
			{
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

			//iç içe if 
			if (number < 100)
			{
				if(number >80 &&  number <= 95)
				{

				}
				else
				{

				}
				if( true)
				{
					if (true)
					{

					}

				}
			}

			Console.ReadLine();
		}
	}
}
