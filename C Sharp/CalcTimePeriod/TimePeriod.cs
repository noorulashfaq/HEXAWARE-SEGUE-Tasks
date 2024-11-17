public class TimePeriod
{
	private int _seconds;

	public double Hours
	{
		get
		{
			return _seconds / 3600.0;
		}
		set
		{
			_seconds = (int)(value * 3600);
		}
	}

	public void DisplayTime()
	{
		Console.WriteLine($"Time in hours: {Hours} hours");
		Console.WriteLine($"Time in seconds: {_seconds} seconds");
	}
}
