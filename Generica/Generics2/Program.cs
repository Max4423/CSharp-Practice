using System.Collections;
using System.Collections.Generic;
using static Generics2.Program;
namespace Generics2
{
	internal class Program
	{

		public class MyList<T> : IEnumerable<T>
		{
			private T[] _arr = Array.Empty<T>();

			public T this[int index]
			{
				get
				{
					return _arr[index];
				}

				set
				{
					_arr[index] = value;
				}
			}

			public int Count { get { return _arr.Length; } }

			public void Add(T value)
			{
				var newArr = new T[_arr.Length + 1];

				for (int i = 0; i < _arr.Length; i++)
				{
					newArr[i] = _arr[i];
				}
				newArr[_arr.Length] = value;

				_arr = newArr;
			}

			public IEnumerator<T> GetEnumerator()
			{
				for (int i = 0; i < _arr.Length; i++)
				{
					yield return _arr[i]; 
				}
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}
		}
		static void Main(string[] args)
		{
			List<int> list = new List<int>();

			list.Add(23);

			list.Add(123);

			ArrayList arrList = new ArrayList();

			arrList.Add(23);
			arrList.Add('a');
			arrList.Add("Max");

			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("----------------------");
			foreach (var item in arrList)
			{
				Console.WriteLine(item);

			}

			Console.WriteLine("----------------------");
			Console.WriteLine("--------------------My LIST--------------------");
			MyList<int> mylist = new MyList<int>();


			mylist.Add(12);
			mylist.Add(2);

			mylist.Add(22);

			foreach (var item in mylist)
			{
				Console.Write(item + " ");
			}

		}
	}
}
