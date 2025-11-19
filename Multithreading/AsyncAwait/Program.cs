WriteCharAsync('+');
WriteCharAsync('2');

WriteChar('x');

Task<int> t = AdditionAsync(123, 21);
int asyncSum = await t;
Console.WriteLine(asyncSum);

Continuation(t);

static async Task WriteCharAsync(char c)
{
  Console.WriteLine($"Before:{Thread.CurrentThread.ManagedThreadId}");
  await Task.Run(() => WriteChar(c));
  Console.WriteLine($"\nAfter:{Thread.CurrentThread.ManagedThreadId}");
}
static void WriteChar(char c)
{
  Console.WriteLine($"Id {Thread.CurrentThread.ManagedThreadId} Task id {Task.CurrentId.GetValueOrDefault()}");
  Thread.Sleep(50);

  for (int i = 0; i < 100; i++)
  {
    Console.Write(c);
    Thread.Sleep(10);
  }
}

static async Task<int> AdditionAsync(int a, int b)
{
  return await Task.Run<int>(() => Addition(a, b));
}

static int Addition(int a, int b)
{
  Thread.Sleep(2000);
  return a + b;
}

static void Continuation(Task<int> t)
{
  Console.WriteLine($"Continue task Id #{Task.CurrentId}. Thread Id #{Thread.CurrentThread.ManagedThreadId}");
  Console.WriteLine("Result from previous operation: " + t.Result);
}  