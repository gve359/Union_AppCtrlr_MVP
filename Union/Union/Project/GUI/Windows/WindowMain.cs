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

namespace Project.GUI.Windows
{
    public partial class WindowMain : Form, Project.Infrastructure.IContainer
    {
        public WindowMain()
        {
            InitializeComponent();
        }

        public void SetContent(object content)
        {
            Form _content = content as Form;
            this.ClearContent();

            if (!this.Controls.Contains(_content))
                this.Controls.Add(_content);
            _content.Show();                            
        }

        private void ClearContent()
        {
            foreach (Control item in this.Controls)
                item.Hide();
        }
    }
}
