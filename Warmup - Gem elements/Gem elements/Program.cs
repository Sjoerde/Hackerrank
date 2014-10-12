using System;
using System.Collections.Generic;
using System.Linq;

namespace Gem_elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			IList<string> rocks = new List<string>();
			for (int i = 0; i < n; i++)
			{
				rocks.Add(Console.ReadLine());
			}
			Console.WriteLine(SieveRocks(rocks));
		}

		private static int SieveRocks(IList<string> rocks)
		{
			var elements = rocks[0].ToCharArray().ToList().Distinct();
			elements = rocks.Select(rock => rock.ToCharArray().ToList().Distinct())
				.Aggregate(elements, (current, currentElements) => current.Intersect(currentElements));
			return elements.Count();
		}
	}
}
