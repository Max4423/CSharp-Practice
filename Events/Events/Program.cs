using System.Reflection;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account MonoAcc = new(5000);
			MonoAcc.Notify += ConsoleNotification;
            MonoAcc.Notify += msg => Console.WriteLine(msg);
			MonoAcc.Put(200);
			Console.WriteLine(MonoAcc.Sum);
            MonoAcc.Take(1200);
			Console.WriteLine(MonoAcc.Sum);
			MonoAcc.Take(5000);
			Console.WriteLine(MonoAcc.Sum);
		}

		public static void ConsoleNotification(string msg)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(msg);
			Console.ResetColor();
		}
	}

    class Account
    {
        public int Sum { get; private set; }
        public event AccountHandler? Notify;

		public Account(int sum) => Sum = sum;

        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"Deposited to the account {sum}$");

		}

        public void Take(int sum)
        {
            if (sum<= Sum)
            {
                Sum -= sum;
				Notify?.Invoke($"Debited from the account {sum}$ \nRemaining on the account:{Sum}");
			}

            else
            {
				Notify?.Invoke($"Insufficient funds in the account. Current balance: {Sum}$");
			}
		}
    }

    delegate void AccountHandler(string message);


}
