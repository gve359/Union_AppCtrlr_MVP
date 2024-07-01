using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.Infrastructure;

namespace Project.GUI.Widgets.ChartRealtime
{
    public interface IFactory_ChartRealtime
    {
        AChartRealtime Get_Chart_Realtime(bool isShowAllSeries_inFirstSetting, bool isShowNewSeria);
        AChartRealtime Get_Chart_Realtime(bool isShowAllSeries_inFirstSetting, bool isShowNewSeria, Scopes X, Scopes Y);
    }
}
