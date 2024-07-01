using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.Infrastructure;

namespace Project
{
    public class ServerSettings
    {
        public event Action<int> CountRowsInTable_forTableUpdated_Changed = delegate { };
        private int countRowsInTable_forTableUpdated;
        public int CountRowsInTable_forTableUpdated 
        {
            get { return this.countRowsInTable_forTableUpdated; }
            set { this.countRowsInTable_forTableUpdated = value;
                  this.CountRowsInTable_forTableUpdated_Changed(this.countRowsInTable_forTableUpdated);
                }
        }


        public event Action<TimeSpan> DelayUpdate_Changed = delegate { };
        private TimeSpan delayUpdate;
        public TimeSpan DelayUpdate 
        {
            get { return this.delayUpdate; }
            set
            {
                this.delayUpdate = value;
                this.DelayUpdate_Changed(this.delayUpdate);
            }
        }
    }

    public delegate void D_Scopes_Changed (Scopes X, Scopes Y);
    public class ChartSettings
    {
        public event D_Scopes_Changed Scopes_Changed = delegate { };

        private Scopes scopesX;
        public Scopes ScopesX
        {
            get { return this.scopesX; }
            set { this.scopesX = value;
                  this.Scopes_Changed(this.scopesX, this.scopesY);
                }
        }

        private Scopes scopesY;
        public Scopes ScopesY
        {
            get { return this.scopesY; }
            set { this.scopesY = value;
                  this.Scopes_Changed(this.scopesX, this.scopesY);
                }
        }

        



        public event Action<bool> IsShowAllSeries_inFirstSetting_Changed = delegate { };
        private bool isShowAllSeries_inFirstSetting;
        public bool IsShowAllSeries_inFirstSetting
        {
            get { return this.isShowAllSeries_inFirstSetting; }
            set { this.isShowAllSeries_inFirstSetting = value;
                  this.IsShowAllSeries_inFirstSetting_Changed(this.isShowAllSeries_inFirstSetting);
                }
        }

        public event Action<bool> IsShowNewSeria_Changed = delegate { };
        private bool isShowNewSeria;
        public bool IsShowNewSeria
        {
            get { return this.isShowNewSeria; }
            set { this.isShowNewSeria = value;
                  this.IsShowNewSeria_Changed(this.isShowNewSeria);
                }
        }        
    }

    public class GlobalSettings
    {
        public ChartSettings ChartSettings {get; set;}
        public ServerSettings ServerSettings { get; set; }

        public GlobalSettings()
        {
            // на этом месте обычно стоит загрузка настроек из файла.
            this.ChartSettings = new ChartSettings()
            {
                IsShowAllSeries_inFirstSetting = true,
                IsShowNewSeria = false,
                ScopesX = new Scopes(0, 11),
                ScopesY = new Scopes(0, 100)
            };

            this.ServerSettings = new ServerSettings()
            {
                DelayUpdate = new TimeSpan(0, 0, 1),
                CountRowsInTable_forTableUpdated = 10
            };
        }
    }
}
