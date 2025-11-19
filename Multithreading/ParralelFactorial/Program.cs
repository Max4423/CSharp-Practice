Task<int> task1 = Task.Run(() => Factorial(7));
Task<int> task2 = Task.Run(() => Factorial(10));
Task<int> task3 = Task.Run(() => Factorial(15));

int[] results = await Task.WhenAll(task1, task2, task3);

foreach (var r in results)
    Console.WriteLine(r);


static int Factorial(int n)
{
    if (n <= 1) return 1;
    return n * Factorial(n - 1);
}