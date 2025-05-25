namespace Interfaces_with_default_implementations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ILogger cl = new ConsoleLogger();

			cl.Log(LogLevel.Fatal, "ERRRRRRROOROROROROROROORO");

			cl.Log(LogLevel.Warning, "wARNING))");

			cl.Log(LogLevel.Debug, "Debugging...");

			ILogger dl = new DesktopLogger();

			dl.Log(LogLevel.Debug, "qwerty");

			Console.WriteLine(cl.GetType());

			cl.Log("Errererere");
		}
	}
}
