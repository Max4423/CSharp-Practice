using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Generics;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
namespace Benchmark
{
	public class BenchmarkSwaps
	{
		[Benchmark]
		public void BenchmarkSwapGeneric()
		{
			double a = 12.4;
			double b = 1.5;
			Program2.SwapGeneric(ref a, ref b);
		}

		[Benchmark]
		public void BenchmarkSwap()
		{
			object a = 12.4;
			object b = 1.5;
			Program2.Swap(ref a, ref b);

			
		}


	}
}
