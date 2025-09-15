using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

namespace AllListOfClassTypesBufferedStream
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Type t = typeof(System.IO.BufferedStream);

			MemberInfo[] allMembers = t.GetMembers();

			Console.WriteLine($"All members of class {t} with {allMembers.Length} elements");


			FieldInfo[] fi = t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);

			Console.WriteLine("Fields: " + fi.Length);
			PrintMembers(fi);

			PropertyInfo[] pi = t.GetProperties();

			Console.WriteLine("Properties: " + pi.Length);
			PrintMembers(pi);


			EventInfo[] ei = t.GetEvents();

			Console.WriteLine("Events: " + ei.Length);

			PrintMembers(ei);

			MethodInfo[] mi = t.GetMethods();
			Console.WriteLine("Methods: " + mi.Length);
			PrintMembers(mi);

			ConstructorInfo[] ci = t.GetConstructors(BindingFlags.);
			Console.WriteLine("Constructors: " + ci.Length);
			PrintMembers(ci);



		}

		public static void PrintMembers(MemberInfo[] ms)
		{
			foreach (var m in ms)
			{
				Console.WriteLine(m.Name + " ");
			}
			Console.WriteLine();
		}
	}
}
