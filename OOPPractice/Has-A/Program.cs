using System.Security.Cryptography.X509Certificates;

namespace Has_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Performer worker1 = new Performer("Максим");
            Performer worker2 = new Performer("Іван");

            Task[] tasks = { new Task(worker1, "Написати код"), new Task(worker2, "Пофіксити баги") };

            Board schedule = new Board(tasks);

            schedule.ShowAllTasks();
        }
    }

    class Performer
    {
        public string Name;
        public Performer(string name)
        { Name = name; }
    }

    class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowAllTasks()
        {
            for (int i = 0;i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
                Console.WriteLine();
            }
        }
    }

    class Task
    {
        public Performer Worker;
        public string Description;

        public Task(Performer worker, string description)
        {
            Worker = worker;
            Description = description;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Відповідальний:{Worker.Name}\nOпис завдання:{Description}.");
        }
    }
}

