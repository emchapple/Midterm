﻿using System;
using System.Text;


namespace Comp2614Midterm
{
	public class GroceryItem : IComparable<GroceryItem>
	{

		private string description;
		public string Description 
		{
			get{ return description; }
		}

		public decimal Price { get; set; }

		private DateTime expirationDate;
		public DateTime ExpirationDate {
			get 
			{
				return expirationDate;
			}
		}


		public GroceryItem (string description, decimal price, int expirationYear , int expirationMonth, int  expirationDay)
		{
			this.description = description;
			this.Price = price;

			expirationDate = new DateTime (expirationYear, expirationMonth, expirationDay);

		}

		public int CompareTo(GroceryItem otherGroceryItem)
		{
			if (this.Price > otherGroceryItem.Price)
			{
				return 1;
			} else if (this.Price < otherGroceryItem.Price)
			{
				return -1;
			} else
			{
				return 0;
			}
		}

		public string FormatForConsole()
		{
			StringBuilder itemDisplay = new StringBuilder (1000);

			itemDisplay.AppendFormat ("{0,-30}{1,5:N2}   {2}\n", description, Price, expirationDate.ToString("ddd MMM dd, yyyy"));


			return itemDisplay.ToString ();

		}



	}
}
//
//Description (read-only) 
//Price (read-write) 
//ExpirationDate (read-only)
//
//Include the necessary code to support sorting by Price descending
//
//Declare class GroceryItem's ExpirationDate as a DateTime type