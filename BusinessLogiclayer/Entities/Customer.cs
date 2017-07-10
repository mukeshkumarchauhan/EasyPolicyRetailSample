using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.BusinessLogicLayer.Entities
{
	/// <summary>
	/// class for customers
	/// </summary>
	public class Customer : AllUser
	{
		int Id;
		String Name;
		
		public Customer(int CustomerId, String CustName)
		{
			Id = CustomerId;
			Name = CustName;
		}
		public string getName()
		{
			return Name;
		}
		public int getId()
		{
			return Id;
		}

		public double getCustomerSinceDays(DateTime CustomerSince)
		{
			return 800;
			//return (DateTime.Now - CustomerSince).TotalDays;
		}
		public override double CalculateDiscount(Bill bill)
		{
			double CustomerDiscountRate = 5;
			double DiscountAmount = 0;
			int CustomerYears = (int)getCustomerSinceDays(bill.BillDate) / 365;
			if (CustomerYears >= 2)
			{
				DiscountAmount = (CustomerDiscountRate / 100) * bill.Amount;
			}
			return DiscountAmount;
		}
	}
}
