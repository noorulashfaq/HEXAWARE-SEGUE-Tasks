namespace CalcPrice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the price: ");
			int price = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the quantity: ");
			int quantity = int.Parse(Console.ReadLine());
			double totalAmount = price * quantity;
			if (totalAmount > 50000)
			{
				totalAmount -= totalAmount / 10;
			}
			totalAmount += totalAmount * 0.18;
			Console.WriteLine($"The total amount is {totalAmount} incl. GST");
		}
	}
}
