using System;
using System.Collections.Generic;
using System.Text;

namespace Comp2614Midterm
{
	public class GroceryItemCollection : List<GroceryItem>
	{
		private decimal totalPrice;
		public decimal TotalPrice 
		{
			get{
				updateTotalPrice ();
				return totalPrice; }
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

		public string FormatAllItems()
		{
			StringBuilder allItems = new StringBuilder (5000);
			foreach (GroceryItem item in this)
			{
				allItems.Append (item.FormatForConsole ());
			}
			return allItems.ToString ();
		}
	
		public string FormatCollection()
		{
			string separator = new string('-', 60) + "\n";
			StringBuilder collection = new StringBuilder (8000);
			collection.AppendFormat (GroceryItem.FORMAT, "Grocery Item", "Price", "Expires");
			collection.Append (separator);
			collection.Append (FormatAllItems ());
			collection.Append (separator);
			collection.AppendFormat (GroceryItem.FORMAT, "Total:", TotalPrice, string.Empty);
			return collection.ToString ();
		}
	
	
	}



}

