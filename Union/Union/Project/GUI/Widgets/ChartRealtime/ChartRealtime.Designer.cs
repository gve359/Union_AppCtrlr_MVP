namespace Project.GUI.Widgets.ChartRealtime
{
    partial class ChartRealtime
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChartHideable1 = new Project.GUI.Widgets.ChartHeideable.ChartHideable();
            this.SuspendLayout();
            // 
            // ChartHideable1
            // 
            this.ChartHideable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartHideable1.Location = new System.Drawing.Point(0, 0);
            this.ChartHideable1.Name = "ChartHideable1";
            this.ChartHideable1.Size = new System.Drawing.Size(501, 279);
            this.ChartHideable1.TabIndex = 0;
            this.ChartHideable1.TableSource = null;
            // 
            // ChartRealtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChartHideable1);
            this.Name = "ChartRealtime";
            this.Size = new System.Drawing.Size(501, 279);
            this.ResumeLayout(false);

        }

        #endregion

        private global::Project.GUI.Widgets.ChartHeideable.ChartHideable ChartHideable1;
    }
}
