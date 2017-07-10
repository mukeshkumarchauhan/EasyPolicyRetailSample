using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.BusinessLogicLayer.Entities
{
	/// <summary>
	/// class for All users
	/// </summary>
	public class AllUser : User
	{
		public override double CalculateDiscount(Bill bill)
		{
			int Discount = 5;
			int DiscountAmount = 0;
			DiscountAmount = ((int)(bill.Amount / 100)) * Discount;
			return DiscountAmount;
		}
	}
}
