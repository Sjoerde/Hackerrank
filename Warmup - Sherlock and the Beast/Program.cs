using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = int.Parse(Console.ReadLine());
        var tests = new List<int>();
        for (int i = 0; i < T; i++)
        {
            tests.Add(int.Parse(Console.ReadLine()));
        }
        foreach (int test in tests)
        {
            Console.WriteLine(CalculateBeast(test));
        }
        Console.ReadLine();
    }

    private static string CalculateBeast(int test)
    {
        int nr3s = 0;
        while (nr3s < test) 
        {
            if ((test - nr3s) % 3 == 0)
            {
                var result = Enumerable.Repeat("5", test - nr3s).ToList();
                result.AddRange(Enumerable.Repeat("3", nr3s));
                return string.Join("", result.ToArray());
            }
            nr3s += 5;
        }
        if (nr3s == test)
        {
            return string.Join("", Enumerable.Repeat("3", nr3s).ToArray());
        }
        return "-1";
    }
}