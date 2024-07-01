using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.GUI.Pages.PageSettings
{
    public interface IPageSettings
    {
        event Action Applied;
        event Action Canceled;

        //MembersOfCharts
        bool IsShowAllSeries_inFirstSetting { get; set; }
        bool IsShowNewSeria { get; set; }
        double ScopeXa { get; set; }
        double ScopeXb { get; set; }
        double ScopeYa { get; set; }
        double ScopeYb { get; set; }
        
        //MembersOfServer
        int DelayUpdate { get; set; }
        int CountRowsInTable_forTableUpdated { get; set; }
    }
}
