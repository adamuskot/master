namespace SystemSerwisowy
{
    partial class SekcjaAkcesoriow
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
            this.btDodaj = new System.Windows.Forms.Button();
            this.btSprzedaj = new System.Windows.Forms.Button();
            this.btUsun = new System.Windows.Forms.Button();
            this.dgvAkcesoria = new System.Windows.Forms.DataGridView();
            this.BtZamknij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWarunek = new System.Windows.Forms.ComboBox();
            this.tbSzukajka = new System.Windows.Forms.TextBox();
            this.chbDostepne = new System.Windows.Forms.CheckBox();
            this.chbSprzedane = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkcesoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btDodaj
            // 
            this.btDodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btDodaj.Location = new System.Drawing.Point(211, 12);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(112, 49);
            this.btDodaj.TabIndex = 0;
            this.btDodaj.Text = "Dodaj Części";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btSprzedaj
            // 
            this.btSprzedaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSprzedaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSprzedaj.Location = new System.Drawing.Point(386, 12);
            this.btSprzedaj.Name = "btSprzedaj";
            this.btSprzedaj.Size = new System.Drawing.Size(115, 49);
            this.btSprzedaj.TabIndex = 1;
            this.btSprzedaj.Text = "Sprzedaj Części";
            this.btSprzedaj.UseVisualStyleBackColor = true;
            this.btSprzedaj.Click += new System.EventHandler(this.btSprzedaj_Click);
            // 
            // btUsun
            // 
            this.btUsun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btUsun.Location = new System.Drawing.Point(571, 12);
            this.btUsun.Name = "btUsun";
            this.btUsun.Size = new System.Drawing.Size(95, 49);
            this.btUsun.TabIndex = 2;
            this.btUsun.Text = "Usuń Części";
            this.btUsun.UseVisualStyleBackColor = true;
            this.btUsun.Click += new System.EventHandler(this.btUsun_Click);
            // 
            // dgvAkcesoria
            // 
            this.dgvAkcesoria.AllowUserToAddRows = false;
            this.dgvAkcesoria.AllowUserToOrderColumns = true;
            this.dgvAkcesoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAkcesoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAkcesoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAkcesoria.Location = new System.Drawing.Point(12, 134);
            this.dgvAkcesoria.Name = "dgvAkcesoria";
            this.dgvAkcesoria.ReadOnly = true;
            this.dgvAkcesoria.RowHeadersVisible = false;
            this.dgvAkcesoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAkcesoria.Size = new System.Drawing.Size(920, 354);
            this.dgvAkcesoria.TabIndex = 3;
            this.dgvAkcesoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtykuly_CellClick);
            this.dgvAkcesoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAkcesoria_CellDoubleClick);
            // 
            // BtZamknij
            // 
            this.BtZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtZamknij.Location = new System.Drawing.Point(804, 505);
            this.BtZamknij.Name = "BtZamknij";
            this.BtZamknij.Size = new System.Drawing.Size(128, 45);
            this.BtZamknij.TabIndex = 4;
            this.BtZamknij.Text = "Zamknij";
            this.BtZamknij.UseVisualStyleBackColor = true;
            this.BtZamknij.Click += new System.EventHandler(this.BtZamknij_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(218, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wyszukaj po:";
            // 
            // cbWarunek
            // 
            this.cbWarunek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbWarunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbWarunek.FormattingEnabled = true;
            this.cbWarunek.Items.AddRange(new object[] {
            "Nazwa"});
            this.cbWarunek.Location = new System.Drawing.Point(312, 89);
            this.cbWarunek.Name = "cbWarunek";
            this.cbWarunek.Size = new System.Drawing.Size(121, 24);
            this.cbWarunek.TabIndex = 6;
            // 
            // tbSzukajka
            // 
            this.tbSzukajka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSzukajka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSzukajka.Location = new System.Drawing.Point(459, 89);
            this.tbSzukajka.Name = "tbSzukajka";
            this.tbSzukajka.Size = new System.Drawing.Size(118, 22);
            this.tbSzukajka.TabIndex = 7;
            this.tbSzukajka.TextChanged += new System.EventHandler(this.tbSzukajka_TextChanged);
            // 
            // chbDostepne
            // 
            this.chbDostepne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbDostepne.AutoSize = true;
            this.chbDostepne.Checked = true;
            this.chbDostepne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDostepne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbDostepne.Location = new System.Drawing.Point(596, 77);
            this.chbDostepne.Name = "chbDostepne";
            this.chbDostepne.Size = new System.Drawing.Size(135, 24);
            this.chbDostepne.TabIndex = 8;
            this.chbDostepne.Text = "Tylko dostępne";
            this.chbDostepne.UseVisualStyleBackColor = true;
            this.chbDostepne.CheckedChanged += new System.EventHandler(this.chbDostepne_CheckedChanged);
            // 
            // chbSprzedane
            // 
            this.chbSprzedane.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbSprzedane.AutoSize = true;
            this.chbSprzedane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbSprzedane.Location = new System.Drawing.Point(596, 104);
            this.chbSprzedane.Name = "chbSprzedane";
            this.chbSprzedane.Size = new System.Drawing.Size(143, 24);
            this.chbSprzedane.TabIndex = 9;
            this.chbSprzedane.Text = "Tylko sprzedane";
            this.chbSprzedane.UseVisualStyleBackColor = true;
            this.chbSprzedane.CheckedChanged += new System.EventHandler(this.chbSprzedane_CheckedChanged);
            // 
            // SekcjaAkcesoriow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 562);
            this.Controls.Add(this.chbSprzedane);
            this.Controls.Add(this.chbDostepne);
            this.Controls.Add(this.tbSzukajka);
            this.Controls.Add(this.cbWarunek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtZamknij);
            this.Controls.Add(this.dgvAkcesoria);
            this.Controls.Add(this.btUsun);
            this.Controls.Add(this.btSprzedaj);
            this.Controls.Add(this.btDodaj);
            this.Name = "SekcjaAkcesoriow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekcja Części";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SekcjaAkcesoriow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkcesoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btSprzedaj;
        private System.Windows.Forms.Button btUsun;
        private System.Windows.Forms.DataGridView dgvAkcesoria;
        private System.Windows.Forms.Button BtZamknij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWarunek;
        private System.Windows.Forms.TextBox tbSzukajka;
        private System.Windows.Forms.CheckBox chbDostepne;
        private System.Windows.Forms.CheckBox chbSprzedane;
    }
}