namespace indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company IBM = new Company(new Person[]{ new Person("Max"), new Person("Vasyl"), new Person("Ivan") });

            Console.WriteLine(IBM[1].Name);
            IBM[1] = new Person("Peter");

			Console.WriteLine(IBM[1].Name);
		}
	}

    class Person
    {
        public string Name { get; }

        public Person(string name) => Name = name;

	}

    class Company
    {
        Person[] personal;

        public Company(Person[] people) => personal = people;

        public Person this[int indexer]
        {
            get
            {
                if (indexer < 0 || indexer > personal.Length - 1)
                    throw new IndexOutOfRangeException("Iндекс поза межами!");
            

                return personal[indexer];

			}

            set
            {
				if (indexer < 0 || indexer > personal.Length - 1)
					throw new IndexOutOfRangeException("Iндекс поза межами!");

				personal[indexer] = value;
            }
		}

	}
}
