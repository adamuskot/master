namespace SystemSerwisowy
{
    partial class WyslijSMS
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
            this.rtbTrescSMS = new System.Windows.Forms.RichTextBox();
            this.lblAdresat = new System.Windows.Forms.Label();
            this.lblTresc = new System.Windows.Forms.Label();
            this.tbNumerOdbiorcy = new System.Windows.Forms.TextBox();
            this.btAnuluj = new System.Windows.Forms.Button();
            this.btWyslij = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbWyborTresci = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtbTrescSMS
            // 
            this.rtbTrescSMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTrescSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbTrescSMS.Location = new System.Drawing.Point(18, 80);
            this.rtbTrescSMS.Name = "rtbTrescSMS";
            this.rtbTrescSMS.Size = new System.Drawing.Size(399, 137);
            this.rtbTrescSMS.TabIndex = 0;
            this.rtbTrescSMS.Text = "";
            // 
            // lblAdresat
            // 
            this.lblAdresat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdresat.AutoSize = true;
            this.lblAdresat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdresat.Location = new System.Drawing.Point(14, 13);
            this.lblAdresat.Name = "lblAdresat";
            this.lblAdresat.Size = new System.Drawing.Size(123, 20);
            this.lblAdresat.TabIndex = 2;
            this.lblAdresat.Text = "Numer odbiorcy:";
            // 
            // lblTresc
            // 
            this.lblTresc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTresc.AutoSize = true;
            this.lblTresc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTresc.Location = new System.Drawing.Point(14, 54);
            this.lblTresc.Name = "lblTresc";
            this.lblTresc.Size = new System.Drawing.Size(105, 20);
            this.lblTresc.TabIndex = 3;
            this.lblTresc.Text = "Rodzaj treści:";
            // 
            // tbNumerOdbiorcy
            // 
            this.tbNumerOdbiorcy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumerOdbiorcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNumerOdbiorcy.Location = new System.Drawing.Point(143, 14);
            this.tbNumerOdbiorcy.Name = "tbNumerOdbiorcy";
            this.tbNumerOdbiorcy.Size = new System.Drawing.Size(274, 26);
            this.tbNumerOdbiorcy.TabIndex = 5;
            // 
            // btAnuluj
            // 
            this.btAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAnuluj.Location = new System.Drawing.Point(195, 229);
            this.btAnuluj.Name = "btAnuluj";
            this.btAnuluj.Size = new System.Drawing.Size(102, 52);
            this.btAnuluj.TabIndex = 7;
            this.btAnuluj.Text = "Anuluj";
            this.btAnuluj.UseVisualStyleBackColor = true;
            this.btAnuluj.Click += new System.EventHandler(this.btAnuluj_Click);
            // 
            // btWyslij
            // 
            this.btWyslij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btWyslij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btWyslij.Location = new System.Drawing.Point(314, 229);
            this.btWyslij.Name = "btWyslij";
            this.btWyslij.Size = new System.Drawing.Size(102, 52);
            this.btWyslij.TabIndex = 6;
            this.btWyslij.Text = "Wyślij";
            this.btWyslij.UseVisualStyleBackColor = true;
            this.btWyslij.Click += new System.EventHandler(this.btWyslij_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(17, 220);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(172, 61);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Jeśli chcesz definitywnie zmienić treść domyślną wiadomości, mozesz to zrobić w m" +
    "enu głównym w zakładce Pomoc -> Treść SMS ";
            // 
            // cbWyborTresci
            // 
            this.cbWyborTresci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbWyborTresci.FormattingEnabled = true;
            this.cbWyborTresci.Items.AddRange(new object[] {
            "NAPRAWIONY",
            "NIENAPRAWIONY",
            "INNY"});
            this.cbWyborTresci.Location = new System.Drawing.Point(143, 46);
            this.cbWyborTresci.Name = "cbWyborTresci";
            this.cbWyborTresci.Size = new System.Drawing.Size(273, 28);
            this.cbWyborTresci.TabIndex = 9;
            this.cbWyborTresci.Text = "---Wybierz gotową treść---";
            this.cbWyborTresci.SelectedIndexChanged += new System.EventHandler(this.cbWyborTresci_SelectedIndexChanged);
            // 
            // WyslijSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 292);
            this.Controls.Add(this.cbWyborTresci);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btAnuluj);
            this.Controls.Add(this.btWyslij);
            this.Controls.Add(this.tbNumerOdbiorcy);
            this.Controls.Add(this.lblTresc);
            this.Controls.Add(this.lblAdresat);
            this.Controls.Add(this.rtbTrescSMS);
            this.Name = "WyslijSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WyslijSMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WyslijSMS_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTrescSMS;
        private System.Windows.Forms.Label lblAdresat;
        private System.Windows.Forms.Label lblTresc;
        private System.Windows.Forms.TextBox tbNumerOdbiorcy;
        private System.Windows.Forms.Button btAnuluj;
        private System.Windows.Forms.Button btWyslij;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cbWyborTresci;
    }
}