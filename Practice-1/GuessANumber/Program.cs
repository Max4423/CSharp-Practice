int number;
int lower, higher;
int triesCount = 5;
int userInput;  

Console.OutputEncoding = System.Text.Encoding.UTF8;

Random rand = new Random();
number = rand.Next(0, 101); 
lower = rand.Next(number - 10, number);
higher = rand.Next(number + 1, number + 10);

Console.WriteLine($"Загадане число від 0 до 100, більше ніж {lower}, менше ніж {higher}");
Console.WriteLine($"К-сть спроб: {triesCount}");
Console.WriteLine("999 - підказка");

while(triesCount-- > 0){
    userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput == number)
    {
        Console.WriteLine("Ви вгадали!");
        break;
    }
    else if (userInput == 999)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("Підказка: число парне");
        }
        else
        {
            Console.WriteLine("Підказка: число непарне");
        }
        triesCount++;
    }
    else
    {
        Console.WriteLine("Ви не вгадали!");
        Console.WriteLine($"К-сть спроб {triesCount}");


    }
}
if (triesCount < 0 )
{
    Console.WriteLine($"Ви програли! Загадане число = {number}");
}


