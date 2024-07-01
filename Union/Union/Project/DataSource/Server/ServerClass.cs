
using System;
using System.Data;
using System.Collections.Generic;

using Project.Infrastructure;
using Project.DataSource.DataKeeper;
using Project.DataSource.Meter;

namespace Project.DataSource
{
	public class ServerClass : IServerClass
	{
		private IDataKeeper dataKeeper;
		
		public ITimer Timer {get; private set;}
		public Dictionary<string, IMeter> Meters {get; set;}
		public event D_TableUpdated TableUpdated = delegate{};
        public int CountRowsInTable_forTableUpdated { get; set; }
												
		private void Initialization(ITimer timer, IDataKeeper dataKeeper)
		{
			this.Timer = timer;
			this.dataKeeper = dataKeeper;
            this.CountRowsInTable_forTableUpdated = 10;
		}
					
		public ServerClass(ITimer timer, IDataKeeper dataKeeper)
		{
			this.Initialization(timer, dataKeeper);
			
			this.Timer.Ticked += () => {
				this.dataKeeper.SetLineMetric(this.GetLineMetrics());
                DataTable table = GetTableMetrics(this.CountRowsInTable_forTableUpdated);
                this.TableUpdated(table);
			};						
		}

        public DataTable GetTableMetrics(int countTopRows)
		{
            return this.dataKeeper.GetTableMetric(countTopRows);
		}

        public Dictionary<string, double> GetLineMetrics()
		{
            Dictionary<string, double> result = new Dictionary<string, double>();
									
			foreach (string meterName in this.Meters.Keys)
			    result.Add(meterName, this.Meters[meterName].GetMetric());
						
			return result;
		}
           
    }
}
