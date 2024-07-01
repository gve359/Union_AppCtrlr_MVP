
using System;
using System.Data;
using System.Collections.Generic;

namespace Project.DataSource.DataKeeper
{
	/// <summary>
    /// Это интерфейс класса, который взаимодействует с хранилищем данных (базой/файлом/dataTable)    
	/// </summary>
	
	public interface IDataKeeper
	{
        void SetLineMetric(Dictionary<string, double> lineMetric);

        DataTable GetTableMetric(int countTopRows);        	
	}
}
