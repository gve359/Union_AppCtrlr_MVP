
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project.Infrastructure
{	
	public class TabControlX : TabControl
	{
		public bool ToAskWhenTabClosing { get; set; }
		
		public TabControlX()
		{
			ToAskWhenTabClosing = false;

            this.SizeMode = TabSizeMode.FillToRight;
            this.DrawMode = TabDrawMode.OwnerDrawFixed;

			this.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnTabControlDrawItem);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnTabControlMouseDown);
			this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.OnTabControlControlAdded);            
		}
		
		void OnTabControlDrawItem(object sender, DrawItemEventArgs e)
		{			
			//This code will render a "x" mark at the end of the Tab caption. 
			e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
			e.Graphics.DrawString(this.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
			e.DrawFocusRectangle();
		}
		
		void OnTabControlMouseDown(object sender, MouseEventArgs e)
		{
			//Looping through the controls.
			for (int i = 0; i < this.TabPages.Count; i++)
			{
			    Rectangle r = this.GetTabRect(i);
			   //Getting the position of the "x" mark.
			    Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
			    if (closeButton.Contains(e.Location))
			    {
			        if (ToAskWhenTabClosing && MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			        {}
			        else
			        {
                        foreach (Control item in this.TabPages[i].Controls) 
                            item.Dispose();
                        this.TabPages[i].Controls.Clear();
			        	this.TabPages.RemoveAt(i);
			        }
			        break;
			    }			    
			}
		}

		void OnTabControlControlAdded(object sender, ControlEventArgs e)
		{			
			// без этого, крестик заползёт на название вкладки			
			this.TabPages[this.TabPages.Count - 1].Text += "         ";			
		}			
	}
	
	
}
