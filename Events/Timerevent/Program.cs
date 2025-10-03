namespace Timerevent
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Timer timer = new Timer();
			timer.timerNotification += ConsoleNotificator;
			timer.timerFinishedNotification += ConsoleNotificator;
			timer.StartTimer(2);
		}

		public static void ConsoleNotificator(string message)
		{
			Random rand = new Random();
			Console.ForegroundColor = (ConsoleColor)rand.Next(15);
			Console.WriteLine(message);
		}
	}

	delegate void TimerHandler(string msg);
	class Timer
	{
		public event TimerHandler timerNotification;
		public event TimerHandler timerFinishedNotification;

		int _seconds = 0;

		public void RaiseNotification()
		{
			timerNotification?.Invoke($"Timer seconds:{++_seconds}");
		}
		public void RaiseFinishNotification()
		{
			timerFinishedNotification?.Invoke($"Timer finished! There was {_seconds} seconds");
		}
		public void StartTimer(int seconds)
		{
			for (int i = 0; i < seconds; i++)
			{
				RaiseNotification();
				Console.Beep();
				Thread.Sleep(1000);
			}
			RaiseFinishNotification();
		}
	}


	
	}

