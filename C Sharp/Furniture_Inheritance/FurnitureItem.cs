public class FurnitureItem
{
	public string ItemName { get; set; }
	public double Price { get; set; }
	public string Material { get; set; }

	public FurnitureItem(string itemName, double price, string material)
	{
		ItemName = itemName;
		Price = price;
		Material = material;
	}

	public override string ToString()
	{
		return $"Furniture Item: {ItemName}\tMaterial: {Material}\tPrice: ${Price}";
	}
}