using System;
using System.Collections.Generic;

namespace Comp2614Midterm
{
	public class GroceryItemCollection : List<GroceryItem>
	{
		private decimal totalPrice;
		public decimal TotalPrice 
		{
			get{ return totalPrice; }
		}


		public GroceryItemCollection ()
		{
		}

		private void updateTotalPrice()
		{
			totalPrice = 0m;
			foreach (GroceryItem item in this)
			{
				totalPrice += item.Price;
			}
		}

	}
}

//Define a class named GroceryItemCollection (derived from List<GroceryItem>) in a separate source file
//
//Implement the following public property method in class GroceryItemCollection:
//
//TotalPrice (read-only)