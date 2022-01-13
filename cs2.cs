// Given a collection of  objects - aMyCollection. 
//implement function printAllItemsToConsole
//Print all elements without using foreach
using System.Collections.Generic;

public class Program
{

	public static void Main()
	{
            var aMyCollection = new List<int>(){ 10, 25, 34, 17, 28, 36, 67 };
            //printAllItemsToConsole(...)
	}

	public static void printAllItemsToConsole<T>(IEnumerable<T> itemCollection)
    {
//...
    }

}
