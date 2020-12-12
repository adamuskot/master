namespace SystemSerwisowy
{
    partial class Raportowanie
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSprzedazy = new System.Windows.Forms.RadioButton();
            this.rbKupione = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpMiesieczny = new System.Windows.Forms.DateTimePicker();
            this.dtpDzienny = new System.Windows.Forms.DateTimePicker();
            this.rbMiesieczny = new System.Windows.Forms.RadioButton();
            this.rbDzienny = new System.Windows.Forms.RadioButton();
            this.btnRaport = new System.Windows.Forms.Button();
            this.rbZakres = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.tbRaport = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSprzedazy);
            this.groupBox1.Controls.Add(this.rbKupione);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Typ raportu";
            // 
            // rbSprzedazy
            // 
            this.rbSprzedazy.AutoSize = true;
            this.rbSprzedazy.Location = new System.Drawing.Point(6, 83);
            this.rbSprzedazy.Name = "rbSprzedazy";
            this.rbSprzedazy.Size = new System.Drawing.Size(107, 17);
            this.rbSprzedazy.TabIndex = 1;
            this.rbSprzedazy.TabStop = true;
            this.rbSprzedazy.Text = "Raport sprzedaży";
            this.rbSprzedazy.UseVisualStyleBackColor = true;
            // 
            // rbKupione
            // 
            this.rbKupione.AutoSize = true;
            this.rbKupione.Location = new System.Drawing.Point(6, 46);
            this.rbKupione.Name = "rbKupione";
            this.rbKupione.Size = new System.Drawing.Size(90, 17);
            this.rbKupione.TabIndex = 0;
            this.rbKupione.TabStop = true;
            this.rbKupione.Text = "Raport kupna";
            this.rbKupione.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDo);
            this.groupBox2.Controls.Add(this.dtpOd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rbZakres);
            this.groupBox2.Controls.Add(this.dtpMiesieczny);
            this.groupBox2.Controls.Add(this.dtpDzienny);
            this.groupBox2.Controls.Add(this.rbMiesieczny);
            this.groupBox2.Controls.Add(this.rbDzienny);
            this.groupBox2.Location = new System.Drawing.Point(173, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zakres raportu";
            // 
            // dtpMiesieczny
            // 
            this.dtpMiesieczny.CustomFormat = "MMMM yyyy";
            this.dtpMiesieczny.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMiesieczny.Location = new System.Drawing.Point(103, 68);
            this.dtpMiesieczny.Name = "dtpMiesieczny";
            this.dtpMiesieczny.Size = new System.Drawing.Size(126, 20);
            this.dtpMiesieczny.TabIndex = 3;
            // 
            // dtpDzienny
            // 
            this.dtpDzienny.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDzienny.Location = new System.Drawing.Point(103, 31);
            this.dtpDzienny.Name = "dtpDzienny";
            this.dtpDzienny.Size = new System.Drawing.Size(126, 20);
            this.dtpDzienny.TabIndex = 2;
            // 
            // rbMiesieczny
            // 
            this.rbMiesieczny.AutoSize = true;
            this.rbMiesieczny.Location = new System.Drawing.Point(7, 68);
            this.rbMiesieczny.Name = "rbMiesieczny";
            this.rbMiesieczny.Size = new System.Drawing.Size(77, 17);
            this.rbMiesieczny.TabIndex = 1;
            this.rbMiesieczny.TabStop = true;
            this.rbMiesieczny.Text = "Miesieczny";
            this.rbMiesieczny.UseVisualStyleBackColor = true;
            // 
            // rbDzienny
            // 
            this.rbDzienny.AutoSize = true;
            this.rbDzienny.Location = new System.Drawing.Point(7, 31);
            this.rbDzienny.Name = "rbDzienny";
            this.rbDzienny.Size = new System.Drawing.Size(63, 17);
            this.rbDzienny.TabIndex = 0;
            this.rbDzienny.TabStop = true;
            this.rbDzienny.Text = "Dzienny";
            this.rbDzienny.UseVisualStyleBackColor = true;
            // 
            // btnRaport
            // 
            this.btnRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRaport.Location = new System.Drawing.Point(484, 33);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(137, 68);
            this.btnRaport.TabIndex = 2;
            this.btnRaport.Text = "Generuj raport";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // rbZakres
            // 
            this.rbZakres.AutoSize = true;
            this.rbZakres.Location = new System.Drawing.Point(7, 102);
            this.rbZakres.Name = "rbZakres";
            this.rbZakres.Size = new System.Drawing.Size(76, 17);
            this.rbZakres.TabIndex = 4;
            this.rbZakres.TabStop = true;
            this.rbZakres.Text = "Zakres dat";
            this.rbZakres.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Od: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Do:";
            // 
            // dtpOd
            // 
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOd.Location = new System.Drawing.Point(137, 94);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(112, 20);
            this.dtpOd.TabIndex = 7;
            // 
            // dtpDo
            // 
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDo.Location = new System.Drawing.Point(137, 119);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(112, 20);
            this.dtpDo.TabIndex = 8;
            // 
            // tbRaport
            // 
            this.tbRaport.AcceptsReturn = true;
            this.tbRaport.AcceptsTab = true;
            this.tbRaport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRaport.Location = new System.Drawing.Point(13, 204);
            this.tbRaport.Multiline = true;
            this.tbRaport.Name = "tbRaport";
            this.tbRaport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbRaport.Size = new System.Drawing.Size(608, 219);
            this.tbRaport.TabIndex = 3;
            // 
            // Raportowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 435);
            this.Controls.Add(this.tbRaport);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Raportowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raportowanie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Raportowanie_FormClosing);
            this.Load += new System.EventHandler(this.Raportowanie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSprzedazy;
        private System.Windows.Forms.RadioButton rbKupione;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMiesieczny;
        private System.Windows.Forms.RadioButton rbDzienny;
        private System.Windows.Forms.DateTimePicker dtpMiesieczny;
        private System.Windows.Forms.DateTimePicker dtpDzienny;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbZakres;
        private System.Windows.Forms.TextBox tbRaport;
    }
}