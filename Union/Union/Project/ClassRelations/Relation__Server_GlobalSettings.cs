using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.DataSource;
using Project;

namespace Project.ClassRelations
{
    public class Relation__Server_GlobalSettings
    {
        public Relation__Server_GlobalSettings(IServerClass server, GlobalSettings globalSettings)
        {
            globalSettings.ServerSettings.DelayUpdate_Changed += (TimeSpan obj) =>
            { server.Timer.delay = obj; };
            globalSettings.ServerSettings.CountRowsInTable_forTableUpdated_Changed += (int obj) =>
            { server.CountRowsInTable_forTableUpdated = obj; };
        }
    }
}
