
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

using Project.Infrastructure;
using Project.DataSource;
using Project.GUI;
using Project.GUI.Pages.PageMain;
using Project.GUI.Windows;
using Project.GUI.Pages.PageSettings;
using Project.GUI.Widgets.ChartRealtime;
using Project.DataSource.Meter;
using Project.DataSource.DataKeeper;
using Project.DataSource.Server;

namespace Project
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            GlobalSettings globalSettings = new GlobalSettings();
            IFactory_Meter factory_meters = new Factory_Meter();
            IServerClass server = new Factory_Server() { globalSettings = globalSettings }.Get_IServerClass(factory_meters);
            APageMain pageMain = new Factory_APageMain().Get_APageMain();
            APageSettings pageSettings = new Factory_APageSettings().Get_APageSettings();

            ApplicationController applicationController = new ApplicationController(globalSettings, new WindowMain(), server,
                                                                                    pageMain, pageSettings, 
                                                                                    new Factory_ChartRealtime(), factory_meters);
            Application.Run(applicationController);
		}
		
	}
}

