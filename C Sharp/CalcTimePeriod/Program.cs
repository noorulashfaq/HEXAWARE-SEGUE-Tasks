namespace CalcTimePeriod
{
	
	public class Program
	{
		public static void Main()
		{
			TimePeriod time = new TimePeriod();

			Console.WriteLine("Enter hours:");
			time.Hours = int.Parse(Console.ReadLine()); ;
			time.DisplayTime();

			Console.ReadLine();
		}
	}

}