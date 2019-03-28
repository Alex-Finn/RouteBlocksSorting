using System.Collections.Generic;
using System;
using SortLib;

namespace SortTest
{
	internal class Program
	{
		private static void Main( string[] args )
		{
			RouteBlock<string>[] testArray1 = new RouteBlock<string>[]
			{
				new RouteBlock<string>("Самара","Казань"),
				new RouteBlock<string>("Омск","Рязань"),
				new RouteBlock<string>("Казань","Москва"),
				new RouteBlock<string>("Пермь","Самара"),
				new RouteBlock<string>("Ижевск","Воронеж"),
				new RouteBlock<string>("Тамбов","Пермь"),
				new RouteBlock<string>("Тула","Ижевск"),
				new RouteBlock<string>("Москва","Омск"),
				new RouteBlock<string>("Рязань","Тула")
			};
						
			RouteBlock<int>[] testArray2 = new RouteBlock<int>[]
			{
				new RouteBlock<int>(5,6),
				new RouteBlock<int>(3,4),
				new RouteBlock<int>(7,8),
				new RouteBlock<int>(4,5),
				new RouteBlock<int>(1,2),
				new RouteBlock<int>(9,10),
				new RouteBlock<int>(2,3),
				new RouteBlock<int>(8,9),
				new RouteBlock<int>(6,7)
			};

			List<RouteBlock<int>> testList1 = new List<RouteBlock<int>>
			{
				new RouteBlock<int>(5,6),
				new RouteBlock<int>(3,4),
				new RouteBlock<int>(7,8),
				new RouteBlock<int>(4,5),
				new RouteBlock<int>(1,2),
				new RouteBlock<int>(9,10),
				new RouteBlock<int>(2,3),
				new RouteBlock<int>(8,9),
				new RouteBlock<int>(6,7)
			};

			#region Сортировка массива данных строкового типа
			Console.WriteLine("Input Array1: ");
			foreach ( var item in testArray1 )
			{
				Console.Write($"{item.Input}\t{item.Output}\n");
			}
			try
			{
				var sortedArray1 = Sorting<string>.GetSortedRouteBlocks(testArray1);

				Console.WriteLine("Sorted Array1: ");
				foreach ( var item in sortedArray1 )
				{
					Console.Write($"{item.Input}\t{item.Output}\n");
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine($"Произошла ошибка. {ex.Message}");
			}
			#endregion

			#region Сортировка массива даных целочисленного типа
			Console.WriteLine("\nInput Array2: ");
			foreach ( var item in testArray2 )
			{
				Console.Write($"{item.Input}\t{item.Output}\n");
			}
			try
			{
				var sortedArray2 = Sorting<int>.GetSortedRouteBlocks(testArray2);

				Console.WriteLine("\nSorted Array2: ");
				foreach ( var item in sortedArray2 )
				{
					Console.Write($"{item.Input}\t{item.Output}\n");
				}
			}
			catch ( Exception ex )
			{
				Console.WriteLine($"Произошла ошибка. {ex.Message}");
			}
			#endregion

			#region Сортировка списка даных целочисленного типа
			Console.WriteLine("\nInput List1: ");
			foreach ( var item in testList1 )
			{
				Console.Write($"{item.Input}\t{item.Output}\n");
			}
			try
			{
				var sortedList1 = Sorting<int>.GetSortedRouteBlocks(testList1);

				Console.WriteLine("\nSorted List1: ");
				foreach ( var item in sortedList1 )
				{
					Console.Write($"{item.Input}\t{item.Output}\n");
				}
			}
			catch ( Exception ex )
			{
				Console.WriteLine($"Произошла ошибка. {ex.Message}");
			}
			#endregion

			Console.ReadKey();
		}
	}
}
