namespace Classes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CustomerManager customerManager = new CustomerManager();
			customerManager.Add();
			customerManager.Update();

			ProdactManager prodactManager = new ProdactManager();
			prodactManager.Update();
			prodactManager.Add();

			Customer customer = new Customer();
			customer.Address = "İstanbul";
			customer.FirstName = "Test";
			customer.LastName = "Test";
			customer.Id = 1;

			Customer customer1 = new Customer
			{
				Id = 2, FirstName = "Test1", LastName = "Test1", Address="Bursa"

			};

            Console.WriteLine(customer1.FirstName);
        }
	}

	

	
}
