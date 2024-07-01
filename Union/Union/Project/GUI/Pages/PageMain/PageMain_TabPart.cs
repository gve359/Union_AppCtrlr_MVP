using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.GUI.Pages.PageMain
{
    public partial class PageMain
    {
        public override void SetContent(Object content)
        {
            UserControl _content = content as UserControl;            
            this.SetContentOnNewTab(_content);
        }

        public void SetContentOnNewTab(UserControl content)
        {
            this.CreateNewTab();
            this.SetContentOnLastTab(content);
        }

        private void SetContentOnLastTab(UserControl content)
        {
            TabPage newTabPage = this.tabControlX1.TabPages[this.tabControlX1.TabPages.Count - 1];
            newTabPage.Controls.Add(content);
        }

        public void CreateNewTab()
        {
            this.tabControlX1.TabPages.Add(tabCounter.GetNewTabName());            
        }
    }

    public class TabCounter
    {
        private int i = 0;

        public string GetNewTabName()
        {
            i++;
            string newTabName = "Tab " + i.ToString();
            return newTabName;
        }
    }    
}
