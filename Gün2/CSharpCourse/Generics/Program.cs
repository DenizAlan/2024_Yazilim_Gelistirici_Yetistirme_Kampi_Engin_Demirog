namespace Generics
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Generic class
			List<string> sehirler = new List<string>();  //newlwdiğin an eleman sayısı 0 dır
			sehirler.Add("İstanbul");
			sehirler.Add("İstanbul");
			sehirler.Add("İstanbul");
			Console.WriteLine(sehirler.Count);


			// Aşagıda mylist i generic yapıda yaptık
			MyList<string> sehirler2 = new MyList<string>();
			sehirler2.Add("Bursa");
			sehirler2.Add("Bursa");
			sehirler2.Add("Bursa");
			sehirler2.Add("Bursa");
			sehirler2.Add("Bursa");
			Console.WriteLine(sehirler2.Count);
		}  
	}

	class MyList <T>  // bu artık bir Generic class // T kullanırken yukarıda hangi tip verdiysen onu ifade eder
	{
		T[] _array;
		T[] _tempArray; // geçici array

        public MyList()
        {
            _array = new T[0]; //0 elemanlı array yaptık
        }
        public void Add(T item)
        {
			_tempArray = _array;   // temparray arrayın referansını yani adresini tutuyor datalar kaybolmasın diye
			_array =new T[_array.Length+1];  // eleman ekledikçe array sayısı 1 artar , bu durumda referans degeri degişir
			for (int i = 0; i < _tempArray.Length; i++)
			{
				_array[i] = _tempArray[i]; // geçici arrayda tuttugumuz verileri yeni referansdaki arrayımıza yolluyoruz
			}
			_array[_array.Length-1] = item; // yeni itemimizi arayımızın sonuna ekler
        }

		public int Count
		{
			get { return _array.Length; }
			//set { _count = value; }
		}

	}
}
