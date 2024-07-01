
using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;


namespace Project.DataSource.Tables
{
	public class DataTable_Metrics : DataTable
	{
		public DataColumn ColumnID 
		{
			get{ return this.Columns["id"];}
		}		
		public DataColumn[] ColumnsBody 
		{
			get{ return this.Columns.Cast<DataColumn>().Where( x => x.ColumnName != this.ColumnID.ColumnName ).ToArray();  }
		}		
		
		
		public DataTable_Metrics()
		{
			this.Columns.Add("id", typeof(int));
			this.PrimaryKey = new DataColumn[] { this.Columns["id"] };						
			
			this.AcceptChanges();
		}
					
		public void AddColumnBody(string columnName)
		{
			this.Columns.Add(columnName, typeof(double));
			this.AcceptChanges();
		}
	}

}
