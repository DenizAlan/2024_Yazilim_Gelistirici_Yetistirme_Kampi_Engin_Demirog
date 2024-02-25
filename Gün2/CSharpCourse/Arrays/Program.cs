namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] students = new string[3];
			students[0] = "Deniz";
			students[1] = "Özlem";
			students[2] = "Hacer";

			string[] students2 = new[] { "Çagla", "Ayşe", "Fatma" };
			string[] students3 = { "Aslan", "Kaplan", "Kedi" };


            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
			Console.WriteLine();

			//Çok boyutlu diziler
			string[,] regions = new string[5, 3]  //5 satır 3 kolon demek
			{
				{ "İst","Bursa ","İzmit " } ,
				{ "Ankara ","Kayseri","Konya" } ,
				{ "Antalya","Adana","Mersin" } ,
				{ "Rize","Trabzon","Samsun" } ,
				{ "İzmir","Muğla","Manisa" } ,
			
			};

			// satırlar 0. dimension suturlar 1. dimension
			//her satır için 3 tanede sutun gezmem lazım
			for (int i = 0; i <= regions.GetUpperBound(0); i++)
			{
				for (int j = 0; j <= regions.GetUpperBound(1); j++)
				{
					Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("************");
            }

			Console.ReadLine();
        }
	}
}
