namespace SystemSerwisowy
{
    partial class SekcjaRaportow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekcjaRaportow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRaportSerwisu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chBLStatusy = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btRaportSprzedazy = new System.Windows.Forms.Button();
            this.dtpDataRaportuSprzedazy = new System.Windows.Forms.DateTimePicker();
            this.btZamknij = new System.Windows.Forms.Button();
            this.printDialogSerwis = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialogSerwis = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentSerwis = new System.Drawing.Printing.PrintDocument();
            this.printDocumentSprzedaz = new System.Drawing.Printing.PrintDocument();
            this.printDialogSprzedaz = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialogSprzedaz = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btRaportSerwisu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chBLStatusy);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raport Serwisu";
            // 
            // btRaportSerwisu
            // 
            this.btRaportSerwisu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRaportSerwisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRaportSerwisu.Location = new System.Drawing.Point(114, 202);
            this.btRaportSerwisu.Name = "btRaportSerwisu";
            this.btRaportSerwisu.Size = new System.Drawing.Size(110, 57);
            this.btRaportSerwisu.TabIndex = 3;
            this.btRaportSerwisu.Text = "Generuj Raport";
            this.btRaportSerwisu.UseVisualStyleBackColor = true;
            this.btRaportSerwisu.Click += new System.EventHandler(this.btRaportSerwisu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz statusy do raportu:";
            // 
            // chBLStatusy
            // 
            this.chBLStatusy.CheckOnClick = true;
            this.chBLStatusy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBLStatusy.FormattingEnabled = true;
            this.chBLStatusy.Items.AddRange(new object[] {
            "Przyjęty do naprawy",
            "Wysłane na gwarancję",
            "Czeka na części",
            "Czeka na decyzję klienta"});
            this.chBLStatusy.Location = new System.Drawing.Point(7, 76);
            this.chBLStatusy.Name = "chBLStatusy";
            this.chBLStatusy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBLStatusy.Size = new System.Drawing.Size(331, 88);
            this.chBLStatusy.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btRaportSprzedazy);
            this.groupBox2.Controls.Add(this.dtpDataRaportuSprzedazy);
            this.groupBox2.Location = new System.Drawing.Point(371, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raport Sprzedaży";
            // 
            // btRaportSprzedazy
            // 
            this.btRaportSprzedazy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRaportSprzedazy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRaportSprzedazy.Location = new System.Drawing.Point(111, 202);
            this.btRaportSprzedazy.Name = "btRaportSprzedazy";
            this.btRaportSprzedazy.Size = new System.Drawing.Size(110, 57);
            this.btRaportSprzedazy.TabIndex = 4;
            this.btRaportSprzedazy.Text = "Generuj Raport";
            this.btRaportSprzedazy.UseVisualStyleBackColor = true;
            this.btRaportSprzedazy.Click += new System.EventHandler(this.btRaportSprzedazy_Click);
            // 
            // dtpDataRaportuSprzedazy
            // 
            this.dtpDataRaportuSprzedazy.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataRaportuSprzedazy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRaportuSprzedazy.Location = new System.Drawing.Point(21, 58);
            this.dtpDataRaportuSprzedazy.Name = "dtpDataRaportuSprzedazy";
            this.dtpDataRaportuSprzedazy.Size = new System.Drawing.Size(300, 20);
            this.dtpDataRaportuSprzedazy.TabIndex = 0;
            // 
            // btZamknij
            // 
            this.btZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btZamknij.Location = new System.Drawing.Point(621, 307);
            this.btZamknij.Name = "btZamknij";
            this.btZamknij.Size = new System.Drawing.Size(94, 49);
            this.btZamknij.TabIndex = 5;
            this.btZamknij.Text = "Zamknij";
            this.btZamknij.UseVisualStyleBackColor = true;
            this.btZamknij.Click += new System.EventHandler(this.btZamknij_Click);
            // 
            // printDialogSerwis
            // 
            this.printDialogSerwis.UseEXDialog = true;
            // 
            // printPreviewDialogSerwis
            // 
            this.printPreviewDialogSerwis.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSerwis.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSerwis.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogSerwis.Enabled = true;
            this.printPreviewDialogSerwis.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogSerwis.Icon")));
            this.printPreviewDialogSerwis.Name = "printPreviewDialogSerwis";
            this.printPreviewDialogSerwis.Visible = false;
            // 
            // printDocumentSerwis
            // 
            this.printDocumentSerwis.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentSerwis_PrintPage);
            // 
            // printDocumentSprzedaz
            // 
            this.printDocumentSprzedaz.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentSprzedaz_PrintPage);
            // 
            // printDialogSprzedaz
            // 
            this.printDialogSprzedaz.UseEXDialog = true;
            // 
            // printPreviewDialogSprzedaz
            // 
            this.printPreviewDialogSprzedaz.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSprzedaz.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSprzedaz.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogSprzedaz.Enabled = true;
            this.printPreviewDialogSprzedaz.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogSprzedaz.Icon")));
            this.printPreviewDialogSprzedaz.Name = "printPreviewDialogSprzedaz";
            this.printPreviewDialogSprzedaz.Visible = false;
            // 
            // SekcjaRaportow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 368);
            this.Controls.Add(this.btZamknij);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SekcjaRaportow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekcjaRaportow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SekcjaRaportow_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chBLStatusy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRaportSerwisu;
        private System.Windows.Forms.Button btRaportSprzedazy;
        private System.Windows.Forms.DateTimePicker dtpDataRaportuSprzedazy;
        private System.Windows.Forms.Button btZamknij;
        private System.Windows.Forms.PrintDialog printDialogSerwis;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogSerwis;
        private System.Drawing.Printing.PrintDocument printDocumentSerwis;
        private System.Drawing.Printing.PrintDocument printDocumentSprzedaz;
        private System.Windows.Forms.PrintDialog printDialogSprzedaz;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogSprzedaz;
    }
}