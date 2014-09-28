using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = int.Parse(Console.ReadLine());
        var tests = new List<Tuple<int, int, int>>();
        for (int i = 0; i < T; i++)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            tests.Add(new Tuple<int, int, int>(n, a, b));
        }
        foreach (var test in tests)
        {
            var solutions = CalculateTest(test.Item1, test.Item2, test.Item3);
            solutions = solutions.Distinct().OrderBy(k => k).ToList();
            string line = string.Join(" ", solutions);
            Console.WriteLine(line);
        }
        Console.ReadKey();
    }

    private static IList<int> CalculateTest(int n, int a, int b)
    {
        var list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            list.Add(i * a + (n-1 - i) * b); 
        }
        return list;
    }
}