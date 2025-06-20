namespace CounterToTimerCasting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Counter ctr1 = new Counter {Seconds = 2314 };
			Timer timer = ctr1;
			Counter ctr2 = new Counter { Seconds = 123};

			Timer tmr = new Timer { Seconds = 12, Minutes = 23, Hours = 2 };

			Counter ctr44 = (Counter)tmr;

			Console.WriteLine(ctr44.Seconds);

			int x = 123;
			ref int refx = ref x;

			Console.WriteLine(refx);

			ref int xaxaxa = ref refx;

		}
	}

	class Timer
	{
		public int Hours { get; set; }
		public int Minutes { get; set; }
		public int Seconds { get; set; }
	}

	class Counter
	{
		public int Seconds { get; set; }

		public static implicit operator Counter(int x)
		{
			return new Counter() { Seconds = x };
		}

		public static explicit operator int(Counter ctr)
		{
			return ctr.Seconds;
		}

		public static explicit operator Counter(Timer timer)
		{
			int h = timer.Hours;
			int m = timer.Minutes;
			int s = timer.Seconds;

			return new Counter() { Seconds = h*3600 + m*60 + s };
		}

		public static implicit operator Timer(Counter counter)
		{
			int h = counter.Seconds / 3600;
			int m = (counter.Seconds % 3600) / 60;
			int s = counter.Seconds % 60;
			return new Timer() { Hours = h, Minutes = m, Seconds = s };
		}


	}

}
