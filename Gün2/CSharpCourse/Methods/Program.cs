namespace Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Add();
			Add();
			Add();
			var result = Add2(20, 60);
			int number1 = 20; //ref keywordunda deger zorunlu
			//int number1; 	  //our keywordunde deger zorunlu degil
			int number2=100;
			var result2 = Add3( ref number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
			//referans tipe (ref keyword) değiştirildiği için number1 degeri artık 30 oldu
			//out keywordu ref keywordu ile aynı çalışır tek fark ref keywordde ilk değişkene deger atanmalı
            Console.WriteLine(number1);
			Console.WriteLine(Multiply(2,8));
			Console.WriteLine(Multiply(2,8,6));
            Console.WriteLine(Add4(2,5,7,9,6));
            Console.ReadLine();
		}

		static void Add()
		{
            Console.WriteLine("Add!");
        }

		//number2 ye defoult degeri verilir , methodun sonunda olması lazım defoult degerlerinin
		static int Add2(int number1 , int number2=30)
		{
			return number1 + number2;
		}

		static int Add3 (ref int number1 , int number2)
		{
			number1 = 30;
			return number1 + number2;
		} 

		static int Multiply (int number1, int number2)
		{
			return (number1 * number2);
		}

		//methodların aşırı yüklenmesi // method imzası aynı
		static int Multiply(int number1, int number2, int number3)
		{
			return (number1 * number2*number3);
		}

		static int Add4(int number1 , int number2)
		{
			return number1 * number2;
		}

		//params => dizi formatında parametre yollayacagım demek // methodun aşırı yüklenmesi
		static int Add4(params int[] numbers)
		{
			return numbers.Sum();
		}

	}
}
