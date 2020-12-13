namespace SystemSerwisowy
{
    partial class Regulamin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regulamin));
            this.btZapisz = new System.Windows.Forms.Button();
            this.btAnuluj = new System.Windows.Forms.Button();
            this.RTBRegulamin = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btZapisz
            // 
            this.btZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btZapisz.Location = new System.Drawing.Point(1082, 333);
            this.btZapisz.Name = "btZapisz";
            this.btZapisz.Size = new System.Drawing.Size(99, 52);
            this.btZapisz.TabIndex = 1;
            this.btZapisz.Text = "Zapisz";
            this.btZapisz.UseVisualStyleBackColor = true;
            this.btZapisz.Click += new System.EventHandler(this.btZapisz_Click);
            // 
            // btAnuluj
            // 
            this.btAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAnuluj.Location = new System.Drawing.Point(974, 333);
            this.btAnuluj.Name = "btAnuluj";
            this.btAnuluj.Size = new System.Drawing.Size(102, 52);
            this.btAnuluj.TabIndex = 2;
            this.btAnuluj.Text = "Anuluj";
            this.btAnuluj.UseVisualStyleBackColor = true;
            this.btAnuluj.Click += new System.EventHandler(this.btAnuluj_Click);
            // 
            // RTBRegulamin
            // 
            this.RTBRegulamin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBRegulamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RTBRegulamin.Location = new System.Drawing.Point(13, 12);
            this.RTBRegulamin.Name = "RTBRegulamin";
            this.RTBRegulamin.Size = new System.Drawing.Size(1168, 315);
            this.RTBRegulamin.TabIndex = 3;
            this.RTBRegulamin.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(912, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Regulamin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAnuluj;
            this.ClientSize = new System.Drawing.Size(1193, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTBRegulamin);
            this.Controls.Add(this.btAnuluj);
            this.Controls.Add(this.btZapisz);
            this.Name = "Regulamin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regulamin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Regulamin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btZapisz;
        private System.Windows.Forms.Button btAnuluj;
        private System.Windows.Forms.RichTextBox RTBRegulamin;
        private System.Windows.Forms.Label label1;
    }
}