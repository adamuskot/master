namespace SystemSerwisowy
{
    partial class SprzedajAkcesoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudIlosc = new System.Windows.Forms.NumericUpDown();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbNazwa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSprzedaj = new System.Windows.Forms.Button();
            this.btAnuluj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIlosc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nudIlosc);
            this.panel1.Controls.Add(this.tbCena);
            this.panel1.Controls.Add(this.tbNazwa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 124);
            this.panel1.TabIndex = 0;
            // 
            // nudIlosc
            // 
            this.nudIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudIlosc.Location = new System.Drawing.Point(112, 74);
            this.nudIlosc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIlosc.Name = "nudIlosc";
            this.nudIlosc.Size = new System.Drawing.Size(49, 22);
            this.nudIlosc.TabIndex = 7;
            this.nudIlosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudIlosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbCena
            // 
            this.tbCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCena.Location = new System.Drawing.Point(112, 46);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(75, 22);
            this.tbCena.TabIndex = 6;
            // 
            // tbNazwa
            // 
            this.tbNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNazwa.Location = new System.Drawing.Point(112, 18);
            this.tbNazwa.Name = "tbNazwa";
            this.tbNazwa.Size = new System.Drawing.Size(172, 22);
            this.tbNazwa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ilość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // btSprzedaj
            // 
            this.btSprzedaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSprzedaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSprzedaj.Location = new System.Drawing.Point(207, 147);
            this.btSprzedaj.Name = "btSprzedaj";
            this.btSprzedaj.Size = new System.Drawing.Size(100, 47);
            this.btSprzedaj.TabIndex = 1;
            this.btSprzedaj.Text = "Sprzedaj";
            this.btSprzedaj.UseVisualStyleBackColor = true;
            this.btSprzedaj.Click += new System.EventHandler(this.btSprzedaj_Click);
            // 
            // btAnuluj
            // 
            this.btAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAnuluj.Location = new System.Drawing.Point(101, 147);
            this.btAnuluj.Name = "btAnuluj";
            this.btAnuluj.Size = new System.Drawing.Size(100, 47);
            this.btAnuluj.TabIndex = 2;
            this.btAnuluj.Text = "Anuluj";
            this.btAnuluj.UseVisualStyleBackColor = true;
            this.btAnuluj.Click += new System.EventHandler(this.btAnuluj_Click);
            // 
            // SprzedajAkcesoria
            // 
            this.AcceptButton = this.btSprzedaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAnuluj;
            this.ClientSize = new System.Drawing.Size(319, 206);
            this.Controls.Add(this.btAnuluj);
            this.Controls.Add(this.btSprzedaj);
            this.Controls.Add(this.panel1);
            this.Name = "SprzedajAkcesoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprzedaj Części";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SprzedajAkcesoria_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIlosc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudIlosc;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbNazwa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSprzedaj;
        private System.Windows.Forms.Button btAnuluj;
    }
}