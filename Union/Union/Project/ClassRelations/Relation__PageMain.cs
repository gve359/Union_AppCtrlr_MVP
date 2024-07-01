using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.GUI;
using Project.GUI.Pages.PageMain;
using Project.DataSource;
using Project.ClassRelations;
using Project.GUI.Widgets.ChartRealtime;

namespace Project.ClassRelations
{
    // Считаю это связью объекта APageMain самого с собой.
    // Т.к. здесь описано его поведение от своих-же событий. 
    // А может унаслеовать APageMain и не нужна будет такая связь? Тогда получившийся класс перестанет быть автономным, т.к. будет знать о соседних классах программы.
    // А может сделать контейрер, включающий APageMain? Так от оболочки не требуется никаких методов и свойств. Так-что снова нет.

    public class Relation__PageMain
    {
        public Relation__PageMain(APageMain viewMain, GlobalSettings globalSettings, IFactory_ChartRealtime factory_ChartRealtime, IServerClass server)
        {
            viewMain.Load += (object sender, EventArgs e) => { AddChart(viewMain, globalSettings, factory_ChartRealtime, server); };
            viewMain.Invoked_AddChart += ()               => { AddChart(viewMain, globalSettings, factory_ChartRealtime, server); };
        }

        private void AddChart(APageMain viewMain, GlobalSettings globalSettings, IFactory_ChartRealtime factory_ChartRealtime, IServerClass server)
        {
            var chart = factory_ChartRealtime.Get_Chart_Realtime(globalSettings.ChartSettings.IsShowAllSeries_inFirstSetting,
                                                                 globalSettings.ChartSettings.IsShowNewSeria,
                                                                 globalSettings.ChartSettings.ScopesX,
                                                                 globalSettings.ChartSettings.ScopesY);
            new Relation__ChartRealTime_GlobalSettings(chart, globalSettings);
            new Relation__ChartRealTime_Server(chart, server);
            viewMain.SetContent(chart);
        }

    }
}
