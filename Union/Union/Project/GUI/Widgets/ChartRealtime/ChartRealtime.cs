using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Project.Infrastructure;

namespace Project.GUI.Widgets.ChartRealtime
{
    public partial class ChartRealtime : AChartRealtime // UserControl, IChartRealtime // //AChartRealtime 
    {
        //private IChartHideable chartHideable; //находится на форме в качестве ChartHideable1
        private bool isTableSetted;

        public override bool IsShowAllSeries_inFirstSetting { get; set; }
        public override bool IsShowNewSeria { get; set; }

        public override Scopes ScopeX
        {
            get { return this.ChartHideable1.ScopeX; }
            set { this.ChartHideable1.ScopeX = value; }
        }
        public override Scopes ScopeY
        {
            get { return this.ChartHideable1.ScopeY; }
            set { this.ChartHideable1.ScopeY = value; }
        }

        public ChartRealtime(bool isShowAllSeries_inFirstSetting, bool isShowNewSeria)
        {            
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.IsShowAllSeries_inFirstSetting = isShowAllSeries_inFirstSetting;
            this.IsShowNewSeria = isShowNewSeria;
            this.isTableSetted = false;
        }

        private void SetBeginTable(DataTable table)
        {     
            this.ChartHideable1.TableSource = table;
            this.ChartHideable1.SetChecked_Series(this.IsShowAllSeries_inFirstSetting);
        }

        private void UpdateTable(DataTable newTable)
        {            
            // а теперь найдём какие выборки отобразить на диаграмме            
            string[] showedSeriesOldTable = this.ChartHideable1.GetDataAboutShowSeries().Where(x => x.value == true).Select(x => x.caption).ToArray();
            string[] columnNamesOldTable = this.ChartHideable1.TableSource.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            string[] columnNamesNewTable = newTable.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();


            // вычтем из списка показанных выборок отсутствующие столбцы из новой таблицы 
            string[] baseSeriesForShow = showedSeriesOldTable.Where(x => columnNamesNewTable.Contains(x)).ToArray(); //(showedSeriesOldTable & columnNamesNewTable)

            string[] result = (this.IsShowNewSeria)
                               ? baseSeriesForShow.Union(
                                    columnNamesNewTable.Where(x => !columnNamesOldTable.Contains(x))
                                 ).ToArray() // дополним baseSeriesForShow новыми столбцами новой таблицы
                               : baseSeriesForShow;
            
            this.ChartHideable1.TableSource = newTable;
            this.ChartHideable1.SetChecked_Series(result, true);            
        }


        public override void SetTable(DataTable table)
        {
            if (this.isTableSetted)            
                this.UpdateTable(table);            
            else
            {
                this.SetBeginTable(table);
                this.isTableSetted = true;
            }
        }

        public override void Reset()
        {
            this.ChartHideable1.ClearAll();            
            this.isTableSetted = false;
        }


    }
}
