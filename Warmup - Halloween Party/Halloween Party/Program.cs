using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
	static void Main(String[] args)
	{
		int T = int.Parse(Console.ReadLine());
		var cases = new List<int>();
		for (int i = 0; i < T; i++)
		{
			cases.Add(int.Parse(Console.ReadLine()));
		}
		foreach (var slices in cases)
		{
			Console.WriteLine(CalculateBlocks(slices));
		}
	}

	private static long CalculateBlocks(int slices)
	{
		long highest = 0;

		int half = slices/2;
		for (int i = 1; i <= half; i++)
		{
			long sum = (long)i*(slices - i);
			if (sum > highest)
			{
				highest = sum;
			}
		}
		return highest;
	}
}