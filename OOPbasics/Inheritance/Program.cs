namespace Inheritance
{
	internal class Program
	{
		static void PrintName(Person person)
		{
			Console.WriteLine(person.FullName);
		}
		static void Main(string[] args)
		{

			Teacher teach = new Teacher { FullName = "Marina", Age = 45, Salary = 12300, subject = Subjects.Biology };

			PrintName(teach);

			Person tch = new Teacher { FullName = "Marina", Age = 45, Salary = 12300, subject = Subjects.Biology };

			Teacher tchas = tch as Teacher;

			if(tch is Person marina)
			{
				Console.WriteLine("Marina is a person");
			}
		}
	}
}
