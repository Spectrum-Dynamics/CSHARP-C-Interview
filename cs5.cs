// What is the output of the program below? Explain your answer.
public class Program
{
	public static void Main()
	{
		var printers = new List<Action>();
		var i = 0;
		
		for (i = 0; i < 10; i++)
		{
			printers.Add(() => Console.WriteLine(i));
		}

		foreach (var printer in printers)
		{
			printer();
		}
	}
}