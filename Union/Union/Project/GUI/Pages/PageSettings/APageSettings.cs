using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.GUI.Pages.PageSettings
{
    public abstract class APageSettings : Form, IPageSettings
    {
        public abstract event Action Applied;
        public abstract event Action Canceled;

        public abstract bool IsShowAllSeries_inFirstSetting { get; set; }
        public abstract bool IsShowNewSeria { get; set; }
        public abstract double ScopeXa { get; set; }
        public abstract double ScopeXb { get; set; }
        public abstract double ScopeYa { get; set; }
        public abstract double ScopeYb { get; set; }

        public abstract int DelayUpdate { get; set; }
        public abstract int CountRowsInTable_forTableUpdated { get; set; }
    }
}
