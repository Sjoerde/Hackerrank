using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    /*
     * Complete the function below.
     */
    static int maxXor(int l, int r)
    {
        return Enumerable.Range(l, r - l + 1).SelectMany(i => Enumerable.Range(l, r - l + 1).Select<int, int>(j => i ^ j)).Max();
    }

    static void Main(String[] args)
    {
        int res;
        int _l;
        _l = Convert.ToInt32(Console.ReadLine());

        int _r;
        _r = Convert.ToInt32(Console.ReadLine());

        res = maxXor(_l, _r);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
