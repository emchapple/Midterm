using NUnit.Framework;
using System;

namespace Comp2614Midterm
{
	[TestFixture ()]
	public class GroceryItemTests
	{

		private GroceryItem item;


		[SetUp ()]

		public void Init()
		{
			item = new GroceryItem ("4L Milk", 3.87m, 2013, 2, 22);
		}

		[Test ()]
		public void CheckDisplay ()
		{
			string display = item.FormatForConsole ();
			string shouldBe = "4L Milk             3.87    Fri Feb 22 2013\n";
			Assert.AreEqual (shouldBe, display);

		}

		[Test ()]
		public void CheckNoExpiry()
		{
			item = new GroceryItem ("Indestructable soup", 0.99m);
			string shouldBe = "<Never>";
			Assert.AreEqual (shouldBe, item.DisplayExpiration ());

		}



		[Test ()]
		public void CheckNormalExpiry()
		{
			string shouldBe = "Fri Feb 22, 2013";
			Assert.AreEqual (shouldBe, item.DisplayExpiration ());
		}







	}
}

