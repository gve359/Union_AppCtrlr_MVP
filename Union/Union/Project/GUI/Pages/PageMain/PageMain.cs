using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Project.Infrastructure;

namespace Project.GUI.Pages.PageMain
{
    public partial class PageMain :  APageMain //Form, IViewMain
    {
        public override event Action Invoked_StopServer = delegate { };
        public override event Action Invoked_StartServer = delegate { };
        public override event Action<string> Invoked_AddMeter = delegate { };
        public override event Action<string> Invoked_RemoveMeter = delegate { };
        public override event Action Invoked_AddChart = delegate { };
        public override event Action Invoked_Settings = delegate { };

        private TabCounter tabCounter;
           

        public PageMain()
        {
            InitializeComponent();

            this.tabCounter = new TabCounter();
            this.tabControlX1.TabPages.Clear();
        }

        private void приостановитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Invoked_StopServer();
        }

        private void включитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Invoked_StartServer();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titleNewMeter = Microsoft.VisualBasic.Interaction.InputBox("Введите название счётчика", "Добавление счётчика", "", 0, 0);
            if (titleNewMeter != "")
                this.Invoked_AddMeter(titleNewMeter);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titleNewMeter = Microsoft.VisualBasic.Interaction.InputBox("Введите название счётчика", "Удаление счётчика", "", 0, 0);
            if (titleNewMeter != "")
                this.Invoked_RemoveMeter(titleNewMeter);
        }

        private void добавитьДиаграммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Invoked_AddChart();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Invoked_Settings();
        }

    }
}
