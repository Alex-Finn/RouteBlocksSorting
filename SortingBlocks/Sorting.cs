using System.Collections.Generic;

namespace SortLib
{
	/// <summary>
	/// Класс сортировки массива с данными
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public static class Sorting<T>
	{
		/// <summary>
		/// Метод сортировки массива с данными. Данные должны быть строго одного типа и способны собраться в цепочку
		/// </summary>
		/// <param name="inputArray">Массив данных определенного типа</param>
		/// <returns>Метод возвращает отсортированный список данных</returns>
		public static List<RouteBlock<T>> GetSortedRouteBlocks( RouteBlock<T>[] inputArray )
		{			
			List<RouteBlock<T>> outputList = new List<RouteBlock<T>>(inputArray.Length);
						
			RouteBlock<T> startBlock = new RouteBlock<T>();
			startBlock = inputArray[0];

			for ( int i = 0 ; i < inputArray.Length ; i++ )
			{
				if ( Equals(inputArray[i].Output, startBlock.Input) )
				{
					startBlock = inputArray[i];
					i = -1;
				}				
			}

			outputList.Add(startBlock);

			for ( int i = 0, j = 0 ; i < inputArray.Length ; i++ )
			{
				if ( Equals(inputArray[i].Input, outputList[j].Output) )
				{
					outputList.Add(inputArray[i]);
					j++;
					i = -1;
				}
			}


			return outputList;
		}

		/// <summary>
		/// Метод сортировки списка данных. Данные должны быть строго одного типа и способны собраться в цепочку
		/// </summary>
		/// <param name="inputList">Список данных определенного типа</param>
		/// <returns>Метод возвращает отсортированный список данных</returns>
		public static List<RouteBlock<T>> GetSortedRouteBlocks( List<RouteBlock<T>> inputList )
		{
			List<RouteBlock<T>> outputList = new List<RouteBlock<T>>(inputList.Count);

			RouteBlock<T> startBlock = new RouteBlock<T>();
			startBlock = inputList[0];

			for ( int i = 0 ; i < inputList.Count ; i++ )
			{
				if ( Equals(inputList[i].Output, startBlock.Input) )
				{
					startBlock = inputList[i];
					i = -1;
				}
			}

			outputList.Add(startBlock);

			for ( int i = 0, j = 0 ; i < inputList.Count ; i++ )
			{
				if ( Equals(inputList[i].Input, outputList[j].Output) )
				{
					outputList.Add(inputList[i]);
					j++;
					i = -1;
				}
			}


			return outputList;
		}
	}

}
