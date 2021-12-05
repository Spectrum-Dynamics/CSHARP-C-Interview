// What is the output of the short program below? Explain your answer.

using System;

public class Program
{
	public static void Main()
	{
		try
		{
			throw new Exception("Exception 1");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}

		try
		{
			throw new ApplicationException("Exception 2");
		}
		catch (ApplicationException)
		{
			Console.WriteLine("ApplicationException 2");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			Console.WriteLine("Finally");
		}
	}
}