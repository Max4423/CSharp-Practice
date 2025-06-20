using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator
{
	 class NumberSequence:IEnumerable<int>
	{
		private readonly int _start;
		private readonly int _count;

		public NumberSequence(int start, int count)
		{
			_start = start;
			_count = count;
		}

		public IEnumerator<int> GetEnumerator()
		{
			{
				return new NumberEnumerator(_start, _count);

			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
