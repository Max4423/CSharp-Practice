namespace Protected
{
	class Animal
	{
		protected string name;

		public Animal(string name)
		{
			this.name = name;
		}

		protected void MakeSound(string sound)
		{
			Console.WriteLine($"Sound of {sound}");
		}

	}

	class Dog : Animal
	{
		public Dog(string name) : base(name)
		{
		}

		public void Speak()
		{
			MakeSound($"{name}: Gaff");
		}
	}

	class Cat: Animal
	{
		public Cat(string name): base(name)
		{
		}

		public void Speak()
		{
			MakeSound($"{name}: Meoww!");
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Dog dog = new Dog("John");
			Cat cat = new Cat("Murko");

			dog.Speak();
			cat.Speak();
		}
	}
}
