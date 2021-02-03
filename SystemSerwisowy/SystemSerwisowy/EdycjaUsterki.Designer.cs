namespace SystemSerwisowy
{
    partial class EdycjaUsterki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdycjaUsterki));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbZgoda = new System.Windows.Forms.ComboBox();
            this.lblZgoda = new System.Windows.Forms.Label();
            this.chbSmsWyslany = new System.Windows.Forms.CheckBox();
            this.btnWyslijSms = new System.Windows.Forms.Button();
            this.chbPilne = new System.Windows.Forms.CheckBox();
            this.tbNaprawy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDataDo = new System.Windows.Forms.TextBox();
            this.cbOdbior = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbDataOd = new System.Windows.Forms.TextBox();
            this.tbKoszt = new System.Windows.Forms.TextBox();
            this.tbUwagi = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.tbNumer = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btZapisz = new System.Windows.Forms.Button();
            this.btAnuluj = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cbBlokuj = new System.Windows.Forms.ComboBox();
            this.lblBlokuj = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbBlokuj);
            this.panel1.Controls.Add(this.lblBlokuj);
            this.panel1.Controls.Add(this.cbZgoda);
            this.panel1.Controls.Add(this.lblZgoda);
            this.panel1.Controls.Add(this.chbSmsWyslany);
            this.panel1.Controls.Add(this.btnWyslijSms);
            this.panel1.Controls.Add(this.chbPilne);
            this.panel1.Controls.Add(this.tbNaprawy);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tbDataDo);
            this.panel1.Controls.Add(this.cbOdbior);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.tbDataOd);
            this.panel1.Controls.Add(this.tbKoszt);
            this.panel1.Controls.Add(this.tbUwagi);
            this.panel1.Controls.Add(this.tbOpis);
            this.panel1.Controls.Add(this.tbNumer);
            this.panel1.Controls.Add(this.tbModel);
            this.panel1.Controls.Add(this.tbTelefon);
            this.panel1.Controls.Add(this.tbNazwisko);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 460);
            this.panel1.TabIndex = 1;
            // 
            // cbZgoda
            // 
            this.cbZgoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbZgoda.FormattingEnabled = true;
            this.cbZgoda.Items.AddRange(new object[] {
            "NIE",
            "TAK",
            "BRAK"});
            this.cbZgoda.Location = new System.Drawing.Point(158, 383);
            this.cbZgoda.Name = "cbZgoda";
            this.cbZgoda.Size = new System.Drawing.Size(112, 24);
            this.cbZgoda.TabIndex = 31;
            // 
            // lblZgoda
            // 
            this.lblZgoda.AutoSize = true;
            this.lblZgoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZgoda.Location = new System.Drawing.Point(21, 386);
            this.lblZgoda.Name = "lblZgoda";
            this.lblZgoda.Size = new System.Drawing.Size(93, 16);
            this.lblZgoda.TabIndex = 30;
            this.lblZgoda.Text = "Zgoda Elektro";
            // 
            // chbSmsWyslany
            // 
            this.chbSmsWyslany.AutoSize = true;
            this.chbSmsWyslany.Enabled = false;
            this.chbSmsWyslany.Location = new System.Drawing.Point(378, 76);
            this.chbSmsWyslany.Name = "chbSmsWyslany";
            this.chbSmsWyslany.Size = new System.Drawing.Size(68, 17);
            this.chbSmsWyslany.TabIndex = 29;
            this.chbSmsWyslany.Text = "Wysłany";
            this.chbSmsWyslany.UseVisualStyleBackColor = true;
            // 
            // btnWyslijSms
            // 
            this.btnWyslijSms.Location = new System.Drawing.Point(298, 70);
            this.btnWyslijSms.Name = "btnWyslijSms";
            this.btnWyslijSms.Size = new System.Drawing.Size(75, 23);
            this.btnWyslijSms.TabIndex = 28;
            this.btnWyslijSms.Text = "Wyślij SMS";
            this.btnWyslijSms.UseVisualStyleBackColor = true;
            this.btnWyslijSms.Click += new System.EventHandler(this.btnWyslijSms_Click);
            // 
            // chbPilne
            // 
            this.chbPilne.AutoSize = true;
            this.chbPilne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbPilne.Location = new System.Drawing.Point(341, 211);
            this.chbPilne.Name = "chbPilne";
            this.chbPilne.Size = new System.Drawing.Size(65, 20);
            this.chbPilne.TabIndex = 27;
            this.chbPilne.Text = "PILNE";
            this.chbPilne.UseVisualStyleBackColor = true;
            // 
            // tbNaprawy
            // 
            this.tbNaprawy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNaprawy.Location = new System.Drawing.Point(158, 353);
            this.tbNaprawy.Name = "tbNaprawy";
            this.tbNaprawy.Size = new System.Drawing.Size(288, 22);
            this.tbNaprawy.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(21, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Wykonane Naprawy";
            // 
            // tbDataDo
            // 
            this.tbDataDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDataDo.Location = new System.Drawing.Point(158, 267);
            this.tbDataDo.Name = "tbDataDo";
            this.tbDataDo.Size = new System.Drawing.Size(112, 22);
            this.tbDataDo.TabIndex = 24;
            // 
            // cbOdbior
            // 
            this.cbOdbior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbOdbior.FormattingEnabled = true;
            this.cbOdbior.Items.AddRange(new object[] {
            "NIE",
            "TAK"});
            this.cbOdbior.Location = new System.Drawing.Point(158, 323);
            this.cbOdbior.Name = "cbOdbior";
            this.cbOdbior.Size = new System.Drawing.Size(112, 24);
            this.cbOdbior.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(21, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Odbiór";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Naprawiony",
            "Brak możliwości naprawy",
            "Wysłane na gwarancję",
            "Przyjęty do naprawy",
            "Czeka na części",
            "Czeka na decyzje klienta",
            "Brak zgody na naprawę"});
            this.cbStatus.Location = new System.Drawing.Point(158, 293);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(202, 24);
            this.cbStatus.TabIndex = 21;
            // 
            // tbDataOd
            // 
            this.tbDataOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDataOd.Location = new System.Drawing.Point(158, 239);
            this.tbDataOd.Name = "tbDataOd";
            this.tbDataOd.Size = new System.Drawing.Size(112, 22);
            this.tbDataOd.TabIndex = 19;
            // 
            // tbKoszt
            // 
            this.tbKoszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKoszt.Location = new System.Drawing.Point(158, 211);
            this.tbKoszt.Name = "tbKoszt";
            this.tbKoszt.Size = new System.Drawing.Size(112, 22);
            this.tbKoszt.TabIndex = 18;
            // 
            // tbUwagi
            // 
            this.tbUwagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUwagi.Location = new System.Drawing.Point(158, 183);
            this.tbUwagi.Name = "tbUwagi";
            this.tbUwagi.Size = new System.Drawing.Size(288, 22);
            this.tbUwagi.TabIndex = 17;
            // 
            // tbOpis
            // 
            this.tbOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOpis.Location = new System.Drawing.Point(158, 155);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(288, 22);
            this.tbOpis.TabIndex = 16;
            // 
            // tbNumer
            // 
            this.tbNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNumer.Location = new System.Drawing.Point(158, 127);
            this.tbNumer.Name = "tbNumer";
            this.tbNumer.Size = new System.Drawing.Size(288, 22);
            this.tbNumer.TabIndex = 15;
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbModel.Location = new System.Drawing.Point(158, 99);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(288, 22);
            this.tbModel.TabIndex = 14;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTelefon.Location = new System.Drawing.Point(158, 71);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(134, 22);
            this.tbTelefon.TabIndex = 13;
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNazwisko.Location = new System.Drawing.Point(158, 43);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(215, 22);
            this.tbNazwisko.TabIndex = 12;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbId.Location = new System.Drawing.Point(158, 15);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(65, 22);
            this.tbId.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(21, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(21, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Data Realizacji";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(21, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Data Zgłoszenia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(21, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Przewidywany koszt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(21, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Uwagi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(21, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(21, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numer Seryjny";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marka i Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Kontaktowy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię i Nazwisko";
            // 
            // btZapisz
            // 
            this.btZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btZapisz.Location = new System.Drawing.Point(370, 478);
            this.btZapisz.Name = "btZapisz";
            this.btZapisz.Size = new System.Drawing.Size(102, 52);
            this.btZapisz.TabIndex = 2;
            this.btZapisz.Text = "Zapisz zmiany";
            this.btZapisz.UseVisualStyleBackColor = true;
            this.btZapisz.Click += new System.EventHandler(this.btZapisz_Click);
            // 
            // btAnuluj
            // 
            this.btAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAnuluj.Location = new System.Drawing.Point(251, 478);
            this.btAnuluj.Name = "btAnuluj";
            this.btAnuluj.Size = new System.Drawing.Size(102, 52);
            this.btAnuluj.TabIndex = 3;
            this.btAnuluj.Text = "Anuluj";
            this.btAnuluj.UseVisualStyleBackColor = true;
            this.btAnuluj.Click += new System.EventHandler(this.btAnuluj_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            // cbBlokuj
            // 
            this.cbBlokuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbBlokuj.FormattingEnabled = true;
            this.cbBlokuj.Items.AddRange(new object[] {
            "NIE",
            "TAK"});
            this.cbBlokuj.Location = new System.Drawing.Point(158, 413);
            this.cbBlokuj.Name = "cbBlokuj";
            this.cbBlokuj.Size = new System.Drawing.Size(112, 24);
            this.cbBlokuj.TabIndex = 33;
            // 
            // lblBlokuj
            // 
            this.lblBlokuj.AutoSize = true;
            this.lblBlokuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBlokuj.Location = new System.Drawing.Point(21, 416);
            this.lblBlokuj.Name = "lblBlokuj";
            this.lblBlokuj.Size = new System.Drawing.Size(88, 16);
            this.lblBlokuj.TabIndex = 32;
            this.lblBlokuj.Text = "Blokuj Klienta";
            // 
            // EdycjaUsterki
            // 
            this.AcceptButton = this.btZapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAnuluj;
            this.ClientSize = new System.Drawing.Size(484, 542);
            this.Controls.Add(this.btAnuluj);
            this.Controls.Add(this.btZapisz);
            this.Controls.Add(this.panel1);
            this.Name = "EdycjaUsterki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdycjaUsterki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EdycjaUsterki_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btZapisz;
        private System.Windows.Forms.Button btAnuluj;
        private System.Windows.Forms.TextBox tbDataOd;
        private System.Windows.Forms.TextBox tbKoszt;
        private System.Windows.Forms.TextBox tbUwagi;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.TextBox tbNumer;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbOdbior;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDataDo;
        private System.Windows.Forms.TextBox tbNaprawy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chbPilne;
        private System.Windows.Forms.Button btnWyslijSms;
        private System.Windows.Forms.CheckBox chbSmsWyslany;
        private System.Windows.Forms.ComboBox cbZgoda;
        private System.Windows.Forms.Label lblZgoda;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox cbBlokuj;
        private System.Windows.Forms.Label lblBlokuj;
    }
}