using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	public class Customer
	{
		//Property
        public int Id { get; set; }

		//Field
		private string _firstName;
		public string FirstName
		{
			get
			{
				return "Mr. "+ _firstName;

			}
			set
			{
				_firstName = value;

			}
		}
		public string LastName { get; set; }

		public string Address { get; set; }
    }
}
