namespace TypesAndVariables
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Value Types (deger tipi)

			double number5 = 10.4;   //64bit
			decimal number6 = 10.4M;  //doubleden daha hassas bir deger tipi
			char character= 'a';
			bool condition=false;
			byte number4 = 255;     //8bit
			short number0 = 3;   //16 bit
			int number1 = 10;     //32bit
			long number2 = 20;   //64bit

			var number7 = 7; //Number7 artık bir int oldu
			number7 = 'A'; //atadiğini(char) integera çevirir
			// ----------number7 = "A"; // string int çeviremediği için uyarı verir
            Console.WriteLine("Number7 = "+ number7);  //çıktısı=65 olur

            Console.WriteLine("Number1 is {0} number2 is {1}",number1,number2);
			Console.WriteLine("Character is : {0}", character);
			Console.WriteLine("Character is : {0}",(int)character);  //char'ı integer karşılığına çevirdi
            Console.WriteLine(Days.Friday);		 //Değeri yazdırır= friday
            Console.WriteLine((int)Days.Friday); //enumdaki istenilenin index degerine çevirip yazdırır =4
            Console.WriteLine((int)Fruits.orange); // kendi atadıgım degeri yazar =7

            Console.ReadLine();
		}
	}

	enum Days
	{
		//enum sabitleri denir
		Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,
		
	}

	enum  Fruits
	{
		//Kendim değer belirleyebirim
		apple =10 , orange=7
	}
}
