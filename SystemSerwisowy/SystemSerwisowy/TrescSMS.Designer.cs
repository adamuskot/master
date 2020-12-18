namespace SystemSerwisowy
{
    partial class TrescSMS
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
            this.RTBTrescSMS = new System.Windows.Forms.RichTextBox();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWyborTresci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RTBTrescSMS
            // 
            this.RTBTrescSMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBTrescSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RTBTrescSMS.Location = new System.Drawing.Point(13, 62);
            this.RTBTrescSMS.Name = "RTBTrescSMS";
            this.RTBTrescSMS.Size = new System.Drawing.Size(348, 140);
            this.RTBTrescSMS.TabIndex = 0;
            this.RTBTrescSMS.Text = "";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAnuluj.Location = new System.Drawing.Point(114, 208);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(120, 38);
            this.btnAnuluj.TabIndex = 1;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnZapisz.Location = new System.Drawing.Point(241, 208);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(120, 38);
            this.btnZapisz.TabIndex = 2;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Treść:";
            // 
            // cbWyborTresci
            // 
            this.cbWyborTresci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWyborTresci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbWyborTresci.FormattingEnabled = true;
            this.cbWyborTresci.Items.AddRange(new object[] {
            "NAPRAWIONY",
            "NIENAPRAWIONY",
            "INNY"});
            this.cbWyborTresci.Location = new System.Drawing.Point(156, 12);
            this.cbWyborTresci.Name = "cbWyborTresci";
            this.cbWyborTresci.Size = new System.Drawing.Size(205, 28);
            this.cbWyborTresci.TabIndex = 10;
            this.cbWyborTresci.Text = "---Wybierz gotową treść---";
            this.cbWyborTresci.SelectedIndexChanged += new System.EventHandler(this.cbWyborTresci_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wybierz rodzaj:";
            // 
            // TrescSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbWyborTresci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.RTBTrescSMS);
            this.Name = "TrescSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrescSMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrescSMS_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBTrescSMS;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbWyborTresci;
        private System.Windows.Forms.Label label3;

    }
}