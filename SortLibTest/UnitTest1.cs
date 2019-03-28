using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortLib;

namespace SortLibTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Sorting_Of_Array_Returns_Correct_Data()
		{
			RouteBlock<int>[] routeBlock = new RouteBlock<int>[]
			{
				new RouteBlock<int>(5,6),
				new RouteBlock<int>(4,5),
				new RouteBlock<int>(6,7)
			};

			var expected = new RouteBlock<int>[]
			{
				new RouteBlock<int>(4,5),
				new RouteBlock<int>(5,6),
				new RouteBlock<int>(6,7)
			};

			var actual = Sorting<int>.GetSortedRouteBlocks(routeBlock);

			Assert.AreEqual(expected[0].Input, actual[0].Input);
			Assert.AreEqual(expected[1].Input, actual[1].Input);
			Assert.AreEqual(expected[2].Input, actual[2].Input);
			Assert.AreEqual(expected[0].Output, actual[0].Output);
			Assert.AreEqual(expected[1].Output, actual[1].Output);
			Assert.AreEqual(expected[2].Output, actual[2].Output);
			Assert.AreEqual(expected.Length, actual.Count);
		}

		[TestMethod]
		public void Sorting_Gives_Chain_Of_Blocks()
		{
			RouteBlock<string>[] routeBlock = new RouteBlock<string>[]
			{
				new RouteBlock<string>("Venus","Earth"),
				new RouteBlock<string>("Mars","Jupiter"),
				new RouteBlock<string>("Neptune","Pluto"),
				new RouteBlock<string>("Mercury","Venus"),
				new RouteBlock<string>("Saturn","Uranus"),
				new RouteBlock<string>("Uranus","Neptune"),
				new RouteBlock<string>("Earth","Mars"),
				new RouteBlock<string>("Jupiter","Saturn")
			};

			var expected = new RouteBlock<string>[]
			{
				new RouteBlock<string>("Mercury","Venus"),
				new RouteBlock<string>("Venus","Earth"),
				new RouteBlock<string>("Earth","Mars"),
				new RouteBlock<string>("Mars","Jupiter"),
				new RouteBlock<string>("Jupiter","Saturn"),
				new RouteBlock<string>("Saturn","Uranus"),
				new RouteBlock<string>("Uranus","Neptune"),
				new RouteBlock<string>("Neptune","Pluto")
			};

			var actual = Sorting<string>.GetSortedRouteBlocks(routeBlock);

			Assert.AreEqual(actual[0].Output, actual[1].Input);
			Assert.AreEqual(actual[1].Output, actual[2].Input);
			Assert.AreEqual(actual[2].Output, actual[3].Input);
			Assert.AreEqual(actual[3].Output, actual[4].Input);
			Assert.AreEqual(actual[4].Output, actual[5].Input);
			Assert.AreEqual(actual[5].Output, actual[6].Input);
			Assert.AreEqual(actual[6].Output, actual[7].Input);

			Assert.AreEqual(expected[1].Input, actual[1].Input);
			Assert.AreEqual(expected[2].Input, actual[2].Input);
			Assert.AreEqual(expected[0].Output, actual[0].Output);
			Assert.AreEqual(expected[1].Output, actual[1].Output);
			Assert.AreEqual(expected[2].Output, actual[2].Output);
		}
	}
}
