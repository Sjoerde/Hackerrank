using System;
using System.Collections.Generic;

internal class Solution
{
	static void Main(string[] args)
	{
		int T = int.Parse(Console.ReadLine());
		var cases = new List<char[]>();
		for (int i = 0; i < T; i++)
		{
			cases.Add(Console.ReadLine().ToCharArray());
		}
		foreach (var aCase in cases)
		{
			Console.WriteLine(MakePalindrome(aCase));
		}
		Console.ReadKey();
	}

	private static int MakePalindrome(char[] s)
	{
		int half = s.Length/2;
		int count = 0;
		for (int i = 0; i < half; i++)
		{
			count += Math.Abs((int) s[i] - (int) s[s.Length - 1 - i]);
		}
		return count;
	}
}