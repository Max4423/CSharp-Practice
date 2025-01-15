namespace JaggedArraysPractice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[][] grades = new int[5][]
			{
				 new int[] { 5, 8, 3 },
				 new int[] { 12, 7, 4, 10 },
				new int[] { 9, 1, 6, 12, 3 },
				 new int[] { 8, 5, 2, 10, 11, 7 },
				 new int[] { 4, 6, 12, 3, 8, 2, 9 }
			};

			string[] students = new string[] { "John", "Jane", "Jack", "Jill", "Joe" };
			double bestAverageGrade = int.MinValue;
			string bestStudent = "";
			double WorstAverageGrade = int.MaxValue;
			string worstStudent = "";
			for (int i = 0; i < grades.Length; i++)
			{
				int sum = 0;
				
				Console.Write($"Grades of student {students[i]}: ");
				for(int j = 0; j < grades[i].Length; j++)
				{
					Console.Write($" {grades[i][j]}");
					sum += grades[i][j];
				}
				double averageGrade = Math.Round((double)sum / grades[i].Length, 2);

				if (averageGrade > bestAverageGrade)
				{
					bestAverageGrade = averageGrade;
					bestStudent = students[i];
				}

				if (averageGrade < WorstAverageGrade)
				{
					WorstAverageGrade = averageGrade;
					worstStudent = students[i];
				}
				Console.WriteLine();
				Console.WriteLine("Average grade: " + averageGrade);
			}

			Console.WriteLine($"Best student: {bestStudent} {bestAverageGrade}");
			Console.WriteLine($"Worst student: {worstStudent} {WorstAverageGrade}");
		}
	}
}
