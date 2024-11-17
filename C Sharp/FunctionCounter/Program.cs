public class Program
{
	static void Main(string[] args)
	{
		CountFunction();
		CountFunction();
		CountFunction();
		Console.ReadLine();
	}

	private static int count = 0;

	public static void CountFunction()
	{
		count++;
		Console.WriteLine($"The function has been called {count} times.");
	}

}
