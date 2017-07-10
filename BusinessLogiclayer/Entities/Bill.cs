using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.BusinessLogicLayer.Entities
{
	/// <summary>
	///  Bill Class
	/// </summary>
	public class Bill
	{
		private int _number;
		private double _amount;
		private string _item;
		private DateTime _billDate;

		// Constructor
		public Bill(int number, double amount, string purpose, DateTime billdate)
		{
			this._number = number;
			this._amount = amount;
			this._item = purpose;
			this._billDate = billdate;
		}

		// Gets or sets bill number
		public int Number
		{
			get { return _number; }
			set { _number = value; }
		}

		// Gets or sets bill amount
		public double Amount
		{
			get { return _amount; }
			set { _amount = value; }
		}

		// Gets or sets Itme type
		public string ItemType
		{
			get { return _item; }
			set { _item = value; }
		}
		public DateTime BillDate
		{
			get { return _billDate; }
			set { _billDate = value; }
		}
	}
}