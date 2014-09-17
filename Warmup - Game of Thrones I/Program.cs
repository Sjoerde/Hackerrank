using System;
using System.Linq;

internal class Solution
{
	private static void Main(String[] args)
	{
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		string line = Console.ReadLine();

		var chars = line.ToCharArray().GroupBy(c => c).Select(g => new {g.Key, Count = g.Count()});
		if (chars.Count(c => c.Count%2 == 1) > 1)
		{
			Console.WriteLine("NO");
		}
		else
		{
			Console.WriteLine("YES");
		}
	}
}