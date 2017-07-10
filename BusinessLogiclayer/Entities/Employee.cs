using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.BusinessLogicLayer.Entities
{
	/// <summary>
	/// Class for employees
	/// </summary>
	public class Employee : AllUser
	{
		int Id;
		String Name;
		
		public Employee(int EmployeeId, String EmployeeName)
		{
			Id = EmployeeId;
			Name = EmployeeName;
		}
		public string getName()
		{
			return Name;
		}
		public int getId()
		{
			return Id;
		}	

		public override double CalculateDiscount(Bill bill)
		{
			double EmployeeDiscountRate = 30;
			double DiscountAmount = 0;
			DiscountAmount = (EmployeeDiscountRate / 100) * bill.Amount;
			return DiscountAmount;
		}
	}
}
