using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project.GUI.Widgets.ChartRealtime
{
    public interface IChartRealtime
    {
        bool IsShowAllSeries_inFirstSetting { get; set; }
        bool IsShowNewSeria { get; set; }

        void SetTable(DataTable table);
        void Reset();
    }
}
