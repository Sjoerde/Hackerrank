using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_lane
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine();
            var parameters = line1.Split(' ').Select(i => int.Parse(i.Trim())).ToArray();
            string lane = CalculateServiceLane(parameters[0]);
            var testCases = new List<List<int>>();
            for (int i = 0; i < parameters[1]; i++)
            {
                testCases.Add(Console.ReadLine().Split(' ').Select(c => int.Parse(c.Trim())).ToList());
            }
            foreach (var testCase in testCases)
            {
                Console.WriteLine(CalculateLargestVehicle(lane, testCase));
            }
            Console.ReadKey();
        }

        private static int CalculateLargestVehicle(string lane, List<int> testCase)
        {
            var subLane = lane.Substring(testCase[0], testCase[1] - testCase[0] + 1);
            return subLane.ToCharArray().Select(c => int.Parse(c.ToString())).Min();
        }

        private static string CalculateServiceLane(int length)
        {
            var line = Console.ReadLine();
            var lane = line.Replace(" ", "");
            return lane;
        }
    }
}
