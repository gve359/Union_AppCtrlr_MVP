using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Project.GUI.Widgets.ChartHeideable
{
    public class Factory_ChartHideable : IFactory_ChartHideable
    {
        public IChartHideable Get_IChartHideable()
        {
            var result = new ChartHideable();
            result.Dock = DockStyle.Fill;

            return result;
        }
    }
}
