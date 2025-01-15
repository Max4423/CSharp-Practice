using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5];

        int[,] array2 = new int[5, 5];

        Console.WriteLine(array.Length);

        array = Resize(array, 10);
        Console.WriteLine(array.Length);
        array2 = Resize(array2, 10, 10);
        Console.WriteLine(array2.GetLength(0) + " " + array2.GetLength(1));

    }

    static int[] Resize(int[] arr, int size)
    {
        int[] temp = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            temp[i] = arr[i];
        }

        arr = temp;
        return arr;
    }

    static int[,] Resize(int[,] arr, int sizex, int sizey)
    {
        int[,] temp = new int[sizex, sizey];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                temp[i, j] = arr[i, j];
            }
        }

        arr = temp;
        return arr;
    }


}

