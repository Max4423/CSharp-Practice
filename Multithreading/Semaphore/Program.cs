for (int i = 0; i < 3; i++)
{
    Reader reader = new Reader(i);
}

class Reader
{
    static Semaphore sem = new Semaphore(3, 3);
    Thread myThread;
    int count = 3;

    public Reader(int i)
    {
        myThread = new Thread(Read);
        myThread.Name = $"Reader {i}";
        myThread.Start();
    }

    public void Read()
    {
        while (count > 0)
        {
            sem.WaitOne();

            Console.WriteLine($"{Thread.CurrentThread.Name} enters the library");

            Console.WriteLine($"{Thread.CurrentThread.Name} is reading");
            Thread.Sleep(1000);

            Console.WriteLine($"{Thread.CurrentThread.Name} leaves the library");

            sem.Release();

            count--;
            Thread.Sleep(1000);
        }
    }
}