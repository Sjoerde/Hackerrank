using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public static int NumberOfSquares(int left, int right)
    {
        int squareLeft = (int)Math.Ceiling(Math.Sqrt(left));
        int squareRight = (int)Math.Floor(Math.Sqrt(right));
        return squareRight - squareLeft + 1;
    }

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = int.Parse(Console.ReadLine());

        var tests = new List<Tuple<int, int>>();
        for (int i = 0; i < T; i++)
        {
            var line = Console.ReadLine().Split(' ');
            tests.Add(new Tuple<int, int>(int.Parse(line[0].Trim()), int.Parse(line[1].Trim())));
        }

        foreach (var test in tests)
        {
            Console.WriteLine(NumberOfSquares(test.Item1, test.Item2));
        }
    }
}