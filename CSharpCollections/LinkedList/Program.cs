namespace LinkedList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var employees = new List<string> { "Tom", "Sam", "Bob" };

			LinkedList<string> strings = new LinkedList<string>(employees);

			strings.AddLast("Max");
			Console.WriteLine(strings.First.Value);


			Console.WriteLine(strings.Last.Value); 
			
			Console.WriteLine(strings.Count);

			Console.WriteLine("=================");
			var currentNode = strings.First;
			while (currentNode is not null)
			{
				Console.WriteLine(currentNode.Value);
				currentNode = currentNode.Next;
			}
			Console.WriteLine("=================");
			strings.AddAfter(strings.Find("Bob"), "Bobko");

			var currentNode2 = strings.Last;
			while (currentNode2 is not null)
			{
				Console.WriteLine(currentNode2.Value);
				currentNode2 = currentNode2.Previous;
			}


		}
	}
}
