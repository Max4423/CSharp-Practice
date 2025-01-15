using System.Runtime.CompilerServices;

namespace OOPPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car ferrari = new Car("F40", 500, 2, 324f);

            Car maseratti = ferrari;
            maseratti.HorsePower = 800;

            Console.WriteLine(maseratti.HorsePower + "Horse Power");

            ferrari.showTechnicalPassport();

            ferrari.becomeOlder(5, 100);

            ferrari.showTechnicalPassport();
        }
    }

    class Car
    {
        public string Name;
        public int HorsePower;
        public int Age;
        public float MaxSpeed;
        public int Years = 5;

        public void showTechnicalPassport()
        {

            Console.WriteLine("<<<<Technical Passport>>>>");
            Console.WriteLine($" Name:{Name},\n Horse Power: {HorsePower},\n Age: {Age},\n Max Speed: {MaxSpeed} ");
        }

        public void becomeOlder(int Years, int runawayHorses)
        {
            Age += this.Years + Years;
            HorsePower -= runawayHorses;
        }

        public Car(string name, int horsePower, int age, float maxSpeed)
        {
            Name = name;
            HorsePower = horsePower;
            Age = age;
            MaxSpeed = maxSpeed;
        }
        public Car()
        { }
    }

}
