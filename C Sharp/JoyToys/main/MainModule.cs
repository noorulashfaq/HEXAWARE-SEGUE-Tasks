using JoyToys.entity;

namespace JoyToys.main
{
	internal class MainModule
	{
		public void Run()
		{
			Bike b = new Bike(0, "", "", 0);
			while(true)
			{
                Console.WriteLine("-------------------------------------------------------");
				Console.WriteLine("Menu: \n1. Add new bike\n2. Display all bikes\n3. Exit");
                Console.WriteLine("Enter your choice:");
				int choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Console.WriteLine("Please enter the following details to add a new bike");
						Console.WriteLine("Enter bike id:");
						int id = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter bike name:");
						string name = Console.ReadLine();
						Console.WriteLine("Enter type:");
						string type = Console.ReadLine();
						Console.WriteLine("Enter price:");
						double price = double.Parse(Console.ReadLine());

						b.AddBike(id, name, type, price);
						Console.WriteLine("Bike added successfully");
						break;

					case 2:
						b.DisplayAllBikes();
						break;

					case 3:
                        Console.WriteLine("Exiting.....");
						break;

					default:
						Console.WriteLine("Invalid choice");
						break;
				}
				if (choice == 3)
				{
					break;
				}
			}

		}
	}
}
