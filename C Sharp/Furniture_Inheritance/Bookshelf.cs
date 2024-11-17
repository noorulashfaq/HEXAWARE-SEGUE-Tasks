public class Bookshelf : FurnitureItem
{
	public int NumberOfShelves { get; set; }
	
	public Bookshelf(string itemName, double price, string material, int numberOfShelves)
		: base(itemName, price, material)
	{
		NumberOfShelves = numberOfShelves;
	}
	public override string ToString()
	{
		return base.ToString() + $"\tNumber of Shelves: {NumberOfShelves}";
	}
}