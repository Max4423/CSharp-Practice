using System.Globalization;
using System.Reflection;

namespace Info
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Type myType = Type.GetType("System.IO.File");

			MemberInfo[] mbrInfo = myType.GetMembers();

			Console.WriteLine($"There are {mbrInfo.Length} members in {myType.FullName}");

			if (myType.IsPublic)
			{
				Console.WriteLine($"{myType.FullName} is public.");
			}

			Type[] intf = myType.GetInterfaces();

			Console.WriteLine(intf.Length + " interfaces");

			MethodInfo[] mtd = myType.GetMethods();

			Console.WriteLine(mtd.Length + " methods");


			Type myType2 = Type.GetType("System.Reflection.FieldInfo");
			MethodInfo myMethodInfo = myType2.GetMethod("GetValue");
			Console.WriteLine(myType2.FullName + "." + myMethodInfo.Name);

			MemberTypes myMemberTypes = myMethodInfo.MemberType;

			Console.WriteLine(myMemberTypes == MemberTypes.Method);

			Type myType3 = typeof(System.Console);

			PropertyInfo prop = myType3.GetProperty("BufferHeight");

			Console.WriteLine(prop.CanWrite);
		}
	}
}
