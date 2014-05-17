using System;
using System.Text;

namespace Comp2614Midterm
{
	public class GroceryItem : IComparable<GroceryItem>
	{
		public static string FORMAT = "{0,-32}{1,9:N2}   {2,-16}\n";
		private string description;

		public string Description {
			get{ return description; }
		}

		public decimal Price { get; set; }

		private DateTime expirationDate;

		public DateTime ExpirationDate 
		{
			get {return expirationDate;}
		}

		public GroceryItem (string description, decimal price)
		{
			setDescriptionAndPrice (description, price);
			expirationDate = DateTime.MaxValue;
		}

		public GroceryItem (string description, decimal price, int expirationYear, int expirationMonth, int  expirationDay)
		{
			setDescriptionAndPrice (description, price);
			expirationDate = new DateTime (expirationYear, expirationMonth, expirationDay);


		}


		private void setDescriptionAndPrice(string description, decimal price)
		{
			this.description = description;
			this.Price = price;
		}

		//Sort by descending price
		public int CompareTo (GroceryItem otherGroceryItem)
		{
			if (this.Price > otherGroceryItem.Price)
			{
				return -1;
			} else if (this.Price < otherGroceryItem.Price)
			{
				return 1;
			} else
			{
				return 0;
			}
		}

		public string FormatForConsole ()
		{
			StringBuilder itemDisplay = new StringBuilder (1000);

			itemDisplay.AppendFormat (FORMAT, description, Price, DisplayExpiration ());

			return itemDisplay.ToString ();

		}

		public string DisplayExpiration ()
		{
			if (expirationDate.Equals (DateTime.MaxValue))
			{
				return "<Never>";
			} 
			else
			{
				return expirationDate.ToString ("ddd MMM d, yyyy");
			}
		}
	}
}





