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
        var testcases = new List<List<int>>();
        for (int i = 0; i < T; i++)
        {
            int N = int.Parse(Console.ReadLine());
            testcases.Add(new List<int>(Console.ReadLine().Split(' ').ToList().Select(s => int.Parse(s))));
        }
        foreach (var test in testcases) 
        {
            if (ExecuteTest(test))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        Console.ReadKey();
    }

    private static bool ExecuteTest(List<int> test)
    {
        int gcd = GCD(test.ToArray());
        if (gcd > 1)
        {
            return false;
        }
        return true;
    }

    static int GCD(int[] numbers)
    {
        return numbers.Aggregate(GCD);
    }

    static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}