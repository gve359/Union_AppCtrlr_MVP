using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.DataSource.Meter;
using Project.DataSource.DataKeeper;
using Project.Infrastructure;

namespace Project.DataSource.Server
{
    public class Factory_Server
    {
        public GlobalSettings globalSettings { get; set; }

        public IServerClass Get_IServerClass(IFactory_Meter factory_meters)
        {
            ServerClass server = new ServerClass(new TimerSynchron(), new Adapter_Datatable());

            if (globalSettings != null)
                server.CountRowsInTable_forTableUpdated = globalSettings.ServerSettings.CountRowsInTable_forTableUpdated;

            Dictionary<string, IMeter> meters = new Dictionary<string, IMeter>();
            meters.Add("Счётчик01", factory_meters.GetMeter());
            meters.Add("Счётчик02", factory_meters.GetMeter());
            meters.Add("Счётчик03", factory_meters.GetMeter());
            meters.Add("Счётчик04", factory_meters.GetMeter());
            meters.Add("Счётчик05", factory_meters.GetMeter());
            meters.Add("Счётчик06", factory_meters.GetMeter());
            meters.Add("Счётчик07", factory_meters.GetMeter());
            //meters.Add("Счётчик08", factory_meters.GetMeter());
            //meters.Add("Счётчик09", factory_meters.GetMeter());            
            //meters.Add("Счётчик10", factory_meters.GetMeter());
            server.Meters = meters;
            
            return server;
        }
    }
}