namespace LinqProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Category> categories = new List<Category>
			{
				new Category{CategoryId=1 , CategoryName="Bilgisayar"},
				new Category{CategoryId=2 , CategoryName="Telefon"}
			};
			List<Product> products = new List<Product>
			{
				new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32Gb Ram", UnitPrice=12000,UnitsInStok=7},
				new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16Gb Ram", UnitPrice=8000,UnitsInStok=5},
				new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8Gb Ram", UnitPrice=7000,UnitsInStok=1},
				new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4Gb Ram", UnitPrice=4000,UnitsInStok=4},
				new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4Gb Ram", UnitPrice=7000,UnitsInStok=8}
			};

            Console.WriteLine("Algoritmik***************");
            foreach (var product in products)
            {
				if (product.UnitPrice > 5000 && product.UnitsInStok>3)
				{
					Console.WriteLine(product.ProductName);
				}
                
            }

			Console.WriteLine("Linq*****************");

			var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStok > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

			GetProducts(products); 

        }

		static List<Product> GetProducts(List<Product> products)
		{
			List<Product> filteredProducts = new List<Product>();
			foreach (var product in products)
			{
				if (product.UnitPrice > 5000 && product.UnitsInStok > 3)
				{
					filteredProducts.Add(product);
				}

			}
			return filteredProducts;
		}

		static List<Product> GetProductsLinq(List<Product> products)
		{
			return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStok > 3).ToList();  //arka planda yeni liste oluşturup ona ekliyor //döngü - şart aynı anda
		}
		
	}

	class Product
	{
        public int ProductId { get; set; }
		public int CategoryId { get; set; }
        public string ProductName { get; set; }
		public string QuantityPerUnit { get; set; }
		public decimal UnitPrice { get; set; }
		public int UnitsInStok { get; set; }

    }

	class Category
	{
		public int CategoryId { get; set;}
		public string CategoryName { get; set; }

	}
}
