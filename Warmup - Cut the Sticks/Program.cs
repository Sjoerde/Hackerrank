using System;
using System.Collections.Generic;
using System.Linq;

internal class Solution
{
	private static void Main(String[] args)
	{
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int N = int.Parse(Console.ReadLine());
		var ais = Console.ReadLine();
		IList<int> sticks = new List<int>();
		ais.Split(' ').ToList().ForEach(i => sticks.Add(int.Parse(i.Trim())));
		CutTheSticks(sticks.Take(N).Where(i => i > 0).ToList());
		Console.ReadKey();
	}

	private static void CutTheSticks(List<int> sticks)
	{
		while (sticks.Any())
		{
			Console.WriteLine(sticks.Count());
			int min = sticks.Min();
			var newSticks = new List<int>();
			sticks.ForEach(s => newSticks.Add(s - min));
			sticks = newSticks.Where(s => s > 0).ToList();
		}
	}
}