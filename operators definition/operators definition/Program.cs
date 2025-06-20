namespace operators_definition
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Counter counter1 = new Counter { Value = 23 };
			Counter counter2 = new Counter { Value = 45 };

			Counter result = counter1 + counter2;
			Console.WriteLine(result.Value);

			Console.WriteLine(counter1 < counter2);

			Console.WriteLine(counter1 > counter2);


			int cast = (int)counter1;

			int x = 123;

			Counter ctr = x;
			Console.WriteLine(ctr.Value);
		}
	}

    class Counter
    {
		public int Value { get; set; }

		public static Counter operator +(Counter c1, Counter c2)
		{
			return new Counter() {Value = c1.Value + c2.Value };
		}

		public static bool operator >(Counter c1, Counter c2)
		{
			if (c1.Value > c2.Value)
				return true;
		
			else
				return false;
		}

		public static bool operator <(Counter c1, Counter c2)
		{
			if (c1.Value < c2.Value)
				return true;

			else
				return false;
		}

		public static explicit operator int(Counter counter)
		{
			return counter.Value;

		}

		public static implicit operator Counter(int value)
		{
			return new Counter() { Value = value };
		}
	}
}
