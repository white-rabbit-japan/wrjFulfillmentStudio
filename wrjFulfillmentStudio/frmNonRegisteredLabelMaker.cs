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
    public partial class frmNonRegisteredLabelMaker : Form
    {
        public frmNonRegisteredLabelMaker()
        {
            InitializeComponent();
        }

        private string m_parcelId;
        
        public  string  ParcelId
            {
             get
              { 
                  return m_parcelId;
              }
            }


        private Boolean m_isValid;


        private void btnCreateLabel_Click(object sender, EventArgs e)
        {
            // assume valid
            m_isValid = true;

            // invalidate if rule fails
           if (txtParcelId.Text.Length == 0)
            {
                m_isValid = false;
                MessageBox.Show("Please enter or scan a Parcel ID");
            }

           // if valid, set parcelId and hide form 
            if (m_isValid)
            {
                m_parcelId = txtParcelId.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_parcelId = null;
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
