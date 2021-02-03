namespace SystemSerwisowy
{
    partial class Glowna
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glowna));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknij = new System.Windows.Forms.ToolStripMenuItem();
            this.PomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DaneOFirmie = new System.Windows.Forms.ToolStripMenuItem();
            this.regulaminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trescSmsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.wydrukiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportStanuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btSerwis = new System.Windows.Forms.Button();
            this.btProdukty = new System.Windows.Forms.Button();
            this.btAkcesoria = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbRaport = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPopsute = new System.Windows.Forms.Label();
            this.lblNaprawione = new System.Windows.Forms.Label();
            this.lblDecyzja = new System.Windows.Forms.Label();
            this.lblCzesci = new System.Windows.Forms.Label();
            this.lblGwarancja = new System.Windows.Forms.Label();
            this.lblPrzyjete = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSprzedaz = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblAkcesoria = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnRaporty = new System.Windows.Forms.Button();
            this.wersjaProgramuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.PomocToolStripMenuItem,
            this.wydrukiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(647, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.zamknij});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // zamknij
            // 
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(117, 22);
            this.zamknij.Text = "Zamknij";
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // PomocToolStripMenuItem
            // 
            this.PomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DaneOFirmie,
            this.regulaminToolStripMenuItem,
            this.trescSmsToolStrip,
            this.wersjaProgramuStripMenuItem});
            this.PomocToolStripMenuItem.Name = "PomocToolStripMenuItem";
            this.PomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.PomocToolStripMenuItem.Text = "Pomoc";
            // 
            // DaneOFirmie
            // 
            this.DaneOFirmie.Name = "DaneOFirmie";
            this.DaneOFirmie.Size = new System.Drawing.Size(165, 22);
            this.DaneOFirmie.Text = "Dane o Firmie";
            this.DaneOFirmie.Click += new System.EventHandler(this.DaneOFirmie_Click);
            // 
            // regulaminToolStripMenuItem
            // 
            this.regulaminToolStripMenuItem.Name = "regulaminToolStripMenuItem";
            this.regulaminToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.regulaminToolStripMenuItem.Text = "Regulamin";
            this.regulaminToolStripMenuItem.Click += new System.EventHandler(this.regulaminToolStripMenuItem_Click);
            // 
            // trescSmsToolStrip
            // 
            this.trescSmsToolStrip.Name = "trescSmsToolStrip";
            this.trescSmsToolStrip.Size = new System.Drawing.Size(165, 22);
            this.trescSmsToolStrip.Text = "Treść SMS";
            this.trescSmsToolStrip.Click += new System.EventHandler(this.trescSmsToolStrip_Click);
            // 
            // wydrukiToolStripMenuItem
            // 
            this.wydrukiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raportStanuToolStripMenuItem1});
            this.wydrukiToolStripMenuItem.Name = "wydrukiToolStripMenuItem";
            this.wydrukiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wydrukiToolStripMenuItem.Text = "Wydruki";
            // 
            // raportStanuToolStripMenuItem1
            // 
            this.raportStanuToolStripMenuItem1.Name = "raportStanuToolStripMenuItem1";
            this.raportStanuToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.raportStanuToolStripMenuItem1.Text = "Raport Stanu";
            this.raportStanuToolStripMenuItem1.Click += new System.EventHandler(this.raportStanuToolStripMenuItem1_Click);
            // 
            // btSerwis
            // 
            this.btSerwis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSerwis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSerwis.Location = new System.Drawing.Point(64, 53);
            this.btSerwis.Name = "btSerwis";
            this.btSerwis.Size = new System.Drawing.Size(113, 54);
            this.btSerwis.TabIndex = 2;
            this.btSerwis.Text = "Panel Serwisowy";
            this.btSerwis.UseVisualStyleBackColor = true;
            this.btSerwis.Click += new System.EventHandler(this.btSerwis_Click);
            // 
            // btProdukty
            // 
            this.btProdukty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btProdukty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btProdukty.Location = new System.Drawing.Point(203, 53);
            this.btProdukty.Name = "btProdukty";
            this.btProdukty.Size = new System.Drawing.Size(113, 54);
            this.btProdukty.TabIndex = 3;
            this.btProdukty.Text = "Moduł Sprzedaży";
            this.btProdukty.UseVisualStyleBackColor = true;
            this.btProdukty.Click += new System.EventHandler(this.btProdukty_Click);
            // 
            // btAkcesoria
            // 
            this.btAkcesoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAkcesoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAkcesoria.Location = new System.Drawing.Point(338, 53);
            this.btAkcesoria.Name = "btAkcesoria";
            this.btAkcesoria.Size = new System.Drawing.Size(113, 54);
            this.btAkcesoria.TabIndex = 4;
            this.btAkcesoria.Text = "Panel Części";
            this.btAkcesoria.UseVisualStyleBackColor = true;
            this.btAkcesoria.Click += new System.EventHandler(this.btAkcesoria_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 7200000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbRaport
            // 
            this.gbRaport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbRaport.Location = new System.Drawing.Point(54, 127);
            this.gbRaport.Name = "gbRaport";
            this.gbRaport.Size = new System.Drawing.Size(533, 226);
            this.gbRaport.TabIndex = 5;
            this.gbRaport.TabStop = false;
            this.gbRaport.Text = "Raporty";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(60, 150);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 197);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.lblPopsute);
            this.tabPage1.Controls.Add(this.lblNaprawione);
            this.tabPage1.Controls.Add(this.lblDecyzja);
            this.tabPage1.Controls.Add(this.lblCzesci);
            this.tabPage1.Controls.Add(this.lblGwarancja);
            this.tabPage1.Controls.Add(this.lblPrzyjete);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 168);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SERWIS";
            // 
            // lblPopsute
            // 
            this.lblPopsute.AutoSize = true;
            this.lblPopsute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPopsute.Location = new System.Drawing.Point(16, 101);
            this.lblPopsute.Name = "lblPopsute";
            this.lblPopsute.Size = new System.Drawing.Size(29, 16);
            this.lblPopsute.TabIndex = 9;
            this.lblPopsute.Text = "info";
            // 
            // lblNaprawione
            // 
            this.lblNaprawione.AutoSize = true;
            this.lblNaprawione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaprawione.Location = new System.Drawing.Point(16, 83);
            this.lblNaprawione.Name = "lblNaprawione";
            this.lblNaprawione.Size = new System.Drawing.Size(29, 16);
            this.lblNaprawione.TabIndex = 8;
            this.lblNaprawione.Text = "info";
            // 
            // lblDecyzja
            // 
            this.lblDecyzja.AutoSize = true;
            this.lblDecyzja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDecyzja.Location = new System.Drawing.Point(16, 65);
            this.lblDecyzja.Name = "lblDecyzja";
            this.lblDecyzja.Size = new System.Drawing.Size(29, 16);
            this.lblDecyzja.TabIndex = 7;
            this.lblDecyzja.Text = "info";
            // 
            // lblCzesci
            // 
            this.lblCzesci.AutoSize = true;
            this.lblCzesci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzesci.Location = new System.Drawing.Point(16, 47);
            this.lblCzesci.Name = "lblCzesci";
            this.lblCzesci.Size = new System.Drawing.Size(29, 16);
            this.lblCzesci.TabIndex = 6;
            this.lblCzesci.Text = "info";
            // 
            // lblGwarancja
            // 
            this.lblGwarancja.AutoSize = true;
            this.lblGwarancja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGwarancja.Location = new System.Drawing.Point(16, 29);
            this.lblGwarancja.Name = "lblGwarancja";
            this.lblGwarancja.Size = new System.Drawing.Size(29, 16);
            this.lblGwarancja.TabIndex = 5;
            this.lblGwarancja.Text = "info";
            // 
            // lblPrzyjete
            // 
            this.lblPrzyjete.AutoSize = true;
            this.lblPrzyjete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzyjete.Location = new System.Drawing.Point(16, 11);
            this.lblPrzyjete.Name = "lblPrzyjete";
            this.lblPrzyjete.Size = new System.Drawing.Size(29, 16);
            this.lblPrzyjete.TabIndex = 4;
            this.lblPrzyjete.Text = "info";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.lblSprzedaz);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SPRZEDAŻ";
            // 
            // lblSprzedaz
            // 
            this.lblSprzedaz.AutoSize = true;
            this.lblSprzedaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSprzedaz.Location = new System.Drawing.Point(15, 13);
            this.lblSprzedaz.Name = "lblSprzedaz";
            this.lblSprzedaz.Size = new System.Drawing.Size(29, 16);
            this.lblSprzedaz.TabIndex = 0;
            this.lblSprzedaz.Text = "info";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.lblAkcesoria);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(513, 168);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AKCESORIA";
            // 
            // lblAkcesoria
            // 
            this.lblAkcesoria.AutoSize = true;
            this.lblAkcesoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAkcesoria.Location = new System.Drawing.Point(15, 14);
            this.lblAkcesoria.Name = "lblAkcesoria";
            this.lblAkcesoria.Size = new System.Drawing.Size(29, 16);
            this.lblAkcesoria.TabIndex = 0;
            this.lblAkcesoria.Text = "info";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // timer2
            // 
            this.timer2.Interval = 300000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnRaporty
            // 
            this.btnRaporty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRaporty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRaporty.Location = new System.Drawing.Point(474, 53);
            this.btnRaporty.Name = "btnRaporty";
            this.btnRaporty.Size = new System.Drawing.Size(113, 54);
            this.btnRaporty.TabIndex = 6;
            this.btnRaporty.Text = "Raporty";
            this.btnRaporty.UseVisualStyleBackColor = true;
            this.btnRaporty.Click += new System.EventHandler(this.btnRaporty_Click);
            // 
            // wersjaProgramuStripMenuItem
            // 
            this.wersjaProgramuStripMenuItem.Name = "wersjaProgramuStripMenuItem";
            this.wersjaProgramuStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.wersjaProgramuStripMenuItem.Text = "Wersja programu";
            this.wersjaProgramuStripMenuItem.Click += new System.EventHandler(this.wersjaProgramuStripMenuItem_Click);
            // 
            // Glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 386);
            this.Controls.Add(this.btnRaporty);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbRaport);
            this.Controls.Add(this.btAkcesoria);
            this.Controls.Add(this.btProdukty);
            this.Controls.Add(this.btSerwis);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Glowna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Serwisowy v1.0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Glowna_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem PomocToolStripMenuItem;
        private System.Windows.Forms.Button btSerwis;
        private System.Windows.Forms.Button btProdukty;
        private System.Windows.Forms.Button btAkcesoria;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zamknij;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbRaport;
        private System.Windows.Forms.Label lblPrzyjete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblPopsute;
        private System.Windows.Forms.Label lblNaprawione;
        private System.Windows.Forms.Label lblDecyzja;
        private System.Windows.Forms.Label lblCzesci;
        private System.Windows.Forms.Label lblGwarancja;
        private System.Windows.Forms.Label lblSprzedaz;
        private System.Windows.Forms.Label lblAkcesoria;
        private System.Windows.Forms.ToolStripMenuItem DaneOFirmie;
        private System.Windows.Forms.ToolStripMenuItem regulaminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wydrukiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportStanuToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnRaporty;
        private System.Windows.Forms.ToolStripMenuItem trescSmsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem wersjaProgramuStripMenuItem;
    }
}

