using System.Collections.Concurrent;

class Program
{
	delegate void MyDeleg();

	delegate void MyDeleg2(string msg);

	delegate string MyDeleg3(string ms1, string ms2);

	static void Hello1() => Console.WriteLine("Hello from delegate 1!");

	static void Hello2() => Console.WriteLine("Hello from delegate 2!");


	static void ShowMessage(string ms)
	{
		Console.WriteLine(ms);
	}

	static string Concat(string s1, string s2)
	{
		return $"{s1} {s2}";
	}

	static void Main()
	{
		MyDeleg dlg = new(Hello1);
		dlg();

		MyDeleg2 dlg2 = new(ShowMessage);

		dlg2("23");

		MyDeleg3 dlg3 = new(Concat);

		Console.WriteLine(dlg3("QWER", "TYUI"));

		Func<string, string, string> emdel = new(Concat);

		Console.WriteLine(emdel("max", "vaVERF"));

		Console.WriteLine(emdel.Invoke("Max", "Concat")); 


		dlg += Hello2;
		Console.WriteLine("-----------------");
		dlg.Invoke();

		DoOperation(2,2,Divide);
	}
	delegate int Operation(int a, int b);

	static int Add(int a, int b) => a + b;
	static int Substract(int a, int b) => a - b;

	static int Multiply(int a, int b) => a * b;

	static int Divide(int a, int b) => a / b;

	static void DoOperation(int a, int b, Operation op)
	{
		Console.WriteLine(op(a,b));
	}

}
