namespace Constructors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Customer customer = new Customer();
			Customer customer2 = new Customer { Id = 1 , City="İst" , FirsName="Deniz" , LastName ="Alan"};
			Customer customer3 = new Customer ( 2, "Çağla", "Selvi", "İstanbul");
            Console.WriteLine(customer3.LastName);

        }
	}

	class Customer
	{
		//default Constructor // bu blok yazsakta yazmasakda çalışır
		//customer1 bunu kullanır
        public Customer()
        {
            
        }

		// customer3 bunu kullanır
        public Customer(int id , string firstName, string lastName , string city )
        {
			//Gelen parametreleri atıyoruz , büyük küçük harfe dikkat
            Id = id;
			FirsName = firstName;
			LastName = lastName;
			City = city;
        }
        public int Id { get; set; }
		public string FirsName { get; set; }
		public string LastName { get; set; }
		public string City { get; set; }
    }
}
