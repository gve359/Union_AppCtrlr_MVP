using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.Infrastructure;

namespace Project.GUI.Widgets.ChartRealtime
{
    public class Factory_ChartRealtime : IFactory_ChartRealtime
    {
        public AChartRealtime Get_Chart_Realtime(bool isShowAllSeries_inFirstSetting, bool isShowNewSeria)
        {
            return new ChartRealtime(isShowAllSeries_inFirstSetting, isShowNewSeria);
        }

        public AChartRealtime Get_Chart_Realtime(bool isShowAllSeries_inFirstSetting, bool isShowNewSeria, Scopes scopesX, Scopes scopesY)
        {            
            AChartRealtime result = new ChartRealtime(isShowAllSeries_inFirstSetting, isShowNewSeria)
            {
                ScopeX = scopesX,
                ScopeY = scopesY
            };
            return result;            
        }
    }
}
