
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

using Project.DataSource.Tables;

namespace Project.DataSource.DataKeeper
{
	public class Adapter_Datatable : IDataKeeper
	{		
		private DataTable_Metrics table;
		private int idCount;			

        public Adapter_Datatable()
		{
			this.table = new DataTable_Metrics();			
			this.idCount = 0;
		}
        
        public DataTable GetTableMetric(int countTopRows)
		{
            DataTable result = this.table.Clone();

            // скопировуем указанное количество последних строк
            DataRow[] selectedRows = this.table.AsEnumerable().OrderByDescending(x => x["id"]).Take(countTopRows).ToArray();
            foreach (DataRow row in selectedRows)
                result.ImportRow(row);
            
            // удалим столбцы с отключенными счётчиками
            DataColumn[] noUseColumns = result.Columns.Cast<DataColumn>()
                                        .Where(column => result.Rows[0][column] == DBNull.Value)                                        
                                        .ToArray();
            foreach (DataColumn column in noUseColumns)
                result.Columns.Remove(column);            

            // удалим id            
            result.PrimaryKey = new DataColumn[] { };
            result.Columns.Remove("id");

            return result;
		}
		
			   
		public void SetLineMetric (Dictionary<string, double> lineMetric)
		{								
			this.AddColumnsTable(lineMetric);
			this.AddDataRow_By_lineMetric(lineMetric);                     
		}
		
		private void AddDataRow_By_lineMetric(Dictionary<string, double> lineMetric)
		{
			DataRow row = this.table.NewRow();
			
			row["id"] = this.idCount;
			this.idCount++;
			
			foreach (string columnName in lineMetric.Keys) 
			{
				row[columnName] = lineMetric[columnName];
			}
				
			this.table.Rows.Add(row);
			this.table.AcceptChanges();
		}
		
		
		private void AddColumnsTable(Dictionary<string, double> lineMetric)
		{
			foreach(string columnName in lineMetric.Keys)
			{
				if( !this.table.Columns.Contains(columnName) )
					this.table.Columns.Add(columnName, typeof(double));
			}
		}
	}
}

