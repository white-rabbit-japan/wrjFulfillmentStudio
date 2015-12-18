using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace wrjFulfillmentStudio
{
	public class frmVariables : System.Windows.Forms.Form
	{
		
		#region " Windows Form Designer generated code "
		
		public frmVariables(frmMainNiceLabelDemo MainForm)
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
		public System.Windows.Forms.Button btnClose;
		public System.Windows.Forms.ListBox VariablesList;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.btnClose = new System.Windows.Forms.Button();
            this.VariablesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(270, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(97, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // VariablesList
            // 
            this.VariablesList.BackColor = System.Drawing.SystemColors.Window;
            this.VariablesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.VariablesList.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VariablesList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VariablesList.ItemHeight = 14;
            this.VariablesList.Location = new System.Drawing.Point(6, 8);
            this.VariablesList.Name = "VariablesList";
            this.VariablesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VariablesList.Size = new System.Drawing.Size(257, 326);
            this.VariablesList.TabIndex = 2;
            this.VariablesList.DoubleClick += new System.EventHandler(this.VariablesList_DoubleClick);
            // 
            // frmVariables
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(372, 343);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.VariablesList);
            this.Name = "frmVariables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variables";
            this.Load += new System.EventHandler(this.frmVariables_Load);
            this.ResumeLayout(false);

		}
		
		#endregion
		public frmMainNiceLabelDemo fMain;
		[field:System.CLSCompliant(false)]		public NiceEngine6WR.WRVar Var;
		
		const short vtPrompt = 1;
		
		public void GetVariables()
		{
			int I;
			VariablesList.Items.Clear();
			//Get variables
			for (I = 1; I <= fMain.LabelIntf.Variables.Count; I++)
			{
				// We are only interested in prompted variables
				if (fMain.LabelIntf.Variables.Item(I).VarType == vtPrompt)
				{
					VariablesList.Items.Add(fMain.LabelIntf.Variables.Item(I).Name);
				}
			}
		}
		
		private void VariablesList_DoubleClick(System.Object sender, System.EventArgs e)
		{
			frmVariable fVar;
			
			Var =  (NiceEngine6WR.WRVar) fMain.LabelIntf.Variables.FindByName(VariablesList.GetItemText(VariablesList.SelectedItem));
			if (!(Var == null))
			{
				fVar = new frmVariable(this);
				fVar.txtName.Text = Var.Name;
				fVar.txtPrompt.Text = Var.Prompt;
				fVar.txtLength.Text = Var.Length.ToString();
				fVar.txtValue.MaxLength = Var.Length;
				fVar.txtValue.Text = Var.GetValue();
				fVar.Show();
			}
		}
		
		private void btnClose_Click(System.Object sender, System.EventArgs e)
		{
			if (!(Var == null))
			{
				fMain.GetPreview();
				Var.Free();
			}
			this.Close();
		}

        private void frmVariables_Load(object sender, EventArgs e)
        {

        }
    }
	
}
