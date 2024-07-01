using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using Project.Infrastructure;

namespace Project.GUI.Widgets.ChartRealtime
{
    public abstract class AChartRealtime : UserControl, IChartRealtime, I2DSizeable
    {
        public abstract bool IsShowAllSeries_inFirstSetting { get; set; }
        public abstract bool IsShowNewSeria { get; set; }

        public abstract void SetTable(DataTable table);
        public abstract void Reset();

        public abstract Scopes ScopeX { get; set; }
        public abstract Scopes ScopeY { get; set; }
    }
}
