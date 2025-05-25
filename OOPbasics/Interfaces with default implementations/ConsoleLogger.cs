using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_with_default_implementations
{
	internal class ConsoleLogger : ILogger
	{
		public void Log(LogLevel logLevel, string message)
		{
			switch (logLevel)
			{
				case LogLevel.Debug:
					Console.ForegroundColor = ConsoleColor.Green;
					break;
				case LogLevel.Info:
					Console.ForegroundColor = ConsoleColor.Blue;
					break;
				case LogLevel.Warning:
					Console.ForegroundColor = ConsoleColor.Yellow;
					break;
				case LogLevel.Error:
					Console.ForegroundColor = ConsoleColor.Red;
					break;
				case LogLevel.Fatal:
					Console.ForegroundColor = ConsoleColor.DarkRed;
					break;
				default:
					break;
			}
			Console.WriteLine($"{DateTime.Now}: {message}");
			Console.ResetColor();
		}
	}
}
