namespace wrjFulfillmentStudio
{
    partial class frmSettings
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
            this.grpDefaultPrinters = new System.Windows.Forms.GroupBox();
            this.btnSelectParcelBarcodePrinter = new System.Windows.Forms.Button();
            this.txtParcelBarcodePrinter = new System.Windows.Forms.TextBox();
            this.lblParcelBarcodePrinter = new System.Windows.Forms.Label();
            this.btnSetShippingLabelPrinter = new System.Windows.Forms.Button();
            this.txtShippingLabelPrinter = new System.Windows.Forms.TextBox();
            this.lblShippingLabel = new System.Windows.Forms.Label();
            this.btnSetCustomsPrinter = new System.Windows.Forms.Button();
            this.txtCustomsPrinter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpDefaultPrinters.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDefaultPrinters
            // 
            this.grpDefaultPrinters.Controls.Add(this.btnSetCustomsPrinter);
            this.grpDefaultPrinters.Controls.Add(this.txtCustomsPrinter);
            this.grpDefaultPrinters.Controls.Add(this.label2);
            this.grpDefaultPrinters.Controls.Add(this.btnSetShippingLabelPrinter);
            this.grpDefaultPrinters.Controls.Add(this.txtShippingLabelPrinter);
            this.grpDefaultPrinters.Controls.Add(this.lblShippingLabel);
            this.grpDefaultPrinters.Controls.Add(this.btnSelectParcelBarcodePrinter);
            this.grpDefaultPrinters.Controls.Add(this.txtParcelBarcodePrinter);
            this.grpDefaultPrinters.Controls.Add(this.lblParcelBarcodePrinter);
            this.grpDefaultPrinters.Location = new System.Drawing.Point(30, 39);
            this.grpDefaultPrinters.Name = "grpDefaultPrinters";
            this.grpDefaultPrinters.Size = new System.Drawing.Size(493, 160);
            this.grpDefaultPrinters.TabIndex = 3;
            this.grpDefaultPrinters.TabStop = false;
            this.grpDefaultPrinters.Text = "Default Printer";
            // 
            // btnSelectParcelBarcodePrinter
            // 
            this.btnSelectParcelBarcodePrinter.Location = new System.Drawing.Point(385, 37);
            this.btnSelectParcelBarcodePrinter.Name = "btnSelectParcelBarcodePrinter";
            this.btnSelectParcelBarcodePrinter.Size = new System.Drawing.Size(75, 23);
            this.btnSelectParcelBarcodePrinter.TabIndex = 5;
            this.btnSelectParcelBarcodePrinter.Text = "Select...";
            this.btnSelectParcelBarcodePrinter.UseVisualStyleBackColor = true;
            this.btnSelectParcelBarcodePrinter.Click += new System.EventHandler(this.btnSelectParcelBarcodePrinter_Click);
            // 
            // txtParcelBarcodePrinter
            // 
            this.txtParcelBarcodePrinter.Location = new System.Drawing.Point(119, 39);
            this.txtParcelBarcodePrinter.Name = "txtParcelBarcodePrinter";
            this.txtParcelBarcodePrinter.Size = new System.Drawing.Size(260, 20);
            this.txtParcelBarcodePrinter.TabIndex = 4;
            // 
            // lblParcelBarcodePrinter
            // 
            this.lblParcelBarcodePrinter.AutoSize = true;
            this.lblParcelBarcodePrinter.Location = new System.Drawing.Point(6, 42);
            this.lblParcelBarcodePrinter.Name = "lblParcelBarcodePrinter";
            this.lblParcelBarcodePrinter.Size = new System.Drawing.Size(88, 13);
            this.lblParcelBarcodePrinter.TabIndex = 3;
            this.lblParcelBarcodePrinter.Text = "Parcel Barcodes:";
            // 
            // btnSetShippingLabelPrinter
            // 
            this.btnSetShippingLabelPrinter.Location = new System.Drawing.Point(385, 72);
            this.btnSetShippingLabelPrinter.Name = "btnSetShippingLabelPrinter";
            this.btnSetShippingLabelPrinter.Size = new System.Drawing.Size(75, 23);
            this.btnSetShippingLabelPrinter.TabIndex = 8;
            this.btnSetShippingLabelPrinter.Text = "Select...";
            this.btnSetShippingLabelPrinter.UseVisualStyleBackColor = true;
            this.btnSetShippingLabelPrinter.Click += new System.EventHandler(this.btnSetShippingLabelPrinter_Click);
            // 
            // txtShippingLabelPrinter
            // 
            this.txtShippingLabelPrinter.Location = new System.Drawing.Point(119, 74);
            this.txtShippingLabelPrinter.Name = "txtShippingLabelPrinter";
            this.txtShippingLabelPrinter.Size = new System.Drawing.Size(260, 20);
            this.txtShippingLabelPrinter.TabIndex = 7;
            // 
            // lblShippingLabel
            // 
            this.lblShippingLabel.AutoSize = true;
            this.lblShippingLabel.Location = new System.Drawing.Point(6, 77);
            this.lblShippingLabel.Name = "lblShippingLabel";
            this.lblShippingLabel.Size = new System.Drawing.Size(80, 13);
            this.lblShippingLabel.TabIndex = 6;
            this.lblShippingLabel.Text = "Shipping Label:";
            // 
            // btnSetCustomsPrinter
            // 
            this.btnSetCustomsPrinter.Location = new System.Drawing.Point(385, 107);
            this.btnSetCustomsPrinter.Name = "btnSetCustomsPrinter";
            this.btnSetCustomsPrinter.Size = new System.Drawing.Size(75, 23);
            this.btnSetCustomsPrinter.TabIndex = 11;
            this.btnSetCustomsPrinter.Text = "Select...";
            this.btnSetCustomsPrinter.UseVisualStyleBackColor = true;
            this.btnSetCustomsPrinter.Click += new System.EventHandler(this.btnSetCustomsPrinter_Click);
            // 
            // txtCustomsPrinter
            // 
            this.txtCustomsPrinter.Location = new System.Drawing.Point(119, 109);
            this.txtCustomsPrinter.Name = "txtCustomsPrinter";
            this.txtCustomsPrinter.Size = new System.Drawing.Size(260, 20);
            this.txtCustomsPrinter.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customs Declaration:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(415, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(334, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(574, 320);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpDefaultPrinters);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpDefaultPrinters.ResumeLayout(false);
            this.grpDefaultPrinters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDefaultPrinters;
        private System.Windows.Forms.Button btnSelectParcelBarcodePrinter;
        private System.Windows.Forms.TextBox txtParcelBarcodePrinter;
        private System.Windows.Forms.Label lblParcelBarcodePrinter;
        private System.Windows.Forms.Button btnSetCustomsPrinter;
        private System.Windows.Forms.TextBox txtCustomsPrinter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetShippingLabelPrinter;
        private System.Windows.Forms.TextBox txtShippingLabelPrinter;
        private System.Windows.Forms.Label lblShippingLabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}