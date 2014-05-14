using System;

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