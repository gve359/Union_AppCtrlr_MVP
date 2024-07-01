namespace Project.GUI.Pages.PageMain
{
    partial class PageMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.серверToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приостановитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счётчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДиаграммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlX1 = new Project.Infrastructure.TabControlX();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControlX1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.серверToolStripMenuItem,
            this.счётчикиToolStripMenuItem,
            this.диаграммыToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // серверToolStripMenuItem
            // 
            this.серверToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приостановитьToolStripMenuItem,
            this.включитьToolStripMenuItem});
            this.серверToolStripMenuItem.Name = "серверToolStripMenuItem";
            this.серверToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.серверToolStripMenuItem.Text = "Сервер";            
            // 
            // приостановитьToolStripMenuItem
            // 
            this.приостановитьToolStripMenuItem.Name = "приостановитьToolStripMenuItem";
            this.приостановитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.приостановитьToolStripMenuItem.Text = "Остановить";
            this.приостановитьToolStripMenuItem.Click += new System.EventHandler(this.приостановитьToolStripMenuItem_Click);
            // 
            // включитьToolStripMenuItem
            // 
            this.включитьToolStripMenuItem.Name = "включитьToolStripMenuItem";
            this.включитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.включитьToolStripMenuItem.Text = "Включить";
            this.включитьToolStripMenuItem.Click += new System.EventHandler(this.включитьToolStripMenuItem_Click);
            // 
            // счётчикиToolStripMenuItem
            // 
            this.счётчикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.счётчикиToolStripMenuItem.Name = "счётчикиToolStripMenuItem";
            this.счётчикиToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.счётчикиToolStripMenuItem.Text = "Счётчики";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // диаграммыToolStripMenuItem
            // 
            this.диаграммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьДиаграммуToolStripMenuItem});
            this.диаграммыToolStripMenuItem.Name = "диаграммыToolStripMenuItem";
            this.диаграммыToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.диаграммыToolStripMenuItem.Text = "Диаграммы";
            // 
            // добавитьДиаграммуToolStripMenuItem
            // 
            this.добавитьДиаграммуToolStripMenuItem.Name = "добавитьДиаграммуToolStripMenuItem";
            this.добавитьДиаграммуToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.добавитьДиаграммуToolStripMenuItem.Text = "Добавить диаграмму";
            this.добавитьДиаграммуToolStripMenuItem.Click += new System.EventHandler(this.добавитьДиаграммуToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // tabControlX1
            // 
            this.tabControlX1.Controls.Add(this.tabPage1);
            this.tabControlX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlX1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlX1.Location = new System.Drawing.Point(0, 24);
            this.tabControlX1.Name = "tabControlX1";
            this.tabControlX1.SelectedIndex = 0;
            this.tabControlX1.Size = new System.Drawing.Size(538, 298);
            this.tabControlX1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlX1.TabIndex = 4;
            this.tabControlX1.ToAskWhenTabClosing = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(530, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1                                                               ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 322);
            this.Controls.Add(this.tabControlX1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PageMain";
            this.Text = "PageMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlX1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem серверToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приостановитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счётчикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диаграммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьДиаграммуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private global::Project.Infrastructure.TabControlX tabControlX1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}