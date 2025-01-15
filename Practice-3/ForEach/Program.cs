int[] numbers = {0,1, 2, 3, 4, 5, 6, 7, 8, 9 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine("");


foreach (int number in numbers)
{
    Console.WriteLine(number + " ");
}