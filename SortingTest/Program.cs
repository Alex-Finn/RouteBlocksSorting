using System;
using SortLib;

namespace SortTest
{
	class Program
	{
		static void Main( string[] args )
		{
			RouteBlock<string>[] testArray = new RouteBlock<string>[]
			{
				new RouteBlock<string>("1","2"),
				new RouteBlock<string>("3","4"),
				new RouteBlock<string>("0","1"),
				new RouteBlock<string>("5","6"),
				new RouteBlock<string>("2","3"),
				new RouteBlock<string>("6","7"),
				new RouteBlock<string>("4","5"),
				new RouteBlock<string>("8","9"),
				new RouteBlock<string>("7","8")
			};

			Console.WriteLine("Input Array: ");
			foreach ( var item in testArray )
			{
				Console.Write($"{item.Input}\t{item.Output}\n");
			}

			var sortedArray = Sorting<string>.GetSortedRouteBlocks(testArray);

			Console.WriteLine("Sorted Array: ");
			foreach ( var item in sortedArray )
			{
				Console.Write($"{item.Input}\t{item.Output}\n");
			}

			Console.ReadKey();
		}
	}
}
