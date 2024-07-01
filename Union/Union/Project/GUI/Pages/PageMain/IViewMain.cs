using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.Infrastructure;

namespace Project.GUI.Pages.PageMain
{
    public interface IViewMain : IContainer
    {
        event Action Invoked_StopServer;
        event Action Invoked_StartServer;
        event Action<string> Invoked_AddMeter;
        event Action<string> Invoked_RemoveMeter;
        event Action Invoked_AddChart;
        event Action Invoked_Settings;
    }
}
