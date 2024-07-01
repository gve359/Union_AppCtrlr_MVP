using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project.GUI.Pages.PageMain
{
    public abstract class APageMain : Form, IViewMain
    {        
        public abstract event Action Invoked_StopServer;
        public abstract event Action Invoked_StartServer;
        public abstract event Action<string> Invoked_AddMeter;
        public abstract event Action<string> Invoked_RemoveMeter;
        public abstract event Action Invoked_AddChart;
        public abstract event Action Invoked_Settings;        

        public abstract void SetContent(Object content);
    }
}
