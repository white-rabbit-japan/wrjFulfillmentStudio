using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.IO;
using System.Reflection;




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

        private System.ComponentModel.IContainer components;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        internal System.Windows.Forms.MainMenu mm1;
        internal System.Windows.Forms.MenuItem MenuItem6;
        internal System.Windows.Forms.MenuItem MenuItem8;
        internal System.Windows.Forms.MenuItem mmiOpen;
        internal System.Windows.Forms.MenuItem mmiClose;
        internal System.Windows.Forms.MenuItem mmiPrint;
        internal System.Windows.Forms.MenuItem mmiExit;
        internal System.Windows.Forms.MenuItem mmiVariables;
        internal System.Windows.Forms.MenuItem mmiFile;
        internal System.Windows.Forms.MenuItem mmiData;
        internal PictureBox PictureBox1;
        private MenuItem mmiTools;
        private MenuItem miCreateNonregisteredLabel;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mm1 = new System.Windows.Forms.MainMenu(this.components);
            this.mmiFile = new System.Windows.Forms.MenuItem();
            this.mmiOpen = new System.Windows.Forms.MenuItem();
            this.mmiClose = new System.Windows.Forms.MenuItem();
            this.MenuItem6 = new System.Windows.Forms.MenuItem();
            this.mmiPrint = new System.Windows.Forms.MenuItem();
            this.MenuItem8 = new System.Windows.Forms.MenuItem();
            this.mmiExit = new System.Windows.Forms.MenuItem();
            this.mmiData = new System.Windows.Forms.MenuItem();
            this.mmiVariables = new System.Windows.Forms.MenuItem();
            this.mmiTools = new System.Windows.Forms.MenuItem();
            this.miCreateNonregisteredLabel = new System.Windows.Forms.MenuItem();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mm1
            // 
            this.mm1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mmiFile,
            this.mmiData,
            this.mmiTools});
            // 
            // mmiFile
            // 
            this.mmiFile.Index = 0;
            this.mmiFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mmiOpen,
            this.mmiClose,
            this.MenuItem6,
            this.mmiPrint,
            this.MenuItem8,
            this.mmiExit});
            this.mmiFile.Text = "File";
            this.mmiFile.Click += new System.EventHandler(this.mmiFile_Click);
            // 
            // mmiOpen
            // 
            this.mmiOpen.Index = 0;
            this.mmiOpen.Text = "Open";
            this.mmiOpen.Click += new System.EventHandler(this.mmiOpen_Click);
            // 
            // mmiClose
            // 
            this.mmiClose.Index = 1;
            this.mmiClose.Text = "Close";
            this.mmiClose.Click += new System.EventHandler(this.mmiClose_Click);
            // 
            // MenuItem6
            // 
            this.MenuItem6.Index = 2;
            this.MenuItem6.Text = "-";
            // 
            // mmiPrint
            // 
            this.mmiPrint.Enabled = false;
            this.mmiPrint.Index = 3;
            this.mmiPrint.Text = "Print";
            this.mmiPrint.Click += new System.EventHandler(this.mmiPrint_Click);
            // 
            // MenuItem8
            // 
            this.MenuItem8.Index = 4;
            this.MenuItem8.Text = "-";
            // 
            // mmiExit
            // 
            this.mmiExit.Index = 5;
            this.mmiExit.Text = "Exit";
            this.mmiExit.Click += new System.EventHandler(this.mmiExit_Click);
            // 
            // mmiData
            // 
            this.mmiData.Enabled = false;
            this.mmiData.Index = 1;
            this.mmiData.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mmiVariables});
            this.mmiData.Text = "Data";
            // 
            // mmiVariables
            // 
            this.mmiVariables.Index = 0;
            this.mmiVariables.Text = "Variables";
            this.mmiVariables.Click += new System.EventHandler(this.mmiVariables_Click);
            // 
            // mmiTools
            // 
            this.mmiTools.Index = 2;
            this.mmiTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miCreateNonregisteredLabel});
            this.mmiTools.Text = "Tools";
            this.mmiTools.Click += new System.EventHandler(this.mmiCreateLabel_Click_1);
            // 
            // miCreateNonregisteredLabel
            // 
            this.miCreateNonregisteredLabel.Index = 0;
            this.miCreateNonregisteredLabel.Text = "Create Non-registered Shipping Label";
            this.miCreateNonregisteredLabel.Click += new System.EventHandler(this.miCreateNonregisteredLabel_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.DefaultExt = "lbl";
            this.OpenFileDialog1.Filter = "(*.lbl)|*.lbl";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(996, 723);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // frmMainNiceLabelDemo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(996, 723);
            this.Controls.Add(this.PictureBox1);
            this.IsMdiContainer = true;
            this.Menu = this.mm1;
            this.Name = "frmMainNiceLabelDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabelBrowser";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.frmMainNiceLabelDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        [field: System.CLSCompliant(false)]
        public NiceEngine6WR.NiceApp Nice;
        [field: System.CLSCompliant(false)]
        public NiceEngine6WR.NiceLabel LabelIntf;
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
                MessageBox.Show(LabelFileName);
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor; //HourGlass

                //Connect to NiceLabel if neccessary
                Connect();

                //Open label
                //OpenLabel("");

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
            PreviewFileName = Microsoft.VisualBasic.Strings.Left(LabelFileName, LabelFileName.Length - 4) + ".bmp";
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


        public void CreateNonRegisteredLabel(string parcelId)
        {
            // open label

            // get and set variable data

            // render preview

        }

        enum LabelTypes
        {
            NonRegisteredShipping,
            CNN22
        }

        private string GetLabelFullFilePath(LabelTypes labelType)
        {
            string labelTemplateFileName = "";

            switch (labelType)
            {
                case LabelTypes.NonRegisteredShipping:
                    labelTemplateFileName = Properties.Settings.Default.nonregisteredLabelTemplate;
                    break;

                case LabelTypes.CNN22:
                    labelTemplateFileName = Properties.Settings.Default.CN22LabelTemplate;
                    break;
            }

            string appDir = AppDomain.CurrentDomain.BaseDirectory;


            return Path.Combine(appDir, labelTemplateFileName);

        }

        public void OpenCustomsDeclaration(NonRegisteredShippingLabel labelData)
        {
            // CN22Template

            try
            {
                this.UseWaitCursor = true;

                //			bool Successful;

                // Close previously opened label
                CloseLabel();

                //Open label


                LabelFileName = GetLabelFullFilePath(LabelTypes.CNN22);


                LabelIntf = Nice.LabelOpenEx(LabelFileName);
                Text = csFormCaption + " - [" + labelData.shippingInfo.packageId + "]";

                Console.WriteLine("variables {0}", LabelIntf.Variables.Count);
                Console.WriteLine("name {0}", LabelIntf.Variables.Item(0).Name);


                LabelIntf.Variables.FindByName("totalValue").SetValue(labelData.customsInfo.customsTotalValue);


                //LabelIntf.Variables.FindByName("customers").SetValue(labelData.customsItems)

                int i = 0;

                foreach (CustomsItem ci in labelData.customsInfo.customsItems)
                {
                    Console.WriteLine("description {0}, quantity {1}, value {2}", ci.description, ci.quantity, ci.value);
                    LabelIntf.Variables.FindByName("ciDescription" + (i+1)).SetValue(labelData.customsInfo.customsItems[i].description);
                    LabelIntf.Variables.FindByName("ciValue" + (i+1)).SetValue(labelData.customsInfo.customsItems[i].value);
                    LabelIntf.Variables.FindByName("ciQuantity" + (i+1)).SetValue(labelData.customsInfo.customsItems[i].quantity.ToString());


                    i++;
                }

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

        public void OpenNonRegisteredShippingLabel(NonRegisteredShippingLabel labelData)
        {
            try
            {
                this.UseWaitCursor = true;

                //			bool Successful;

                // Close previously opened label
                CloseLabel();

                //Open label

               
                LabelFileName = GetLabelFullFilePath(LabelTypes.NonRegisteredShipping);

                LabelIntf = Nice.LabelOpenEx(LabelFileName);
                Text = csFormCaption + " - [" + labelData.shippingInfo.packageId + "]";

                Console.WriteLine("variables {0}", LabelIntf.Variables.Count);
                Console.WriteLine("name {0}", LabelIntf.Variables.Item(0).Name);


                LabelIntf.Variables.FindByName("actualWeight").SetValue(labelData.shippingInfo.actualWeight);

                LabelIntf.Variables.FindByName("shipToAddress").SetValue(labelData.shippingInfo.shipToAddress);
                LabelIntf.Variables.FindByName("shippingMethod").SetValue(labelData.shippingInfo.shippingMethod);
                LabelIntf.Variables.FindByName("shippingMethodType").SetValue(labelData.shippingInfo.shippingType);

                //LabelIntf.Variables.FindByName("customers").SetValue(labelData.customsItems)

                foreach (CustomsItem ci in labelData.customsInfo.customsItems)
                {
                    Console.WriteLine("description {0}, quantity {1}, value {2}", ci.description, ci.quantity, ci.value);
                }

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
            Console.WriteLine("Printer name={0}");

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

        private void frmMainNiceLabelDemo_Load(object sender, EventArgs e)
        {

        }

        private void mmiFile_Click(object sender, EventArgs e)
        {

        }

        private void mmiCreateLabel_Click(object sender, EventArgs e)
        {

        }


        private void mmiCreateLabel_Click_1(object sender, EventArgs e)
        {


        }

        private void miCreateNonregisteredLabel_Click(object sender, EventArgs e)
        {
            CloseLabel();

            frmNonRegisteredLabelMaker instance = new frmNonRegisteredLabelMaker();
            instance.StartPosition = FormStartPosition.CenterParent;

            if (instance.ShowDialog(this) == DialogResult.OK)
            {
                //MessageBox.Show(instance.ParcelId);
                string parcelId = instance.ParcelId;



                Disconnect();
                //Connect to NiceLabel if neccessary
                Connect();

                wreLabelDataWrangler dataWrangler = new wreLabelDataWrangler();
                NonRegisteredShippingLabel labelData = dataWrangler.deserializeJSONLabel(dataWrangler.getLabelData(parcelId));


                OpenCustomsDeclaration(labelData);
               // OpenNonRegisteredShippingLabel(labelData);


            }
            else
            {
                MessageBox.Show("cancelled");
            }

            instance.Dispose();
        }
    }

}
