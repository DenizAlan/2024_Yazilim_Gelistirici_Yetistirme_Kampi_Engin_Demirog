namespace İnterfaces2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1. Yol
			IPerson customer = new Customer();  //Referans tip adres tuttuugu için böyle newlenebilir
			ProjectManager projectManager = new ProjectManager();
			projectManager.Add(customer);
            //2.Yol
            projectManager.Add(new Employes());

            Console.WriteLine();
        }
	}

	interface IPerson
	{
		void Add();
		void Update();
	}

	class Customer : IPerson
	{
		public void Add()
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}
	}

	class Employes : IPerson
	{
		public void Add()
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}
	}

	class ProjectManager
	{
		//interfaceden implante edilen diğer classlara ulaşır
		public void Add(IPerson person)
		{
			throw new NotImplementedException();
		}
	}
}
