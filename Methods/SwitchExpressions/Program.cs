namespace SwitchExpressions
{
	internal class Program
	{
		public static class SwitchExample
		{
			enum Level
			{
				Beginner,
				Intermediate,
				Advanced
			}

			static int GetGrades(Level levels)
			{
				int bonusGrades = levels switch
				{
					Level.Beginner => 10,
					Level.Intermediate => 20,
					Level.Advanced => 30,
					_ => 0
				};
				return bonusGrades;
			}
			public static void Main()
			{
				
			}
		}
	}
}
