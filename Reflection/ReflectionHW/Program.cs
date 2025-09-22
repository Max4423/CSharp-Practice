using System.Reflection;
using System.Xml;

namespace ReflectionHW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car("BMW","m5",2021,8);

			Type CarType = car.GetType();

			PropertyInfo[] carProps = CarType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

			ConstructorInfo[] carCtrs = CarType.GetConstructors();
			foreach (PropertyInfo carProp in carProps)
			{
				Console.WriteLine($"Property: {carProp.Name} (Type: {carProp.PropertyType.Name})");
			}

			foreach (ConstructorInfo carCtr in carCtrs)
			{
				ParameterInfo[] pmtrInfo = carCtr.GetParameters();

				string parameters = string.Join(", ",
					pmtrInfo.Select(p => $"{p.ParameterType.Name} {p.Name}"));

				Console.WriteLine($"Constructor: {carCtr.Name}({parameters})");
			}

			object CarInstance = Activator.CreateInstance(CarType);
			MethodInfo DriveInfo = CarType?.GetMethod("Drive");
			DriveInfo.Invoke(CarInstance, new object[] { 12 });


			FieldInfo? fieldInfo = CarType?.GetField("CylindersNumber", BindingFlags.NonPublic | BindingFlags.Instance);

			Console.WriteLine(fieldInfo.GetValue(car));

			fieldInfo?.SetValue(car, 6);

			Console.WriteLine(fieldInfo.GetValue(car));

			Assembly assembly = Assembly.GetExecutingAssembly();
			Type[] types = assembly.GetTypes();

			foreach (var type in types)
			{
                Console.WriteLine("---------------------------");
                Console.WriteLine("--" + type.Name + "--");
				MethodInfo[] mi = type.GetMethods();

				foreach (var item in mi)
				{
					Console.WriteLine(item.Name); 
				}
			}
		}


	
	}
}
