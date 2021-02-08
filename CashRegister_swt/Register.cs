using System;
using System.Collections.Generic;
using System.Text;

namespace CashRegister_swt
{
	public class Register
	{
		public int NoOfItems { get; set; }

		private double _total;

		public Register()
		{
			_total = 0.0;
			NoOfItems = 0;
		}

		public void AddItem(double itemPrice)
		{
			if (itemPrice < 0)
				throw new ArgumentOutOfRangeException(paramName: "Prisen er mindre end null");

			_total += itemPrice;
			NoOfItems++;
		}

		public double GetTotal()
		{
			return _total;
		}

		public int GetNoOfItems()
		{
			return NoOfItems;
		}
	}
}
