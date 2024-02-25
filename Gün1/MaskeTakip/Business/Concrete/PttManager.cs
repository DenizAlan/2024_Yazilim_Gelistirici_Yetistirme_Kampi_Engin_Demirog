using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class PttManager : ISupplierService
	{
		private IApplicantService _applicantService;

		public PttManager (IApplicantService applicantService) //constructor(oluştugunda) new yapıldıgında çalışır
		{
			_applicantService = applicantService;
		}
		public void GiveMask(Person person)
		{
			
			if (_applicantService.CkeckPerson(person)) 
			{
                Console.WriteLine(person.firstName + " için maske verildi");
            }
		}
	}
}
