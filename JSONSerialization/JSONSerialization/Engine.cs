using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONSerialization
{
	public class Engine
	{
		public int CylindersNumber { get; set; } = 4;
		public double Volume { get; set; }

	
	public Engine(int CylindersNumber, double Volume)
		{
			this.CylindersNumber = CylindersNumber;
			this.Volume = Volume;
		}
	}
}
