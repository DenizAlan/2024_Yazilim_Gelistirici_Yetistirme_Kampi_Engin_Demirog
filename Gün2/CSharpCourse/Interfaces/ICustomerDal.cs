using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	internal interface ICustomerDal
	{
		void Add();
		void Update();
		void Delete();
	}

	class SqlServerCustomerDal : ICustomerDal
	{
		public void Add()
		{
            Console.WriteLine("Sql added");
        }

		public void Delete()
		{
			Console.WriteLine("Sql deleded");
		}

		public void Update()
		{
			Console.WriteLine("Sql updated");
		}
	}

	class OracleCustomerDal : ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("Oracle added");
		}

		public void Delete()
		{
			Console.WriteLine("Oracle deleded");
		}

		public void Update()
		{
			Console.WriteLine("Oracle updated");
		}

	}

	//veri tabaanından bagımsız
	class CustomerManager
	{
		public void Add(ICustomerDal customerDal)
		{
			customerDal.Add();
		}
	}
}
