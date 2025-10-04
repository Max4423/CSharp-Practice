namespace Queue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<string> people = new Queue<string>();

			people.Enqueue("Max");
			people.Enqueue("Viktor");
			people.Enqueue("Vasyl");

			Console.WriteLine(people.Count);
			Console.WriteLine(people.Contains("Max"));

			var first = people.Peek();
			Console.WriteLine(first);

			people.Dequeue();
			Console.WriteLine("=========================");
			foreach (var item in people)
			{
				Console.WriteLine(item);
			}
			people.Dequeue();
			string result;
			people.Dequeue();
			people.TryDequeue(out result);
			people.TryPeek(out result);


		}
	}
}
