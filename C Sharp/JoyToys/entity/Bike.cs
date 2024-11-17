namespace JoyToys.entity
{
	internal class Bike
	{
		#region Traditional getter and setter methods
		//private int bikeId;
		//private string name;

		//public int GetBikeId()
		//{
		//	return bikeId;
		//}
		//public void SetId(int value)
		//{
		//	bikeId = value;
		//}

		//public int BikeId
		//{
		//	get { return bikeId; }
		//	set
		//	{
		//		if(value >= 0)
		//		{
		//			bikeId = value
		//		}
		//	}
		//}
		#endregion

		public int BikeId { get; set; }
		public string BikeName { get; set; }
		public string BikeType { get; set; }
		public double Price { get; set; }

		public Bike(int id, string name, string type, double price)
		{
			BikeId = id;
			BikeName = name;
			BikeType = type;
			Price = price;
		}

		private List<Bike> bikeList = new List<Bike>();

		public void AddBike(int id, string name, string type, double price)
		{
			Bike newBike = new Bike(id, name, type, price);
			bikeList.Add(newBike);
		}

		public void DisplayAllBikes()
		{
			if (bikeList.Count == 0)
			{
				Console.WriteLine("No bikes available.");
				return;
			}

			Console.WriteLine("---------- Bike Inventory ----------");
			foreach (var bike in bikeList)
			{
				Console.WriteLine(bike);
			}
		}

		public override string ToString()
		{
			return $"ID: {BikeId}\tName: {BikeName}\tType: {BikeType}\tPrice: {Price}";
		}
	}
}
