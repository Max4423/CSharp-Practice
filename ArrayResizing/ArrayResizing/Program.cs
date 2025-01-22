using System.Drawing;
using System.Runtime.Serialization;

namespace ArrayResizing
{
	internal class Program
	{

		static void Print <T>(T[] arr)
		{
			foreach (T elem in arr)
				Console.Write(elem + " ");
			Console.WriteLine();

		}
		static void Resize<T>(ref T[] arr, int size)
		{
			T[] temp = new T[size];
			for (int i = 0; i < arr.Length && i < temp.Length; i++)
			{
				temp[i] = arr[i];
			}

			arr = temp;
		}

		static void InsertElementToEnd<T>(ref T[] arr, T value)
		{
			T[] temp = new T[arr.Length + 1];
			for (int i = 0; i < arr.Length; i++)
			{
				temp[i] = arr[i];
			}
			temp[temp.Length - 1] = value;

			arr = temp;
		}

		static void InsertElementToStart<T>(ref T[] arr, T value)
		{
			T[] temp = new T[arr.Length + 1];
			temp[0] = value;
			for (int i = 0; i < arr.Length; i++)
			{
				temp[i+1] = arr[i];
			}
			

			arr = temp;
		}
		static void Insert<T>(ref T[] arr, T value, int index = -1)
		{
			if (index == -1)
			{
				index = arr.Length;
			}
			T[] temp = new T[arr.Length + 1];
			temp[index] = value;

			for (int i = 0; i < index; i++)
				temp[i] = arr[i];


			for (int i = index; i < arr.Length; i++)
				temp[i + 1] = arr[i];

			arr = temp;
		}

		static void Delete<T>(ref T[] arr, int index = -1)
		{
			if (index == -1)
			{
				index = arr.Length;
			}

			T[] temp = new T[arr.Length - 1];
			for (int i = 0; i < index; i ++)
			{
				temp[i] = arr[i];
			}

			for (int i = index; i < arr.Length; i++)
			{
				temp[i - 1] = arr[i];
			}

			arr = temp;
		}
			static void Main(string[] args)
		{

			int[] array = new int[5] { 1, 4, 2, 7, 13 };
			Print(array);

			Resize(ref array, 10);
			Print(array);

			string[] strArray = { "test", "hello", "world" };


			InsertElementToEnd(ref strArray, "new1234");
			Print(strArray);


			Insert(ref array, 444, 1);
			Print(array);


			InsertElementToStart(ref array, 55555);
			Print(array);


			Delete(ref array, 4);
			Print(array);
		}
	}
}
