using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public enum Subjects
	{
		Mathematics,
		Physics,
		Chemistry,
		ComputerScience,
		Biology,
		History,
		Geography,
		Literature,
		Economics,
		Philosophy
	}
	public class Teacher: Employee
    {
		public Subjects subject;
		public void PrintInfo()
		{
			Console.WriteLine($"FullName: {FullName}  \nAge: {Age} \nSubject: {subject}");
		}
	}
}
