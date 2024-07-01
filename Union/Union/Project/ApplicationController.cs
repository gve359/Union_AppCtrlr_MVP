
using System;
using System.Windows.Forms;
using System.Data;

using Project.DataSource;
using Project.GUI.Pages.PageMain;
using Project.GUI;
using Project.ClassRelations;
using Project.GUI.Windows;
using Project.GUI.Pages.PageSettings;
using Project.GUI.Widgets.ChartRealtime;
using Project.DataSource.Meter;

namespace Project
{
    public class ApplicationController : ApplicationContext
    {
        public ApplicationController(GlobalSettings globalSettings, WindowMain windowMain, IServerClass server, APageMain pageMain, APageSettings pageSettings, IFactory_ChartRealtime factory_ChartRealtime, IFactory_Meter factoryMeters)
        {
            new Relation__PageMain(pageMain, globalSettings, factory_ChartRealtime, server);
            new Relation__PageMain_Server(pageMain, server, factoryMeters);
            new Relation__PageSettings_GlobalSettings(pageSettings, globalSettings);
            new Relation__Server_GlobalSettings(server, globalSettings);
            new Relation__PageSettings_Server(pageSettings, server);
            new NavigationOfPages(windowMain, pageMain, pageSettings);
            this.PrepareToExit(windowMain, server);
            this.PrepareToRun(windowMain, pageMain, server);
        }

        private void PrepareToExit(WindowMain windowMain, IServerClass server)
        {
            windowMain.FormClosed += (object sender, FormClosedEventArgs e) =>
            {
                server.Timer.Stop();
                Application.Exit();
            };
        }

        private void PrepareToRun(WindowMain windowMain, APageMain pageMain, IServerClass server)
        {
            windowMain.SetContent(pageMain);
            windowMain.Show();
            server.Timer.Start();
        }
    }
}
