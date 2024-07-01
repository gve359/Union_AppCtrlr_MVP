
using System;

namespace Project.DataSource.Meter
{		
	public class Meter_Mock : IMeter		
	{
		private Random random;
		
		public Meter_Mock()
		{
            this.random = new Random();         
		}
        public Meter_Mock(int seed)
        {
            this.random = new Random(seed);
        }
						
		public double GetMetric()
		{	
			return this.random.Next(0,100);
		}
	}
}