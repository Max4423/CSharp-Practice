namespace AgeException
{
	class AgeException : ArgumentException
	{
		public int value { get; }
		public AgeException(string? message, int val) : base(message)
		{
			value = val;
		}
	}

	class Person
	{
		private int age;
		public string FullName { get; set; }

		public int Age
		{
			get => Age;
			set
			{
				if (value < 18)
				{
					throw new AgeException("Age < 18!", value);
				}
				else
				{
					age = value;
				}
			}

		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Person Max = new Person { FullName = "Max Hladun", Age = 12 };

			}
			catch (AgeException ex)
			{
				Console.WriteLine(ex.Message + " " +  ex.value);
			}

		}
	}
}
