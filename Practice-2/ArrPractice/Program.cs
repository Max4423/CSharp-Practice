int[] arr = { 2, 3, 666, 7, 9, 65, 33 };
int sum = 0;
for (int i = 0;i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

for(int i =0; i < arr.Length; i++)
{
    sum += arr[i];
}
Console.WriteLine("\n"+sum);


int maxValue = int.MinValue;
for(int i = 0; i < arr.Length; i++)
{
    if (maxValue < arr[i])
    {
    {
        maxValue = arr[i];
    }
}
Console.WriteLine(maxValue);

Console.WriteLine(arr.Max());