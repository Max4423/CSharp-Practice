namespace Stack
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Stack<string> people = new Stack<string>();
			people.Push("Max");
			people.Push("Vasyl");
			people.Push("Ivan");
			people.Push("Petro");

			Console.WriteLine(people.Peek());
			Console.WriteLine(people.Pop());
			Console.WriteLine("==================");
			foreach (var item in people)
			{
				Console.WriteLine(item);
			}

			people.Pop();
			people.Pop();
			people.Pop();

			string result;
			people.TryPop(out result);

			people.TryPeek(out result);

		}
	}
}
