using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.GUI;
using Project.DataSource;
using Project.GUI.Pages.PageSettings;

namespace Project.ClassRelations
{
    public class Relation__PageSettings_Server
    {
        public Relation__PageSettings_Server(APageSettings pageSettings, IServerClass server)
        {
            pageSettings.VisibleChanged += (object sender, EventArgs e) => 
            { if (pageSettings.Visible) server.Timer.Stop(); };

            pageSettings.Applied  += () => { server.Timer.Start(); };
            pageSettings.Canceled += () => { server.Timer.Start(); };
        }
    }
}
