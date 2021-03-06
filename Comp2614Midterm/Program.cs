﻿using System;

namespace Comp2614Midterm
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			GroceryItemCollection inventory = new GroceryItemCollection ();

			createInventory (inventory);
			Console.WriteLine ("Natural Order:");
			Console.WriteLine(inventory.FormatCollection ());

			Console.WriteLine ("\nSorted Order: [Price Descending]");
			inventory.Sort ();
			Console.WriteLine(inventory.FormatCollection ());



		}


		private static void createInventory(GroceryItemCollection inventory)
		{
			GroceryItem item1 = new GroceryItem ("4L Milk", 3.87m, 2013, 2, 22);
			GroceryItem item2 = new GroceryItem ("500g Cottage Cheese", 4.28m, 2013, 2, 26);
			GroceryItem item3 = new GroceryItem ("1 Tin Mushroom Soup", 0.99m);
			GroceryItem item4 = new GroceryItem ("15kg Dog Food", 29.99m, 2016, 12, 7);

			inventory.Add (item1);
			inventory.Add (item2);
			inventory.Add (item3);
			inventory.Add (item4);


		}

	}
}
