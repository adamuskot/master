namespace SystemSerwisowy
{
    partial class SekcjaSerwisu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekcjaSerwisu));
            this.dgvUsterki = new System.Windows.Forms.DataGridView();
            this.btNowy = new System.Windows.Forms.Button();
            this.btEdycja = new System.Windows.Forms.Button();
            this.btUsun = new System.Windows.Forms.Button();
            this.btZamknij = new System.Windows.Forms.Button();
            this.chbStan = new System.Windows.Forms.CheckBox();
            this.btPotwierdzenie = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKryterium = new System.Windows.Forms.ComboBox();
            this.tbSzukajka = new System.Windows.Forms.TextBox();
            this.chbNaprawa = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsterki)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsterki
            // 
            this.dgvUsterki.AllowUserToAddRows = false;
            this.dgvUsterki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsterki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsterki.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvUsterki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsterki.Location = new System.Drawing.Point(12, 133);
            this.dgvUsterki.Name = "dgvUsterki";
            this.dgvUsterki.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsterki.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsterki.RowHeadersVisible = false;
            this.dgvUsterki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsterki.ShowRowErrors = false;
            this.dgvUsterki.Size = new System.Drawing.Size(1305, 423);
            this.dgvUsterki.TabIndex = 0;
            this.dgvUsterki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsterki_CellClick);
            this.dgvUsterki.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsterki_CellDoubleClick);
            // 
            // btNowy
            // 
            this.btNowy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btNowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btNowy.Location = new System.Drawing.Point(486, 12);
            this.btNowy.Name = "btNowy";
            this.btNowy.Size = new System.Drawing.Size(132, 66);
            this.btNowy.TabIndex = 1;
            this.btNowy.Text = "Nowe zgłoszenie";
            this.btNowy.UseVisualStyleBackColor = true;
            this.btNowy.Click += new System.EventHandler(this.btNowy_Click);
            // 
            // btEdycja
            // 
            this.btEdycja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btEdycja.Location = new System.Drawing.Point(682, 12);
            this.btEdycja.Name = "btEdycja";
            this.btEdycja.Size = new System.Drawing.Size(109, 66);
            this.btEdycja.TabIndex = 2;
            this.btEdycja.Text = "Edycja zgłoszenia";
            this.btEdycja.UseVisualStyleBackColor = true;
            this.btEdycja.Click += new System.EventHandler(this.btEdycja_Click);
            // 
            // btUsun
            // 
            this.btUsun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btUsun.Location = new System.Drawing.Point(853, 12);
            this.btUsun.Name = "btUsun";
            this.btUsun.Size = new System.Drawing.Size(101, 66);
            this.btUsun.TabIndex = 3;
            this.btUsun.Text = "Usuń zgłoszenie";
            this.btUsun.UseVisualStyleBackColor = true;
            this.btUsun.Click += new System.EventHandler(this.btUsun_Click);
            // 
            // btZamknij
            // 
            this.btZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btZamknij.Location = new System.Drawing.Point(1211, 571);
            this.btZamknij.Name = "btZamknij";
            this.btZamknij.Size = new System.Drawing.Size(106, 44);
            this.btZamknij.TabIndex = 4;
            this.btZamknij.Text = "Zamknij";
            this.btZamknij.UseVisualStyleBackColor = true;
            this.btZamknij.Click += new System.EventHandler(this.btZamknij_Click);
            // 
            // chbStan
            // 
            this.chbStan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbStan.AutoSize = true;
            this.chbStan.Checked = true;
            this.chbStan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbStan.Location = new System.Drawing.Point(6, 57);
            this.chbStan.Name = "chbStan";
            this.chbStan.Size = new System.Drawing.Size(194, 22);
            this.chbStan.TabIndex = 5;
            this.chbStan.Text = "Pokaż produkty na stanie";
            this.chbStan.UseVisualStyleBackColor = true;
            this.chbStan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btPotwierdzenie
            // 
            this.btPotwierdzenie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPotwierdzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPotwierdzenie.Location = new System.Drawing.Point(296, 12);
            this.btPotwierdzenie.Name = "btPotwierdzenie";
            this.btPotwierdzenie.Size = new System.Drawing.Size(124, 66);
            this.btPotwierdzenie.TabIndex = 6;
            this.btPotwierdzenie.Text = "Wydrukuj potwierdzenie";
            this.btPotwierdzenie.UseVisualStyleBackColor = true;
            this.btPotwierdzenie.Click += new System.EventHandler(this.btPotwierdzenie_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(293, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wyszukiwarka:";
            // 
            // cbKryterium
            // 
            this.cbKryterium.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbKryterium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKryterium.FormattingEnabled = true;
            this.cbKryterium.Items.AddRange(new object[] {
            "Nazwisko",
            "Model",
            "Numer Seryjny"});
            this.cbKryterium.Location = new System.Drawing.Point(431, 96);
            this.cbKryterium.Name = "cbKryterium";
            this.cbKryterium.Size = new System.Drawing.Size(149, 24);
            this.cbKryterium.TabIndex = 8;
            // 
            // tbSzukajka
            // 
            this.tbSzukajka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSzukajka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSzukajka.Location = new System.Drawing.Point(634, 94);
            this.tbSzukajka.Name = "tbSzukajka";
            this.tbSzukajka.Size = new System.Drawing.Size(157, 24);
            this.tbSzukajka.TabIndex = 9;
            this.tbSzukajka.TextChanged += new System.EventHandler(this.tbSzukajka_TextChanged);
            // 
            // chbNaprawa
            // 
            this.chbNaprawa.AutoSize = true;
            this.chbNaprawa.Checked = true;
            this.chbNaprawa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNaprawa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.chbNaprawa.Location = new System.Drawing.Point(6, 29);
            this.chbNaprawa.Name = "chbNaprawa";
            this.chbNaprawa.Size = new System.Drawing.Size(266, 22);
            this.chbNaprawa.TabIndex = 10;
            this.chbNaprawa.Text = "Pokaż produkty przyjęte do naprawy";
            this.chbNaprawa.UseVisualStyleBackColor = true;
            this.chbNaprawa.CheckedChanged += new System.EventHandler(this.chbNaprawa_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbNaprawa);
            this.groupBox1.Controls.Add(this.chbStan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(986, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtry";
            // 
            // SekcjaSerwisu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSzukajka);
            this.Controls.Add(this.cbKryterium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPotwierdzenie);
            this.Controls.Add(this.btZamknij);
            this.Controls.Add(this.btUsun);
            this.Controls.Add(this.btEdycja);
            this.Controls.Add(this.btNowy);
            this.Controls.Add(this.dgvUsterki);
            this.Name = "SekcjaSerwisu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekcja Serwisu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SekcjaSerwisu_FormClosing);
            this.Load += new System.EventHandler(this.SekcjaSerwisu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsterki)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsterki;
        private System.Windows.Forms.Button btNowy;
        private System.Windows.Forms.Button btEdycja;
        private System.Windows.Forms.Button btUsun;
        private System.Windows.Forms.Button btZamknij;
        private System.Windows.Forms.CheckBox chbStan;
        private System.Windows.Forms.Button btPotwierdzenie;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKryterium;
        private System.Windows.Forms.TextBox tbSzukajka;
        private System.Windows.Forms.CheckBox chbNaprawa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}