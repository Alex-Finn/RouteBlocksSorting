using System.Collections.Generic;

namespace SortLib
{
	public static class Sorting<T>
	{
		public static List<RouteBlock<T>> GetSortedRouteBlocks( RouteBlock<T>[] inputArray )
		{
			List<RouteBlock<T>> outputList = new List<RouteBlock<T>>(inputArray.Length);

			RouteBlock<T> tempBlock = new RouteBlock<T>();
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
	}

}
