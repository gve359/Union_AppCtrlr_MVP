using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.GUI.Pages.PageSettings
{
    public class Factory_APageSettings
    {
        public APageSettings Get_APageSettings()
        {
            APageSettings pageMain = new PageSettings();
            pageMain.TopLevel = false;
            pageMain.AutoScroll = true;
            pageMain.FormBorderStyle = FormBorderStyle.None;
            pageMain.Dock = DockStyle.Fill;

            return pageMain;
        }
    }
}
