using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace wrjFulfillmentStudio
{
	public class frmPrint : System.Windows.Forms.Form
	{
		
		#region " Windows Form Designer generated code "
		
		public frmPrint(frmMainNiceLabelDemo MainForm)
		{
			fMain = MainForm;
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
			
		}
		
		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		public System.Windows.Forms.Button bPrint;
		public System.Windows.Forms.TextBox tbOt;
		public System.Windows.Forms.TextBox tbPrinter;
		public System.Windows.Forms.Label lbQt;
		public System.Windows.Forms.Label lbPrinter;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.bPrint = new System.Windows.Forms.Button();
            this.tbOt = new System.Windows.Forms.TextBox();
            this.tbPrinter = new System.Windows.Forms.TextBox();
            this.lbQt = new System.Windows.Forms.Label();
            this.lbPrinter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bPrint
            // 
            this.bPrint.BackColor = System.Drawing.SystemColors.Control;
            this.bPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.bPrint.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bPrint.Location = new System.Drawing.Point(140, 65);
            this.bPrint.Name = "bPrint";
            this.bPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bPrint.Size = new System.Drawing.Size(129, 25);
            this.bPrint.TabIndex = 9;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = false;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // tbOt
            // 
            this.tbOt.AcceptsReturn = true;
            this.tbOt.BackColor = System.Drawing.SystemColors.Window;
            this.tbOt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOt.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbOt.Location = new System.Drawing.Point(84, 65);
            this.tbOt.MaxLength = 0;
            this.tbOt.Name = "tbOt";
            this.tbOt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOt.Size = new System.Drawing.Size(41, 25);
            this.tbOt.TabIndex = 8;
            this.tbOt.Text = "1";
            // 
            // tbPrinter
            // 
            this.tbPrinter.AcceptsReturn = true;
            this.tbPrinter.BackColor = System.Drawing.SystemColors.Window;
            this.tbPrinter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrinter.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrinter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPrinter.Location = new System.Drawing.Point(84, 29);
            this.tbPrinter.MaxLength = 0;
            this.tbPrinter.Name = "tbPrinter";
            this.tbPrinter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPrinter.Size = new System.Drawing.Size(185, 25);
            this.tbPrinter.TabIndex = 5;
            // 
            // lbQt
            // 
            this.lbQt.BackColor = System.Drawing.SystemColors.Control;
            this.lbQt.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbQt.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbQt.Location = new System.Drawing.Point(20, 69);
            this.lbQt.Name = "lbQt";
            this.lbQt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbQt.Size = new System.Drawing.Size(52, 17);
            this.lbQt.TabIndex = 7;
            this.lbQt.Text = "Quantity:";
            // 
            // lbPrinter
            // 
            this.lbPrinter.BackColor = System.Drawing.SystemColors.Control;
            this.lbPrinter.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPrinter.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrinter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPrinter.Location = new System.Drawing.Point(20, 33);
            this.lbPrinter.Name = "lbPrinter";
            this.lbPrinter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPrinter.Size = new System.Drawing.Size(41, 17);
            this.lbPrinter.TabIndex = 6;
            this.lbPrinter.Text = "Printer:";
            // 
            // frmPrint
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(288, 118);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.tbOt);
            this.Controls.Add(this.tbPrinter);
            this.Controls.Add(this.lbQt);
            this.Controls.Add(this.lbPrinter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.ResumeLayout(false);

		}
		
		#endregion
		frmMainNiceLabelDemo fMain;
		
		private void bPrint_Click(System.Object sender, System.EventArgs e)
		{
			fMain.LabelIntf.PrinterName = tbPrinter.Text;
			fMain.Result = fMain.LabelIntf.Print(tbOt.Text);
			this.Close();
		}

        private void frmPrint_Load(object sender, EventArgs e)
        {

        }
    }
	
}
