using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Classes
{
    public partial class Person
    {
        private string FullName { get; set; }
		private int Age { get; set; }

		public Person(string fullName, int age)
		{
			FullName = fullName;
			Age = age;
		}
		public Person()
		{ 
		}

		public void Print()
        {
			Console.WriteLine($"FullName: {FullName} \nAge: {Age} ");
        }
    }
}
