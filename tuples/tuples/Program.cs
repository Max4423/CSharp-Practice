namespace tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tuple = (12, "Max", 'q', 23, 213);

            (int, double, string) tpl = (1234, 12.4, "qwerty");

			Console.WriteLine(tpl.Item1);

            var person = (name: "Max", age: 20);

            Console.WriteLine(person.name);

            var (x, y) = person;

			Console.WriteLine(x);


			string main = "Java";
			string second = "C#";
			(main, second) = (second, main);

			int xx = 123;
            int yy = 999;

            (xx,yy) = (yy,xx);
		}
    }
}
