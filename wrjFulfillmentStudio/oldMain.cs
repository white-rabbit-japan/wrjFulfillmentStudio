using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;


namespace wrjFulfillmentStudio
{
	public class frmMainNiceLabelDemo : System.Windows.Forms.Form
	{
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.Run(new frmMainNiceLabelDemo());
		}
		
		#region " Windows Form Designer generated code "
		
		public frmMainNiceLabelDemo()
		{
			
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
		internal System.Windows.Forms.MainMenu mm1;
		internal System.Windows.Forms.MenuItem MenuItem6;
		internal System.Windows.Forms.MenuItem MenuItem8;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.MenuItem mmiOpen;
		internal System.Windows.Forms.MenuItem mmiClose;
		internal System.Windows.Forms.MenuItem mmiPrint;
		internal System.Windows.Forms.MenuItem mmiExit;
		internal System.Windows.Forms.MenuItem mmiVariables;
		internal System.Windows.Forms.MenuItem mmiFile;
		internal System.Windows.Forms.MenuItem mmiData;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Closing += new System.ComponentModel.CancelEventHandler(Form_Closing);
			this.mm1 = new System.Windows.Forms.MainMenu(this.components);
			this.mmiFile = new System.Windows.Forms.MenuItem();
			this.mmiOpen = new System.Windows.Forms.MenuItem();
			this.mmiOpen.Click += new System.EventHandler(mmiOpen_Click);
			this.mmiClose = new System.Windows.Forms.MenuItem();
			this.mmiClose.Click += new System.EventHandler(mmiClose_Click);
			this.MenuItem6 = new System.Windows.Forms.MenuItem();
			this.mmiPrint = new System.Windows.Forms.MenuItem();
			this.mmiPrint.Click += new System.EventHandler(mmiPrint_Click);
			this.MenuItem8 = new System.Windows.Forms.MenuItem();
			this.mmiExit = new System.Windows.Forms.MenuItem();
			this.mmiExit.Click += new System.EventHandler(mmiExit_Click);
			this.mmiData = new System.Windows.Forms.MenuItem();
			this.mmiVariables = new System.Windows.Forms.MenuItem();
			this.mmiVariables.Click += new System.EventHandler(mmiVariables_Click);
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.PictureBox1.Click += new System.EventHandler(PictureBox1_Click);
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//mm1
			//
			this.mm1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mmiFile, this.mmiData});
			//
			//mmiFile
			//
			this.mmiFile.Index = 0;
			this.mmiFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mmiOpen, this.mmiClose, this.MenuItem6, this.mmiPrint, this.MenuItem8, this.mmiExit});
			this.mmiFile.Text = "File";
			//
			//mmiOpen
			//
			this.mmiOpen.Index = 0;
			this.mmiOpen.Text = "Open";
			//
			//mmiClose
			//
			this.mmiClose.Index = 1;
			this.mmiClose.Text = "Close";
			//
			//MenuItem6
			//
			this.MenuItem6.Index = 2;
			this.MenuItem6.Text = "-";
			//
			//mmiPrint
			//
			this.mmiPrint.Enabled = false;
			this.mmiPrint.Index = 3;
			this.mmiPrint.Text = "Print";
			//
			//MenuItem8
			//
			this.MenuItem8.Index = 4;
			this.MenuItem8.Text = "-";
			//
			//mmiExit
			//
			this.mmiExit.Index = 5;
			this.mmiExit.Text = "Exit";
			//
			//mmiData
			//
			this.mmiData.Enabled = false;
			this.mmiData.Index = 1;
			this.mmiData.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mmiVariables});
			this.mmiData.Text = "Data";
			//
			//mmiVariables
			//
			this.mmiVariables.Index = 0;
			this.mmiVariables.Text = "Variables";
			//
			//PictureBox1
			//
			this.PictureBox1.Location = new System.Drawing.Point(5, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(560, 440);
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			//
			//OpenFileDialog1
			//
			this.OpenFileDialog1.DefaultExt = "lbl";
			this.OpenFileDialog1.Filter = "(*.lbl)|*.lbl";
			//
			//frmMainNiceLabelDemo
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(568, 441);
			this.Controls.Add(this.PictureBox1);
			this.Menu = this.mm1;
			this.Name = "frmMainNiceLabelDemo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LabelBrowser";
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		#endregion
		[field:System.CLSCompliant(false)]		public NiceEngine6WR.NiceApp Nice;
		[field:System.CLSCompliant(false)]		public NiceEngine6WR.NiceLabel LabelIntf;
		public string LabelFileName;
		public string PreviewFileName;
		public bool Result;
		
		const string csFormCaption = "LabelBrowser";
		const string csConnected = "Connected";
		const string csNotConnected = "Not connected";
		
		private void mmiOpen_Click(System.Object sender, System.EventArgs e)
		{
			CloseLabel();
			
			OpenFileDialog1.FileName = "";
			OpenFileDialog1.ShowDialog();
			if (OpenFileDialog1.FileName != "")
			{
				LabelFileName = OpenFileDialog1.FileName;
				
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor; //HourGlass
				
				//Connect to NiceLabel if neccessary
				Connect();
				
				//Open label
				OpenLabel(LabelFileName);
				
				this.Cursor = System.Windows.Forms.Cursors.Default; //Default
			}
		}
		
		public void GetPreview()
		{
			bool Successful;
			string ErrorM;
			
			if (PictureBox1.Image != null)
			{
				PictureBox1.Image.Dispose();
				FileSystem.Kill(PreviewFileName);
			}
			PreviewFileName =  Microsoft.VisualBasic.Strings.Left(LabelFileName, LabelFileName.Length - 4) + ".bmp";
			ErrorM = Nice.ErrorMessage;
			Successful = LabelIntf.GetLabelPreview(PreviewFileName, PictureBox1.Width, PictureBox1.Height);
			if (Successful)
			{
				PictureBox1.Image = System.Drawing.Image.FromFile(PreviewFileName);
				PictureBox1.Visible = true;
			}
			
		}
		
		public void Connect()
		{
			if (Nice == null)
			{
				// Run NiceLabel
				Nice = new NiceEngine6WR.NiceApp();
			}
		}
		
		public void Disconnect()
		{
			//Close application
			if (!(Nice == null))
			{
				Nice.Quit();
				Nice = null;
			}
		}
		
		public void OpenLabel(string FileName)
		{
            try
            {
                this.UseWaitCursor = true;

                //			bool Successful;

                // Close previously opened label
                CloseLabel();

                //Open label
                LabelIntf = Nice.LabelOpenEx(LabelFileName);
                Text = csFormCaption + " - [" + LabelFileName + "]";

                Console.WriteLine("variables {0}", LabelIntf.Variables.Count);
                Console.WriteLine("name {0}", LabelIntf.Variables.Item(0).Name);

                wreLabelDataWrangler dataWrangler = new wreLabelDataWrangler();
                NonregisteredShippingLabel labelData = dataWrangler.deserializeJSONLabel(dataWrangler.getLabelData("56740371100000f1145ff81e"));

                LabelIntf.Variables.FindByName("actualWeight").SetValue(labelData.actualWeight);

                LabelIntf.Variables.FindByName("shipToAddress").SetValue(labelData.shipToAddress);
                LabelIntf.Variables.FindByName("shippingMethod").SetValue(labelData.shippingMethod);
                LabelIntf.Variables.FindByName("shippingMethodType").SetValue(labelData.shippingType);




                // Get preview picture
                GetPreview();

                //Enable Data menu
                mmiPrint.Enabled = true;
                mmiData.Enabled = true;
            }
            finally
            {
                this.UseWaitCursor = false;
            }
		}
		
		public void CloseLabel()
		{
			if (LabelIntf != null)
			{
				LabelIntf.Free();
				LabelIntf = null;
				LabelFileName = "";
				PictureBox1.Visible = false;
				mmiData.Enabled = false;
				mmiPrint.Enabled = false;
			}
		}
		
		private void mmiClose_Click(System.Object sender, System.EventArgs e)
		{
			CloseLabel();
		}
		
		private void mmiPrint_Click(System.Object sender, System.EventArgs e)
		{
			frmPrint frmPrint1;
			
			frmPrint1 = new frmPrint(this);
			frmPrint1.tbPrinter.Text = LabelIntf.PrinterName;
			frmPrint1.Show();
		}
		
		private void mmiExit_Click(System.Object sender, System.EventArgs e)
		{
			CloseLabel();
			Disconnect();
			this.Close();
		}
		
		private void mmiVariables_Click(System.Object sender, System.EventArgs e)
		{
			frmVariables frmVars;
			
			frmVars = new frmVariables(this);
			frmVars.GetVariables();
			frmVars.Show();
		}
		
		private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			CloseLabel();
			Disconnect();
		}
		
		private void PictureBox1_Click(System.Object sender, System.EventArgs e)
		{
			
		}
	}
	
}
