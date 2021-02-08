using System;

namespace CashRegister_swt
{
	class Program
	{
		static void Main(string[] args)
		{
			Register reg = new Register();

			reg.AddItem(22.55);

			System.Console.WriteLine("Register indeholder nu {0} vare til {1} kr. ",
				reg.GetNoOfItems(), reg.GetTotal()); // Test Git
		}
	}
}
