using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.GUI.Pages.PageSettings
{
    public partial class PageSettings : APageSettings //Form, IPageSettings  // 
    {
        public override event Action Applied = delegate { };
        public override event Action Canceled = delegate { };

        public PageSettings()
        {
            InitializeComponent();
        }

        public override double ScopeXa 
        {
            get { return Convert.ToDouble(this.textBox2.Text); }
            set { this.textBox2.Text = value.ToString(); }
        }
        public override double ScopeXb 
        {
            get { return Convert.ToDouble(this.textBox3.Text); }
            set { this.textBox3.Text = value.ToString(); }
        }
        public override double ScopeYa 
        {
            get { return Convert.ToDouble(this.textBox4.Text); }
            set { this.textBox4.Text = value.ToString(); }
        }
        public override double ScopeYb 
        {
            get { return Convert.ToDouble(this.textBox5.Text); }
            set { this.textBox5.Text = value.ToString(); }
        }
        

        private void применитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Applied();
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Canceled();
        }

        public override bool IsShowAllSeries_inFirstSetting
        {
            get { return this.checkBox1.Checked; }
            set { this.checkBox1.Checked = value; }
        }

        public override bool IsShowNewSeria
        {
            get { return this.checkBox2.Checked; }
            set { this.checkBox2.Checked = value; }
        }

        public override int DelayUpdate 
        {
            get { return Convert.ToInt16(this.textBox1.Text); }
            set { this.textBox1.Text = value.ToString(); }
        }

        public override int CountRowsInTable_forTableUpdated
        {
            get { return Convert.ToInt16(this.textBox6.Text); }
            set { this.textBox6.Text = value.ToString(); }
        }        
    }
}