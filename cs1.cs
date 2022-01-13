// What is the output of the short program below? Explain your answer.
using System;
public class Program
{
	static string location = default(string);
	static DateTime time = default(DateTime);
	
	public static void Main()
	{
		Console.WriteLine(location == null ? "location is null" : location);
		Console.WriteLine(time == DateTime.MinValue ? "time is MinValue" : time.ToString());
	}
}
