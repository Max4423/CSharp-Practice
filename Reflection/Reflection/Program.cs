using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace Reflection
{
	internal class Program
	{
		static void Main(string[] args)
		{
	
			MyClass cl = new();
			Type t = cl.xx.GetType();

			Console.WriteLine(t);

			Console.WriteLine(t.GetFields());

			foreach (var item in typeof(MyClass).GetFields())
			{
				Console.WriteLine("-----------------------");
				Console.WriteLine(item);
			}

			Console.WriteLine(t.IsValueType);

			Assembly a = Assembly.LoadFrom(@"C:\Users\miksi\Desktop\C#\DLL\MyLibrary\MyLibrary\bin\Debug\net9.0\MyLibrary.dll");
			Type[] types2 = a.GetTypes();
			foreach (Type tt in types2)
			{
				Console.WriteLine("============");
				Console.WriteLine(tt.Name);
				tt.GetP
				var methods = tt.GetMethods();
				foreach (var item in methods)
				{
					Console.WriteLine(item.Name);
				}
				Type[] intf = tt.GetInterfaces();
                Console.WriteLine(intf.Length);
				foreach (Type intff in intf)
				{
                    Console.WriteLine(intff.FullName);
				}
			}

			



			Type tp = typeof(string);
			ConstructorInfo[] ci = tp.GetConstructors(BindingFlags.Public | BindingFlags.Instance);

			foreach (var item in ci)
			{
				Console.WriteLine(item);
			}

		}
	}

	class MyClass
	{
		string name;
		public int MyProperty { get; set; }

		public int xx;
	}

	class Car
	{
		public string Model { get; set; }
		public void Drive() { Console.WriteLine("Їдемо!"); }
	}
}
