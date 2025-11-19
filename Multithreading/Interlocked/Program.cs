using System.Runtime.InteropServices.ComTypes;

int votes = 0;
List<Task> tasks = new List<Task>();
for (int i = 0; i < 10; i++)
{
    tasks.Add(Task.Run(() => IncreaseVotes(ref votes)));
}

Task.WaitAll(tasks.ToArray());
Console.WriteLine($"Всього голосів: {votes}");

static void IncreaseVotes(ref int x)
{
    for (int i = 0; i < 1000; i++)
    {
        Interlocked.Add(ref x, 85);
        // x++;
        Task.Delay(1000);
    }
}