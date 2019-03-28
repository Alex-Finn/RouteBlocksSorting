namespace SortLib
{
	public class RouteBlock<T>
	{
		public T Input { get; set; }
		public T Output { get; set; }

		public RouteBlock() { }
		public RouteBlock( T input, T output )
		{
			Input = input;
			Output = output;
		}
	}
}
