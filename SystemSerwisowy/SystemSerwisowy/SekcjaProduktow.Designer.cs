namespace SystemSerwisowy
{
    partial class SekcjaProduktow
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
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            this.btDodawanie = new System.Windows.Forms.Button();
            this.btSprzedaz = new System.Windows.Forms.Button();
            this.btUsuwanie = new System.Windows.Forms.Button();
            this.btZamknij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWarunek = new System.Windows.Forms.ComboBox();
            this.tbSzukajka = new System.Windows.Forms.TextBox();
            this.chkDostepne = new System.Windows.Forms.CheckBox();
            this.chbSprzedane = new System.Windows.Forms.CheckBox();
            this.cbKategorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.AllowUserToAddRows = false;
            this.dgvProdukty.AllowUserToOrderColumns = true;
            this.dgvProdukty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdukty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProdukty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvProdukty.Location = new System.Drawing.Point(12, 131);
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.ReadOnly = true;
            this.dgvProdukty.RowHeadersVisible = false;
            this.dgvProdukty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdukty.Size = new System.Drawing.Size(1028, 363);
            this.dgvProdukty.TabIndex = 0;
            this.dgvProdukty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukty_CellClick);
            this.dgvProdukty.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdukty_CellDoubleClick);
            // 
            // btDodawanie
            // 
            this.btDodawanie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btDodawanie.Location = new System.Drawing.Point(237, 8);
            this.btDodawanie.Name = "btDodawanie";
            this.btDodawanie.Size = new System.Drawing.Size(110, 57);
            this.btDodawanie.TabIndex = 1;
            this.btDodawanie.Text = "Dodaj Urządzenie";
            this.btDodawanie.UseVisualStyleBackColor = true;
            this.btDodawanie.Click += new System.EventHandler(this.btDodawanie_Click);
            // 
            // btSprzedaz
            // 
            this.btSprzedaz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSprzedaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSprzedaz.Location = new System.Drawing.Point(459, 8);
            this.btSprzedaz.Name = "btSprzedaz";
            this.btSprzedaz.Size = new System.Drawing.Size(145, 57);
            this.btSprzedaz.TabIndex = 2;
            this.btSprzedaz.Text = "Sprzedaj/Edytuj Urządzenie";
            this.btSprzedaz.UseVisualStyleBackColor = true;
            this.btSprzedaz.Click += new System.EventHandler(this.btSprzedaz_Click);
            // 
            // btUsuwanie
            // 
            this.btUsuwanie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btUsuwanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btUsuwanie.Location = new System.Drawing.Point(685, 8);
            this.btUsuwanie.Name = "btUsuwanie";
            this.btUsuwanie.Size = new System.Drawing.Size(110, 57);
            this.btUsuwanie.TabIndex = 3;
            this.btUsuwanie.Text = "Usuń Urządzenie";
            this.btUsuwanie.UseVisualStyleBackColor = true;
            this.btUsuwanie.Click += new System.EventHandler(this.btUsuwanie_Click);
            // 
            // btZamknij
            // 
            this.btZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btZamknij.Location = new System.Drawing.Point(946, 501);
            this.btZamknij.Name = "btZamknij";
            this.btZamknij.Size = new System.Drawing.Size(94, 49);
            this.btZamknij.TabIndex = 4;
            this.btZamknij.Text = "Zamknij";
            this.btZamknij.UseVisualStyleBackColor = true;
            this.btZamknij.Click += new System.EventHandler(this.btZamknij_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(253, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wyszukaj po: ";
            // 
            // cbWarunek
            // 
            this.cbWarunek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbWarunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbWarunek.FormattingEnabled = true;
            this.cbWarunek.Items.AddRange(new object[] {
            "Nazwa",
            "Numer Seryjny",
            "Kategoria"});
            this.cbWarunek.Location = new System.Drawing.Point(348, 85);
            this.cbWarunek.Name = "cbWarunek";
            this.cbWarunek.Size = new System.Drawing.Size(121, 26);
            this.cbWarunek.TabIndex = 6;
            this.cbWarunek.SelectedIndexChanged += new System.EventHandler(this.cbWarunek_SelectedIndexChanged);
            // 
            // tbSzukajka
            // 
            this.tbSzukajka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSzukajka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSzukajka.Location = new System.Drawing.Point(491, 85);
            this.tbSzukajka.Name = "tbSzukajka";
            this.tbSzukajka.Size = new System.Drawing.Size(133, 24);
            this.tbSzukajka.TabIndex = 7;
            this.tbSzukajka.TextChanged += new System.EventHandler(this.tbSzukajka_TextChanged);
            // 
            // chkDostepne
            // 
            this.chkDostepne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkDostepne.AutoSize = true;
            this.chkDostepne.Checked = true;
            this.chkDostepne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDostepne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkDostepne.Location = new System.Drawing.Point(646, 71);
            this.chkDostepne.Name = "chkDostepne";
            this.chkDostepne.Size = new System.Drawing.Size(135, 24);
            this.chkDostepne.TabIndex = 8;
            this.chkDostepne.Text = "Tylko dostępne";
            this.chkDostepne.UseVisualStyleBackColor = true;
            this.chkDostepne.CheckedChanged += new System.EventHandler(this.chkDostepne_CheckedChanged);
            // 
            // chbSprzedane
            // 
            this.chbSprzedane.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbSprzedane.AutoSize = true;
            this.chbSprzedane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbSprzedane.Location = new System.Drawing.Point(646, 102);
            this.chbSprzedane.Name = "chbSprzedane";
            this.chbSprzedane.Size = new System.Drawing.Size(143, 24);
            this.chbSprzedane.TabIndex = 9;
            this.chbSprzedane.Text = "Tylko sprzedane";
            this.chbSprzedane.UseVisualStyleBackColor = true;
            this.chbSprzedane.CheckedChanged += new System.EventHandler(this.chbSprzedane_CheckedChanged);
            // 
            // cbKategorie
            // 
            this.cbKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKategorie.FormattingEnabled = true;
            this.cbKategorie.Location = new System.Drawing.Point(491, 85);
            this.cbKategorie.Name = "cbKategorie";
            this.cbKategorie.Size = new System.Drawing.Size(133, 24);
            this.cbKategorie.TabIndex = 24;
            this.cbKategorie.Visible = false;
            this.cbKategorie.SelectedIndexChanged += new System.EventHandler(this.cbKategorie_SelectedIndexChanged);
            // 
            // SekcjaProduktow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 562);
            this.Controls.Add(this.cbKategorie);
            this.Controls.Add(this.chbSprzedane);
            this.Controls.Add(this.chkDostepne);
            this.Controls.Add(this.tbSzukajka);
            this.Controls.Add(this.cbWarunek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btZamknij);
            this.Controls.Add(this.btUsuwanie);
            this.Controls.Add(this.btSprzedaz);
            this.Controls.Add(this.btDodawanie);
            this.Controls.Add(this.dgvProdukty);
            this.Name = "SekcjaProduktow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elektronika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SekcjaProduktow_FormClosing);
            this.Load += new System.EventHandler(this.SekcjaProduktow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdukty;
        private System.Windows.Forms.Button btDodawanie;
        private System.Windows.Forms.Button btSprzedaz;
        private System.Windows.Forms.Button btUsuwanie;
        private System.Windows.Forms.Button btZamknij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWarunek;
        private System.Windows.Forms.TextBox tbSzukajka;
        private System.Windows.Forms.CheckBox chkDostepne;
        private System.Windows.Forms.CheckBox chbSprzedane;
        private System.Windows.Forms.ComboBox cbKategorie;
    }
}