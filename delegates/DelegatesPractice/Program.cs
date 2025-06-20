static void SimplePrint(string message)
{
	Console.WriteLine(message);
}

static void ColorPrint(string message)
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine(message);
	Console.ResetColor();
}

Account MonoAccount = new(4000);

MonoAccount.RegisterHandler(ColorPrint);
MonoAccount.RegisterHandler(SimplePrint);
MonoAccount.Take(7000);

MonoAccount.UnregisterHandler(ColorPrint);
MonoAccount.UnregisterHandler(SimplePrint);

MonoAccount.Take(2000);



public delegate void AccountHandler(string message);


public class Account
{
	int sum;

	AccountHandler? taken;

	public Account(int sum) => this.sum = sum;

	public void RegisterHandler(AccountHandler del) => taken += del;
	public void UnregisterHandler(AccountHandler del) => taken -= del;

	public void Add(int sum) => this.sum += sum;

	public void Take(int sum)
	{
		if (this.sum >= sum)
		{
			this.sum -= sum;
			taken?.Invoke($"З рахунку знята сума: {sum} грн");

		}
		else
		{
			taken?.Invoke($"На рахунку недостатньо коштів!");
		}
	}

}

