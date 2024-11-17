using System;

namespace Furniture_Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter details for Bookshelf:");

			Console.Write("Enter item name: ");
			string bookshelfName = Console.ReadLine();
			Console.Write("Enter price: ");
			double bookshelfPrice = double.Parse(Console.ReadLine());
			Console.Write("Enter material: ");
			string bookshelfMaterial = Console.ReadLine();
			Console.Write("Enter number of shelves: ");
			int numberOfShelves = int.Parse(Console.ReadLine());

			FurnitureItem bookshelf = new Bookshelf(bookshelfName, bookshelfPrice, bookshelfMaterial, numberOfShelves);
			Console.WriteLine("\nBookshelf Details:");
			Console.WriteLine(bookshelf);
			Console.WriteLine();

			Console.WriteLine("Enter details for Chair:");

			Console.Write("Enter item name: ");
			string chairName = Console.ReadLine();
			Console.Write("Enter price: ");
			double chairPrice = double.Parse(Console.ReadLine());
			Console.Write("Enter material: ");
			string chairMaterial = Console.ReadLine();
			Console.Write("Enter number of legs: ");
			int numberOfLegs = int.Parse(Console.ReadLine());
			Console.Write("Enter cushion material: ");
			string cushionMaterial = Console.ReadLine();

			FurnitureItem chair = new Chair(chairName, chairPrice, chairMaterial, numberOfLegs, cushionMaterial);
			Console.WriteLine("\nChair Details:");
			Console.WriteLine(chair);
		}
	}
}
