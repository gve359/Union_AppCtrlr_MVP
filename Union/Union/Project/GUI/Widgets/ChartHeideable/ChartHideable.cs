 
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

using Project.Infrastructure;

namespace Project.GUI.Widgets.ChartHeideable
{	
	public partial class ChartHideable : UserControl, IChartHideable, I2DSizeable
	{				
		private DataTable table;


        private Scopes sX { get; set; }
        private Scopes sY { get; set; }

        public Scopes ScopeX
        {
            get { return this.sX; }
            set { this.sX = value;
                  this.UpdateScales();
                }
        }
        public Scopes ScopeY
        {
            get { return this.sY; }
            set { this.sY = value;
                  this.UpdateScales();
                }
        }


		public DataTable TableSource 
		{
			get{ return this.table; }
			set{ if(value == null)                 
                    this.ClearAll();                 
                 else 
                    this.SetDataTable(value); 
               }
		}

        public ChartHideable()
		{
			InitializeComponent();
            this.ClearAll();
            this.sX = new Scopes(double.NaN, double.NaN); //авторазмер
            this.sY = new Scopes(double.NaN, double.NaN);
		}
						
		private void SetDataTable(DataTable table)
		{
            if ((this.table != null) && 
                (IsEqualColumnNamesTwoTables(this.table, table)) // вставляется таблица с такими-же колонками
                )
            {                
                this.table = table;
                foreach (string item in this.checkedListBox1.CheckedItems)                
                    this.UpdateSeriaPoints(item);
            }
            else
            {
                this.ClearAll();
                this.table = table;
                this.SetHeadersSeries();
            }
		}
		
		public void ClearAll()
		{
			this.chart1.Series.Clear();
			this.checkedListBox1.Items.Clear();						
			this.table = null;			
		}
		
		
		
		public void SetChecked_Series(bool boxValue)
		{
			for(int i = 0; i < this.checkedListBox1.Items.Count; i++)
				this.checkedListBox1.SetItemChecked (i, boxValue);			
		}
				
		public void SetChecked_Series(int[] indexes, bool boxValue)
		{
			for(int i = 0; i < this.checkedListBox1.Items.Count; i++)
			{
				if (indexes.Contains(i))
					this.checkedListBox1.SetItemChecked (i, boxValue);
			}						
		}
		
		public  void SetChecked_Series(string[] captions, bool boxValue) 
		{   //осторожно checkedListBox не предполагает уникальность названий checkbox-ов
			
			for(int i = 0; i < this.checkedListBox1.Items.Count; i++)
			{
				string itemName = checkedListBox1.GetItemText(checkedListBox1.Items[i]);
				if (captions.Contains(itemName) )
					this.checkedListBox1.SetItemChecked (i, boxValue);
			}			
		}
		
		public CheckboxCodition[] GetDataAboutShowSeries() // получить список выборок, и их состояний(стоит ли глака в чекбоксе)
		{			
			List<CheckboxCodition> result = new List<CheckboxCodition>();
									
			for(int i = 0; i < this.checkedListBox1.Items.Count; i++)
			{
				result.Add( new CheckboxCodition()
				            { index = i,
							  caption = checkedListBox1.GetItemText(checkedListBox1.Items[i]),
							  value = checkedListBox1.GetItemChecked(i)
				            });
			}
							
			return result.ToArray();	
		}
		
		
		
		private void SetHeadersSeries()
		{
			foreach (DataColumn column in this.table.Columns) 
			{
				this.checkedListBox1.Items.Add(column.ColumnName);
				this.chart1.Series.Add(column.ColumnName);
			}			
		}			
		
	
        private void UpdateSeriaPoints(string seriaName)
        {
            this.chart1.Series[seriaName].Points.Clear();

            for (int x = 0; x <= this.table.Rows.Count - 1; x++)            
            {                        
                DataRow row = this.table.Rows[x];
                if (row[seriaName] != DBNull.Value)
                {
                    int y = Convert.ToInt32(row[seriaName]);
                    DataPoint point = new DataPoint(x+1, y);
                    this.chart1.Series[seriaName].Points.Add(point);                    
                }
            }
            this.chart1.Series[seriaName].Label = "#VALY";
        }
		
		private void RepaintChart_ForOnItemChecked(ItemCheckEventArgs e)
		{					
			string seriaName = Convert.ToString(checkedListBox1.Items[e.Index]);
			
			if(e.NewValue == CheckState.Checked)
			    this.UpdateSeriaPoints(seriaName);
						
			if(e.NewValue == CheckState.Unchecked)
			    this.chart1.Series[seriaName].Points.Clear();			
		}
		
		void CheckedListBox1ItemCheck(object sender, ItemCheckEventArgs e)
		{
			this.RepaintChart_ForOnItemChecked(e);
		}
     
        
        private bool IsEqualColumnNamesTwoTables(DataTable table1, DataTable table2)
        {
            HashSet<string> columnNamesTable1 = new HashSet<string>();
            foreach(DataColumn column in table1.Columns)
            {
                columnNamesTable1.Add(column.ColumnName);
            }

            HashSet<string> columnNamesTable2 = new HashSet<string>();
            foreach (DataColumn column in table2.Columns)
            {
                columnNamesTable2.Add(column.ColumnName);
            }

            bool result = columnNamesTable1.SetEquals(columnNamesTable2);

            return result;
        }

        private void UpdateScales()
        {
            this.chart1.ChartAreas[0].AxisX.Minimum = this.ScopeX.a;
            this.chart1.ChartAreas[0].AxisX.Maximum = this.ScopeX.b;
            this.chart1.ChartAreas[0].AxisY.Minimum = this.ScopeY.a;
            this.chart1.ChartAreas[0].AxisY.Maximum = this.ScopeY.b;
        }
    }
}

