using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wrjFulfillmentStudio
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }


        private void SetPrinter(ref TextBox defaultPrinter)
        {
            PrintDialog printDialog1 = new PrintDialog();
            // printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string printerName = printDialog1.PrinterSettings.PrinterName;
                if (!(string.IsNullOrWhiteSpace(printerName)))
                {
                    defaultPrinter.Text = printerName;
                }

            }


        }

        private void btnSelectParcelBarcodePrinter_Click(object sender, EventArgs e)
        {
            SetPrinter(ref txtParcelBarcodePrinter);

        }

        private void btnSetShippingLabelPrinter_Click(object sender, EventArgs e)
        {
            SetPrinter(ref txtShippingLabelPrinter);
        }

        private void btnSetCustomsPrinter_Click(object sender, EventArgs e)
        {
            SetPrinter(ref txtCustomsPrinter);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ParcelBarcodePrinter = txtParcelBarcodePrinter.Text;
            Properties.Settings.Default.CustomsPrinter = txtCustomsPrinter.Text;
            Properties.Settings.Default.ShippingLabelPrinter = txtShippingLabelPrinter.Text;
            Properties.Settings.Default.Save();
            this.Hide();



        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtParcelBarcodePrinter.Text = Properties.Settings.Default.ParcelBarcodePrinter;
            txtCustomsPrinter.Text = Properties.Settings.Default.CustomsPrinter;
            txtShippingLabelPrinter.Text = Properties.Settings.Default.ShippingLabelPrinter;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
