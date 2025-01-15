using System;

namespace Switch_expressions_my
{
	internal class Program
	{
		enum Pets
		{
			Dog,
			Cat,
			Dragon,
			Parrot
		}

		static int GetAge(Pets pet)
		{
			int age = pet switch
			{
				Pets.Dog => 10,
				Pets.Cat => 5,
				Pets.Dragon => 100,
				Pets.Parrot => 2,
				_ => 0
			};
			return age;
		}

		
		static void Main(string[] args)
		{

			int age = GetAge(Pets.Dragon);
			Console.WriteLine(age);

		}
	}
}
