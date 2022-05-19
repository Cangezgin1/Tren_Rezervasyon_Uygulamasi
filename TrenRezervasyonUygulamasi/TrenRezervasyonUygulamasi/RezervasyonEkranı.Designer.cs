
namespace TrenRezervasyonUygulamasi
{
    partial class RezervasyonEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonEkranı));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdSoyadtxt = new System.Windows.Forms.TextBox();
            this.FarklıVagonComboBox = new System.Windows.Forms.ComboBox();
            this.RezervasyonBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VagonNoComboBox = new System.Windows.Forms.ComboBox();
            this.KisiSayısıComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kişi Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vagonlarda doluluk olduğu taktirde ";
            // 
            // AdSoyadtxt
            // 
            this.AdSoyadtxt.Location = new System.Drawing.Point(173, 143);
            this.AdSoyadtxt.Name = "AdSoyadtxt";
            this.AdSoyadtxt.Size = new System.Drawing.Size(144, 26);
            this.AdSoyadtxt.TabIndex = 0;
            // 
            // FarklıVagonComboBox
            // 
            this.FarklıVagonComboBox.FormattingEnabled = true;
            this.FarklıVagonComboBox.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.FarklıVagonComboBox.Location = new System.Drawing.Point(173, 310);
            this.FarklıVagonComboBox.Name = "FarklıVagonComboBox";
            this.FarklıVagonComboBox.Size = new System.Drawing.Size(144, 27);
            this.FarklıVagonComboBox.TabIndex = 3;
            // 
            // RezervasyonBtn
            // 
            this.RezervasyonBtn.BackColor = System.Drawing.Color.Transparent;
            this.RezervasyonBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RezervasyonBtn.FlatAppearance.BorderSize = 2;
            this.RezervasyonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RezervasyonBtn.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RezervasyonBtn.ForeColor = System.Drawing.Color.White;
            this.RezervasyonBtn.Location = new System.Drawing.Point(173, 354);
            this.RezervasyonBtn.Name = "RezervasyonBtn";
            this.RezervasyonBtn.Size = new System.Drawing.Size(144, 63);
            this.RezervasyonBtn.TabIndex = 4;
            this.RezervasyonBtn.Text = "Rezervasyon Al";
            this.RezervasyonBtn.UseVisualStyleBackColor = false;
            this.RezervasyonBtn.Click += new System.EventHandler(this.RezervasyonBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vagon Seçiniz :";
            // 
            // VagonNoComboBox
            // 
            this.VagonNoComboBox.FormattingEnabled = true;
            this.VagonNoComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.VagonNoComboBox.Location = new System.Drawing.Point(173, 223);
            this.VagonNoComboBox.Name = "VagonNoComboBox";
            this.VagonNoComboBox.Size = new System.Drawing.Size(144, 27);
            this.VagonNoComboBox.TabIndex = 2;
            // 
            // KisiSayısıComboBox
            // 
            this.KisiSayısıComboBox.FormattingEnabled = true;
            this.KisiSayısıComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.KisiSayısıComboBox.Location = new System.Drawing.Point(173, 183);
            this.KisiSayısıComboBox.Name = "KisiSayısıComboBox";
            this.KisiSayısıComboBox.Size = new System.Drawing.Size(144, 27);
            this.KisiSayısıComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "farklı vagonlara yerleştirilebilir mi ?";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 132);
            this.panel1.TabIndex = 10;
            // 
            // RezervasyonEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KisiSayısıComboBox);
            this.Controls.Add(this.VagonNoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RezervasyonBtn);
            this.Controls.Add(this.FarklıVagonComboBox);
            this.Controls.Add(this.AdSoyadtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RezervasyonEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervasyonEkranı";
            this.Load += new System.EventHandler(this.RezervasyonEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdSoyadtxt;
        private System.Windows.Forms.ComboBox FarklıVagonComboBox;
        private System.Windows.Forms.Button RezervasyonBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VagonNoComboBox;
        private System.Windows.Forms.ComboBox KisiSayısıComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}