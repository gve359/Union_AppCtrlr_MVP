using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.GUI;
using Project;
using Project.GUI.Widgets.ChartRealtime;
using Project.Infrastructure;

namespace Project.ClassRelations
{
    public class Relation__ChartRealTime_GlobalSettings
    {
        private AChartRealtime chart;
        private GlobalSettings globalSettings;

        public Relation__ChartRealTime_GlobalSettings(AChartRealtime chart, GlobalSettings globalSettings)
        {
            this.chart = chart;            
            this.globalSettings = globalSettings;


            this.globalSettings.ChartSettings.IsShowAllSeries_inFirstSetting_Changed += OnIsShowAllSeries_inFirstSetting_Changed;
            this.globalSettings.ChartSettings.IsShowNewSeria_Changed += OnIsShowNewSeria_Changed;
            this.globalSettings.ChartSettings.Scopes_Changed += ChartSettings_Scopes_Changed;

            this.chart.Disposed += Destroy;
        }

        void ChartSettings_Scopes_Changed(Scopes scopeX, Scopes scopeY)
        {
            this.chart.ScopeX = scopeX;
            this.chart.ScopeY = scopeY;
        }

        void OnIsShowNewSeria_Changed(bool obj)
        {
            this.chart.IsShowNewSeria = obj;
        }

        void OnIsShowAllSeries_inFirstSetting_Changed(bool obj)
        {
            this.chart.IsShowAllSeries_inFirstSetting = obj;
        }

        void Destroy(object sender, EventArgs e)
        {         
            this.globalSettings.ChartSettings.IsShowAllSeries_inFirstSetting_Changed -= OnIsShowAllSeries_inFirstSetting_Changed;
            this.globalSettings.ChartSettings.IsShowNewSeria_Changed -= OnIsShowNewSeria_Changed;
            this.globalSettings.ChartSettings.Scopes_Changed -= ChartSettings_Scopes_Changed;           

            this.chart.Disposed -= Destroy;
        }

    }
}
