namespace Strings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//StringIntro();
			string sentence = "My name is Deniz Alan";

			var result = sentence.Length; // kaç karakterden oluştugunu verir
			var result2= sentence.Clone();
			sentence = "My name is Çağla";

			bool result3= sentence.EndsWith(" ğ"); //bu cümle ğ ile bitiyormu
			bool result4= sentence.StartsWith("My name"); //bu cümle My name ile bitiyormu

			var result5 = sentence.IndexOf("namee"); //Sentence içinde name i arar başlama indexini verir //bulamassa -1 verir
			var result6 = sentence.IndexOf(" "); //boşlugu arar buldugu ilk indexin boşlugunu verir
			var result7=sentence.LastIndexOf(" "); //aramaya sondan başlar
			var result8 = sentence.Insert(0, " Hello "); // string ifadeye başka birşey eklemek için
			var result9 = sentence.Substring(3,4); // ifadeyi parçalar
			var result10= sentence.ToLower();
			var result11= sentence.ToUpper();
			var result12= sentence.Replace(" ","-"); // ifade içinde belli karakterleri değiştirmek için
			var result13 = sentence.Remove(2,5); // çıkartmak için 
            Console.WriteLine(result);


            Console.ReadLine();
		}

		private static void StringIntro()
		{
			string city = "İstanbul";
			Console.WriteLine(city[0]);

			foreach (var item in city)
			{
				Console.WriteLine(item);
			}

			string city2 = "Edirne";
			string result = city + city2;
			Console.WriteLine(result);

			Console.WriteLine(String.Format("{0}  {1}", city, city2));
		}
	}
}
