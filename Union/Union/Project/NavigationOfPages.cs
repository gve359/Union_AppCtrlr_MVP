using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.DataSource;
using Project.GUI.Pages.PageMain;
using Project.GUI.Windows;
using Project.GUI.Pages.PageSettings;

namespace Project
{
    public class NavigationOfPages
    {
        public NavigationOfPages (WindowMain windowMain, APageMain pageMain, APageSettings pageSettings)
        {
            pageMain.Invoked_Settings += () => { windowMain.SetContent(pageSettings); };

            pageSettings.Applied += () => { windowMain.SetContent(pageMain); };
            pageSettings.Canceled += () => { windowMain.SetContent(pageMain); };
        }
    }
}
