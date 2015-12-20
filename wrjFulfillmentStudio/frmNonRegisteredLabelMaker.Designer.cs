namespace wrjFulfillmentStudio
{
    partial class frmNonRegisteredLabelMaker
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
            this.lblParcelId = new System.Windows.Forms.Label();
            this.txtParcelId = new System.Windows.Forms.TextBox();
            this.btnCreateLabel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblParcelId
            // 
            this.lblParcelId.AutoSize = true;
            this.lblParcelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelId.Location = new System.Drawing.Point(23, 75);
            this.lblParcelId.Name = "lblParcelId";
            this.lblParcelId.Size = new System.Drawing.Size(105, 25);
            this.lblParcelId.TabIndex = 0;
            this.lblParcelId.Text = "Parcel ID:";
            // 
            // txtParcelId
            // 
            this.txtParcelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcelId.Location = new System.Drawing.Point(128, 69);
            this.txtParcelId.Name = "txtParcelId";
            this.txtParcelId.Size = new System.Drawing.Size(205, 35);
            this.txtParcelId.TabIndex = 1;
            // 
            // btnCreateLabel
            // 
            this.btnCreateLabel.Location = new System.Drawing.Point(179, 154);
            this.btnCreateLabel.Name = "btnCreateLabel";
            this.btnCreateLabel.Size = new System.Drawing.Size(154, 42);
            this.btnCreateLabel.TabIndex = 2;
            this.btnCreateLabel.Text = "Create Label";
            this.btnCreateLabel.UseVisualStyleBackColor = true;
            this.btnCreateLabel.Click += new System.EventHandler(this.btnCreateLabel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(68, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNonRegisteredLabelMaker
            // 
            this.AcceptButton = this.btnCreateLabel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(393, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateLabel);
            this.Controls.Add(this.txtParcelId);
            this.Controls.Add(this.lblParcelId);
            this.Name = "frmNonRegisteredLabelMaker";
            this.Text = "frmNonRegisteredLabelMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParcelId;
        private System.Windows.Forms.TextBox txtParcelId;
        private System.Windows.Forms.Button btnCreateLabel;
        private System.Windows.Forms.Button btnCancel;
    }
}