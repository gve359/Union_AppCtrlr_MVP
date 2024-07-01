using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project.GUI.Pages.PageMain
{
    public class Factory_APageMain
    {
        public APageMain Get_APageMain()
        {
            APageMain pageMain = new PageMain();
            pageMain.TopLevel = false;
            pageMain.AutoScroll = true;
            pageMain.FormBorderStyle = FormBorderStyle.None;
            pageMain.Dock = DockStyle.Fill;

            return pageMain;
        }
    }
}
