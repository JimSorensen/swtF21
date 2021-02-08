using System;
using CashRegister_swt;
using NUnit.Framework;
using static NUnit.Framework.Throws;

namespace CashRegister.Test.Unit
{
	[TestFixture]
	public class RegisterTests
	{
		private Register uut;

		[SetUp]
		public void Setup()
		{
			uut = new Register();
		}

		[Test]
		public void AddItem_OneItem_NoOfItemsIs1()
		{
			//Arrange

			//Act
			uut.AddItem(12.50);

			//Assert
			Assert.That(uut.GetNoOfItems(), Is.EqualTo(1));
		}

		[Test]
		public void AddItem_OneItem_TotalIsCorrect()
		{
			//Arrange

			//Act
			uut.AddItem(13.45);

			//Assert
			Assert.That(uut.GetTotal(), Is.EqualTo(13.45));
		}

		[Test]
		public void AddItem_NegativeItem_Throws()
		{
			//Act + Assert
			Assert.That(code: () => uut.AddItem(-10),
				constraint: Throws.TypeOf<ArgumentOutOfRangeException>());
		}
	}
}