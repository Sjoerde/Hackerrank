using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IList<int> cycles = new List<int>();
            for (int i = 0; i < n; i++) 
            {
                cycles.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int nrCycles in cycles) 
            {
                Console.WriteLine(CalculateLength(nrCycles));
            }
        }

        private static int CalculateLength(int nrCycles)
        {
            int length = 1;
            for (int cycle = 1; cycle <= nrCycles; cycle++)
            {
                if (cycle % 2 == 1)
                {
                    length *= 2;
                }
                else
                {
                    length += 1;
                }
            }
            return length;
        }
    }
}
