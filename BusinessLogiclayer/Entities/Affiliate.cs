using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.BusinessLogicLayer.Entities
{
	/// <summary>
	/// Class for Affiliates
	/// </summary>
	public class Affiliate : AllUser
	{
		int Id;
		String Name;

		public Affiliate(int AffiliateId, String AffiliateName)
		{
			Id = AffiliateId;
			Name = AffiliateName;
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
			double AffiliateDiscountRate = 10;
			double DiscountAmount = 0;
			DiscountAmount = (AffiliateDiscountRate / 100) * bill.Amount;
			return DiscountAmount;
		}
	}
}
