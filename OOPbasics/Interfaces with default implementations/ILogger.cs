using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_with_default_implementations
{
	internal interface ILogger
	{
		void Log(LogLevel logLevel, string message)
		{
			Console.WriteLine($"Logger wasn`t implemented! \nMessage: {message}");
		}

		void Log(string message)
		{
			Log(LogLevel.Error, message);
		}
	}
}
