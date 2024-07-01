
using System;
using System.Data;

using Project.Infrastructure;

namespace Project.GUI.Widgets.ChartHeideable
{
	public struct CheckboxCodition
	{
		public int index;
		public string caption;
		public bool value;
	}

    public interface IChartHideable
	{		
		DataTable TableSource {get; set;}
		void ClearAll();
		
		void SetChecked_Series(bool boxValue);
		void SetChecked_Series(int[] indexes, bool boxValue);
		void SetChecked_Series(string[] captions, bool boxValue);
		CheckboxCodition[] GetDataAboutShowSeries();	
	}
}
