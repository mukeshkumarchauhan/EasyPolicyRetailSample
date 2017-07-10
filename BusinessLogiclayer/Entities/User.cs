using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.BusinessLogicLayer.Entities
{
	public abstract class User
		{
			protected User user;
			public void SetUser(User user)
			{
				this.user = user;
			}
			public abstract double CalculateDiscount(Bill bill);
		}
}