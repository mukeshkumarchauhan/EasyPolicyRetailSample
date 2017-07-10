using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Retail;
using Retail.Controllers;

namespace Retail.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{
		[TestMethod]
		public void IndexTest()
		{
			HomeController controller = new HomeController();

			ViewResult result = controller.Index() as ViewResult;
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void UserDiscountTest()
		{
			HomeController controller = new HomeController();
			double discount = controller.UserDiscount();
			Assert.AreEqual(45.00, Math.Round(discount, 2));
		}

		[TestMethod]
		public void CustomerDiscountTest()
		{
			HomeController controller = new HomeController();
			double discount = controller.CustomerDiscount();
			Assert.AreEqual(49.54, Math.Round(discount, 2));
		}

		[TestMethod]
		public void AffiliateDiscountTest()
		{
			HomeController controller = new HomeController();
			double discount = controller.AffiliateDiscount();
			Assert.AreEqual(99.08, Math.Round(discount, 2));
		}


		[TestMethod]
		public void EmployeeDiscountTest()
		{
			HomeController controller = new HomeController();
			double discount = controller.EmployeeDiscount();
			Assert.AreEqual(297.26, Math.Round(discount, 2));
		}
	}
}
