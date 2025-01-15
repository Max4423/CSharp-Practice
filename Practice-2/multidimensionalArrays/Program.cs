int[,] arr = new int[3, 3]; // [к-сть рядків, к-сть стовпців]

int[,] arr2 = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

int[,] arr3 = new int[2, 3]
{
    {0, 1, 2},
    {2,4,5 }
};
Console.WriteLine(arr3[1,2]);

for (int i = 0; i < arr3.GetLength(0); i++)
{
    for (int j = 0; j < arr3.GetLength(1); j++)
    {
        Console.Write(arr3[i,j] + " ");
    }
    Console.WriteLine("");
}