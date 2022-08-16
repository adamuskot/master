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
            this.dtpDataRaportuSerwisu = new System.Windows.Forms.DateTimePicker();
            this.btRaportSerwisu = new System.Windows.Forms.Button();
            this.lblStatusy = new System.Windows.Forms.Label();
            this.chBLStatusy = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.dtpDataDoRaportuSprzedazy = new System.Windows.Forms.DateTimePicker();
            this.btRaportSprzedazy = new System.Windows.Forms.Button();
            this.dtpDataOdRaportuSprzedazy = new System.Windows.Forms.DateTimePicker();
            this.btZamknij = new System.Windows.Forms.Button();
            this.printDialogSerwis = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialogSerwis = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentSerwis = new System.Drawing.Printing.PrintDocument();
            this.printDocumentSprzedaz = new System.Drawing.Printing.PrintDocument();
            this.printDialogSprzedaz = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialogSprzedaz = new System.Windows.Forms.PrintPreviewDialog();
            this.btRaportStanu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.dtpDataRaportuSerwisu);
            this.groupBox1.Controls.Add(this.btRaportSerwisu);
            this.groupBox1.Controls.Add(this.lblStatusy);
            this.groupBox1.Controls.Add(this.chBLStatusy);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raport Serwisu";
            // 
            // dtpDataRaportuSerwisu
            // 
            this.dtpDataRaportuSerwisu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataRaportuSerwisu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRaportuSerwisu.Location = new System.Drawing.Point(7, 162);
            this.dtpDataRaportuSerwisu.Name = "dtpDataRaportuSerwisu";
            this.dtpDataRaportuSerwisu.Size = new System.Drawing.Size(331, 20);
            this.dtpDataRaportuSerwisu.TabIndex = 4;
            // 
            // btRaportSerwisu
            // 
            this.btRaportSerwisu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRaportSerwisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRaportSerwisu.Location = new System.Drawing.Point(7, 188);
            this.btRaportSerwisu.Name = "btRaportSerwisu";
            this.btRaportSerwisu.Size = new System.Drawing.Size(159, 57);
            this.btRaportSerwisu.TabIndex = 3;
            this.btRaportSerwisu.Text = "Generuj Raport Serwisu Statusów";
            this.btRaportSerwisu.UseVisualStyleBackColor = true;
            this.btRaportSerwisu.Click += new System.EventHandler(this.btRaportSerwisu_Click);
            // 
            // lblStatusy
            // 
            this.lblStatusy.AutoSize = true;
            this.lblStatusy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusy.Location = new System.Drawing.Point(6, 19);
            this.lblStatusy.Name = "lblStatusy";
            this.lblStatusy.Size = new System.Drawing.Size(169, 16);
            this.lblStatusy.TabIndex = 1;
            this.lblStatusy.Text = "Wybierz statusy do raportu:";
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
            "Czeka na decyzję klienta",
            "Oddany Naprawiony/Nienaprawiony"});
            this.chBLStatusy.Location = new System.Drawing.Point(7, 47);
            this.chBLStatusy.Name = "chBLStatusy";
            this.chBLStatusy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBLStatusy.Size = new System.Drawing.Size(331, 109);
            this.chBLStatusy.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.lblDo);
            this.groupBox2.Controls.Add(this.lblOd);
            this.groupBox2.Controls.Add(this.dtpDataDoRaportuSprzedazy);
            this.groupBox2.Controls.Add(this.btRaportSprzedazy);
            this.groupBox2.Controls.Add(this.dtpDataOdRaportuSprzedazy);
            this.groupBox2.Location = new System.Drawing.Point(371, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raport Sprzedaży";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDo.Location = new System.Drawing.Point(23, 62);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(29, 16);
            this.lblDo.TabIndex = 7;
            this.lblDo.Text = "Do:";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOd.Location = new System.Drawing.Point(23, 23);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(29, 16);
            this.lblOd.TabIndex = 6;
            this.lblOd.Text = "Od:";
            // 
            // dtpDataDoRaportuSprzedazy
            // 
            this.dtpDataDoRaportuSprzedazy.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataDoRaportuSprzedazy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDoRaportuSprzedazy.Location = new System.Drawing.Point(26, 78);
            this.dtpDataDoRaportuSprzedazy.Name = "dtpDataDoRaportuSprzedazy";
            this.dtpDataDoRaportuSprzedazy.Size = new System.Drawing.Size(300, 20);
            this.dtpDataDoRaportuSprzedazy.TabIndex = 5;
            // 
            // btRaportSprzedazy
            // 
            this.btRaportSprzedazy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRaportSprzedazy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRaportSprzedazy.Location = new System.Drawing.Point(87, 116);
            this.btRaportSprzedazy.Name = "btRaportSprzedazy";
            this.btRaportSprzedazy.Size = new System.Drawing.Size(170, 57);
            this.btRaportSprzedazy.TabIndex = 4;
            this.btRaportSprzedazy.Text = "Generuj Raport";
            this.btRaportSprzedazy.UseVisualStyleBackColor = true;
            this.btRaportSprzedazy.Click += new System.EventHandler(this.btRaportSprzedazy_Click);
            // 
            // dtpDataOdRaportuSprzedazy
            // 
            this.dtpDataOdRaportuSprzedazy.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataOdRaportuSprzedazy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataOdRaportuSprzedazy.Location = new System.Drawing.Point(26, 39);
            this.dtpDataOdRaportuSprzedazy.Name = "dtpDataOdRaportuSprzedazy";
            this.dtpDataOdRaportuSprzedazy.Size = new System.Drawing.Size(300, 20);
            this.dtpDataOdRaportuSprzedazy.TabIndex = 0;
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
            // btRaportStanu
            // 
            this.btRaportStanu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRaportStanu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRaportStanu.Location = new System.Drawing.Point(87, 26);
            this.btRaportStanu.Name = "btRaportStanu";
            this.btRaportStanu.Size = new System.Drawing.Size(170, 57);
            this.btRaportStanu.TabIndex = 5;
            this.btRaportStanu.Text = "Generuj Raport Stanu XLSX";
            this.btRaportStanu.UseVisualStyleBackColor = true;
            this.btRaportStanu.Click += new System.EventHandler(this.btRaportStanu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btRaportStanu);
            this.groupBox3.Location = new System.Drawing.Point(371, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 102);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Raport Stanu";
            // 
            // SekcjaRaportow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 368);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chBLStatusy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatusy;
        private System.Windows.Forms.Button btRaportSerwisu;
        private System.Windows.Forms.Button btRaportSprzedazy;
        private System.Windows.Forms.DateTimePicker dtpDataOdRaportuSprzedazy;
        private System.Windows.Forms.Button btZamknij;
        private System.Windows.Forms.PrintDialog printDialogSerwis;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogSerwis;
        private System.Drawing.Printing.PrintDocument printDocumentSerwis;
        private System.Drawing.Printing.PrintDocument printDocumentSprzedaz;
        private System.Windows.Forms.PrintDialog printDialogSprzedaz;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogSprzedaz;
        private System.Windows.Forms.DateTimePicker dtpDataRaportuSerwisu;
        private System.Windows.Forms.Button btRaportStanu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.DateTimePicker dtpDataDoRaportuSprzedazy;
    }
}