namespace Interfaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// InterfaceIntro();

			// VeriTabanı();


			ICustomerDal[] customerDals = new ICustomerDal[2]
			{
				new SqlServerCustomerDal(),
				new OracleCustomerDal()
			};

			foreach (var customerDal in customerDals)
			{
				customerDal.Add();
			}
			Console.ReadLine();
		}

		private static void VeriTabanı()
		{
			CustomerManager customerManager = new CustomerManager();
			customerManager.Add(new SqlServerCustomerDal());
			customerManager.Add(new OracleCustomerDal());
		}

		private static void InterfaceIntro()
		{
			PersonManager manager = new PersonManager();
			manager.Add(new Customer { FirstName = "Deniz", Adress = "İstanbul", Id = 2, LastName = "Alan" });
		}
	}

	interface IPerson
	{
        public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
    }

	class Customer : IPerson
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public string Adress { get; set; }

    }

	class Student : IPerson
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public string Departman { get; set; }
    }

	class PersonManager
	{
		public void Add (Customer customer)
		{
            Console.WriteLine(customer.FirstName);
        }
	}
}
