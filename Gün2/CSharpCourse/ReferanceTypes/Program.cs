using System.Threading.Channels;

namespace ReferanceTypes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// int decimal float enum boolean value types (değer tip) (stact bölgesinde)
			int sayi1 = 10;
			int sayi2 = 20;
			sayi1 = sayi2;
			sayi2 = 100;
			Console.WriteLine("Sayi 1 : " + sayi1);


			//arrayler classlar interfaceler referans type (Heap bölgesinde) (newlenince adres tutuyor)
			int[] sayilar1 = new int[] { 1, 2, 3 };
			int[] sayilar2 = new int[] { 10, 20, 30 };
			sayilar1 = sayilar2;
			sayilar2[0] = 10000;
			Console.WriteLine("Sayilar 1[0] = " + sayilar1[0]);

			Person person1 = new Person();
			Person person2 = new Person();
			person1.FirstName = "Deniz";
			person2 = person1;
			person1.FirstName = "Su";  //classlarda referans degerli oldugu(adres tutar) için person2 de su olur

            Console.WriteLine(person2.FirstName);




            Customer customer = new Customer();
			customer.FirstName = "Merve";
			customer.CreditCardNumber = "545645645645";
			Person person3 = customer;
            Console.WriteLine(person3.FirstName);


            Console.WriteLine(((Customer)person3).CreditCardNumber);

            Employe employe = new Employe();
			employe.FirstName = "Bahar";

			PersonManager personManager = new PersonManager();
			personManager.Add(person2);

			Console.ReadLine();

		}
	}


	//base class person burada (Ebeveyn gibi düşün)
	class Person
	{
		public int id { get; set; }
		public string FirstName { get; set; }

		public string LastName { get; set; }
	}

	//customer personun çocugu gibi
	class Customer:Person
	{
		public string CreditCardNumber { get; set; }
	}

	class Employe:Person
	{
		public int EmployeNumber { get; set; }
	}

	class PersonManager
	{

		//aynı kodu farklı nesneler için çalıştırabilirsin
		public void Add (Person person)
		{
			Console.WriteLine(person.FirstName);
		}
	}
}
