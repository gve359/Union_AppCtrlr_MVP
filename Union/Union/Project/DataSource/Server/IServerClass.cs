
using System;
using System.Data;
using System.Collections.Generic;

using Project.Infrastructure;
using Project.DataSource.Meter;

namespace Project.DataSource
{
    public delegate void D_TableUpdated(DataTable table);

	public interface IServerClass
	{
		ITimer Timer {get;}
		Dictionary<string, IMeter> Meters {get; set;}

        event D_TableUpdated TableUpdated;
		DataTable GetTableMetrics(int countTopRows);
        int CountRowsInTable_forTableUpdated { get; set; }
	}
}
