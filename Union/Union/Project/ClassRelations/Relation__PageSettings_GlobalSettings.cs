using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.GUI;
using Project;
using Project.GUI.Pages.PageSettings;
using Project.Infrastructure;

namespace Project.ClassRelations
{
    public class Relation__PageSettings_GlobalSettings
    {
        public Relation__PageSettings_GlobalSettings(APageSettings pageSettings, GlobalSettings globalSettings)
        {
            pageSettings.VisibleChanged += (object sender, EventArgs e) =>
            {
                if (pageSettings.Visible)
                {                    
                    pageSettings.IsShowAllSeries_inFirstSetting = globalSettings.ChartSettings.IsShowAllSeries_inFirstSetting;
                    pageSettings.IsShowNewSeria = globalSettings.ChartSettings.IsShowNewSeria;                    
                    pageSettings.ScopeXa = globalSettings.ChartSettings.ScopesX.a;
                    pageSettings.ScopeXb = globalSettings.ChartSettings.ScopesX.b;
                    pageSettings.ScopeYa = globalSettings.ChartSettings.ScopesY.a;
                    pageSettings.ScopeYb = globalSettings.ChartSettings.ScopesY.b;

                    pageSettings.DelayUpdate = Convert.ToInt16(globalSettings.ServerSettings.DelayUpdate.TotalSeconds);
                    pageSettings.CountRowsInTable_forTableUpdated = globalSettings.ServerSettings.CountRowsInTable_forTableUpdated;
                }
            };

            pageSettings.Applied += () =>
            {
                globalSettings.ChartSettings.IsShowAllSeries_inFirstSetting = pageSettings.IsShowAllSeries_inFirstSetting;
                globalSettings.ChartSettings.IsShowNewSeria = pageSettings.IsShowNewSeria;                
                globalSettings.ChartSettings.ScopesX = new Scopes(pageSettings.ScopeXa, pageSettings.ScopeXb);
                globalSettings.ChartSettings.ScopesY = new Scopes(pageSettings.ScopeYa, pageSettings.ScopeYb);

                globalSettings.ServerSettings.DelayUpdate = TimeSpan.FromSeconds(pageSettings.DelayUpdate);
                globalSettings.ServerSettings.CountRowsInTable_forTableUpdated = pageSettings.CountRowsInTable_forTableUpdated;
            };
        }

    }
}
