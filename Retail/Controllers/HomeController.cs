using System.Web.Mvc;
using Retail.BusinessLogicLayer.Entities;

namespace Retail.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		public double UserDiscount()
		{
			User User1 = new AllUser();
			User1.SetUser(User1);
			
			// Generate and process purchase requests
			int BillNumber = 1234;
			double BillAmount = 990.85;
			string BillItems = "Non-Grocery";
			System.DateTime Billdate = System.DateTime.Now;

			Bill bill = new Bill(BillNumber, BillAmount, BillItems, Billdate);
			return User1.CalculateDiscount(bill);
			
		}

		public double CustomerDiscount()
		{
			User Cust1 = new Customer(1, "Customer 1");

			Cust1.SetUser(Cust1);
			int BillNumber = 1234;
			double BillAmount = 990.85;
			string BillItems = "Non-Grocery";
			System.DateTime Billdate = System.DateTime.Now;

			Bill bill = new Bill(BillNumber, BillAmount, BillItems, Billdate);

			return Cust1.CalculateDiscount(bill);
		}

		public double AffiliateDiscount()
		{
			
			User Aff1 = new Affiliate(1, "Affiliate 1");
			
			Aff1.SetUser(Aff1);
			
			int BillNumber = 1234;
			double BillAmount = 990.85;
			string BillItems = "Non-Grocery";
			System.DateTime Billdate = System.DateTime.Now;

			Bill bill = new Bill(BillNumber, BillAmount, BillItems, Billdate);

			return Aff1.CalculateDiscount(bill);
		}

		public double EmployeeDiscount()
		{
			
			User Emp1 = new Employee(1, "Employee 1");

			Emp1.SetUser(Emp1);
			int BillNumber = 1234;
			double BillAmount = 990.85;
			string BillItems = "Non-Grocery";
			System.DateTime Billdate = System.DateTime.Now;

			Bill bill = new Bill(BillNumber, BillAmount, BillItems, Billdate);

			return Emp1.CalculateDiscount(bill);
			
		}
	}
}