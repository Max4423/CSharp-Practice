using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_IEnumerator
{
	internal class NumberEnumerator : IEnumerator<int>
	{
		private readonly int _start;
		private readonly int _count;
		private int _currentIndex;

		public NumberEnumerator(int start, int count)
		{
			_start = start;
			_count = count;
			_currentIndex = -1;
		}

		public int Current
		{
			get
			{
				if (_currentIndex < 0 || _currentIndex >= _count)
				{
					throw new InvalidDataException();
				}

				return _start + _currentIndex;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				return Current;
			}
		}


		public bool MoveNext()
		{
			if (_currentIndex + 1 < _count)
			{
				_currentIndex++;
				return true;
			}

			return false;
		}

		public void Reset()
		{
			_currentIndex = -1;
		}

		public void Dispose()
		{

		}
	}
}
