using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class PersonManager : IApplicantService
	{
		//encapsulation
		public void ApplyForMask(Person person)
		{

		}

		public List<Person> GetList()
		{
			return null;
		}

		public bool CkeckPerson(Person person)
		{
			return true;
		}


	}


}
