namespace Generics
{
     public class Program2
    {
        public static void Swap(ref object a, ref object b)
        {
			object temp = a;
            a = b;
            b = temp;
		}


		// Generic method
		public static void SwapGeneric<T> (ref T value1, ref T value2)
            {
			T temp = value1;
            value1 = value2;
            value2 = temp;
            }

        static T Foo <T>()
        {
            if (default(T) == null)
            {
				Console.WriteLine("null");
            }
            return default(T);
        }

		static void Main(string[] args)
        {
            int s = 13, v = 3;
            double f = 12.3, ff = 3.12;

            float flo = 12.5f;
            double dflo = (double)flo;
			Console.WriteLine(flo.GetType());


			SwapGeneric(ref s, ref v);

            string s1 = "abc", s2 = "def";
            char c1 = 'a', c2 = 'b';

			SwapGeneric(ref s1, ref s2);

			SwapGeneric(ref c1, ref c2);

			Console.WriteLine(Foo<string>());


		}
	}
}
