using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Project.GUI.Pages.PageMain;
using Project.DataSource;
using Project.DataSource.Meter;

namespace Project.ClassRelations
{
    public class Relation__PageMain_Server
    {
        public Relation__PageMain_Server(APageMain viewMain, IServerClass server, IFactory_Meter factoryMeters)
        {
            viewMain.Invoked_StartServer += () => {server.Timer.Start(); };
            viewMain.Invoked_StopServer  += () => {server.Timer.Stop();  };
            viewMain.Invoked_AddMeter += (string obj) => { server.Meters.Add(obj, factoryMeters.GetMeter()); };
            viewMain.Invoked_RemoveMeter += (string obj) => {server.Meters.Remove(obj); };
        }
    }
}
