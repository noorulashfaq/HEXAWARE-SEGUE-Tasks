public class Chair : FurnitureItem
{
	public int NumberOfLegs { get; set; }
	public string CushionMaterial { get; set; }

	public Chair(string itemName, double price, string material, int numberOfLegs, string cushionMaterial)
		: base(itemName, price, material)
	{
		NumberOfLegs = numberOfLegs;
		CushionMaterial = cushionMaterial;
	}

	public override string ToString()
	{
		return base.ToString() + $"\tNumber of Legs: {NumberOfLegs}\tCushion Material: {CushionMaterial}";
	}
}