namespace _4_Bantlı_Direnç_Hesaplama
{
    partial class Form1
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
            this.lblRnk1 = new System.Windows.Forms.Label();
            this.lblRnk2 = new System.Windows.Forms.Label();
            this.lblÇarpan = new System.Windows.Forms.Label();
            this.lblTolerans = new System.Windows.Forms.Label();
            this.cmbBoxRenk1 = new System.Windows.Forms.ComboBox();
            this.cmbBoxRenk2 = new System.Windows.Forms.ComboBox();
            this.cmbBoxCarpan = new System.Windows.Forms.ComboBox();
            this.cmbBoxTolerans = new System.Windows.Forms.ComboBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.txtTolerans = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtRnk1 = new System.Windows.Forms.TextBox();
            this.txtRnk2 = new System.Windows.Forms.TextBox();
            this.txtCrpnRnk = new System.Windows.Forms.TextBox();
            this.txtToleransRnk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRnk1
            // 
            this.lblRnk1.AutoSize = true;
            this.lblRnk1.Location = new System.Drawing.Point(31, 38);
            this.lblRnk1.Name = "lblRnk1";
            this.lblRnk1.Size = new System.Drawing.Size(49, 16);
            this.lblRnk1.TabIndex = 0;
            this.lblRnk1.Text = "Renk 1";
            // 
            // lblRnk2
            // 
            this.lblRnk2.AutoSize = true;
            this.lblRnk2.Location = new System.Drawing.Point(181, 38);
            this.lblRnk2.Name = "lblRnk2";
            this.lblRnk2.Size = new System.Drawing.Size(49, 16);
            this.lblRnk2.TabIndex = 0;
            this.lblRnk2.Text = "Renk 2";
            // 
            // lblÇarpan
            // 
            this.lblÇarpan.AutoSize = true;
            this.lblÇarpan.Location = new System.Drawing.Point(331, 38);
            this.lblÇarpan.Name = "lblÇarpan";
            this.lblÇarpan.Size = new System.Drawing.Size(51, 16);
            this.lblÇarpan.TabIndex = 0;
            this.lblÇarpan.Text = "Çarpan";
            // 
            // lblTolerans
            // 
            this.lblTolerans.AutoSize = true;
            this.lblTolerans.Location = new System.Drawing.Point(481, 38);
            this.lblTolerans.Name = "lblTolerans";
            this.lblTolerans.Size = new System.Drawing.Size(61, 16);
            this.lblTolerans.TabIndex = 0;
            this.lblTolerans.Text = "Tolerans";
            // 
            // cmbBoxRenk1
            // 
            this.cmbBoxRenk1.FormattingEnabled = true;
            this.cmbBoxRenk1.Items.AddRange(new object[] {
            "Siyah",
            "Kahverengi",
            "Kırmızı",
            "Turuncu",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Gri",
            "Beyaz"});
            this.cmbBoxRenk1.Location = new System.Drawing.Point(12, 75);
            this.cmbBoxRenk1.Name = "cmbBoxRenk1";
            this.cmbBoxRenk1.Size = new System.Drawing.Size(68, 24);
            this.cmbBoxRenk1.TabIndex = 2;
            this.cmbBoxRenk1.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRenk1_SelectedIndexChanged);
            // 
            // cmbBoxRenk2
            // 
            this.cmbBoxRenk2.FormattingEnabled = true;
            this.cmbBoxRenk2.Items.AddRange(new object[] {
            "Siyah",
            "Kahverengi",
            "Kırmızı",
            "Turuncu",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Gri",
            "Beyaz"});
            this.cmbBoxRenk2.Location = new System.Drawing.Point(162, 75);
            this.cmbBoxRenk2.Name = "cmbBoxRenk2";
            this.cmbBoxRenk2.Size = new System.Drawing.Size(68, 24);
            this.cmbBoxRenk2.TabIndex = 2;
            this.cmbBoxRenk2.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRenk2_SelectedIndexChanged);
            // 
            // cmbBoxCarpan
            // 
            this.cmbBoxCarpan.FormattingEnabled = true;
            this.cmbBoxCarpan.Items.AddRange(new object[] {
            "Siyah",
            "Kahverengi",
            "Kırmızı",
            "Turuncu",
            "Sarı",
            "Yeşil",
            "Mavi",
            "Mor",
            "Gri",
            "Beyaz"});
            this.cmbBoxCarpan.Location = new System.Drawing.Point(314, 75);
            this.cmbBoxCarpan.Name = "cmbBoxCarpan";
            this.cmbBoxCarpan.Size = new System.Drawing.Size(68, 24);
            this.cmbBoxCarpan.TabIndex = 2;
            this.cmbBoxCarpan.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCarpan_SelectedIndexChanged);
            // 
            // cmbBoxTolerans
            // 
            this.cmbBoxTolerans.FormattingEnabled = true;
            this.cmbBoxTolerans.Items.AddRange(new object[] {
            "Gold",
            "Silver"});
            this.cmbBoxTolerans.Location = new System.Drawing.Point(474, 75);
            this.cmbBoxTolerans.Name = "cmbBoxTolerans";
            this.cmbBoxTolerans.Size = new System.Drawing.Size(68, 24);
            this.cmbBoxTolerans.TabIndex = 2;
            this.cmbBoxTolerans.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTolerans_SelectedIndexChanged);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(616, 38);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(309, 61);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Direnç Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(616, 147);
            this.txtDeger.Multiline = true;
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.ReadOnly = true;
            this.txtDeger.Size = new System.Drawing.Size(100, 49);
            this.txtDeger.TabIndex = 4;
            // 
            // txtTolerans
            // 
            this.txtTolerans.Location = new System.Drawing.Point(825, 147);
            this.txtTolerans.Multiline = true;
            this.txtTolerans.Name = "txtTolerans";
            this.txtTolerans.ReadOnly = true;
            this.txtTolerans.Size = new System.Drawing.Size(100, 49);
            this.txtTolerans.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 13);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 13);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(159, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(263, 98);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txtRnk1
            // 
            this.txtRnk1.Location = new System.Drawing.Point(159, 203);
            this.txtRnk1.Multiline = true;
            this.txtRnk1.Name = "txtRnk1";
            this.txtRnk1.ReadOnly = true;
            this.txtRnk1.Size = new System.Drawing.Size(50, 98);
            this.txtRnk1.TabIndex = 6;
            // 
            // txtRnk2
            // 
            this.txtRnk2.Location = new System.Drawing.Point(230, 203);
            this.txtRnk2.Multiline = true;
            this.txtRnk2.Name = "txtRnk2";
            this.txtRnk2.ReadOnly = true;
            this.txtRnk2.Size = new System.Drawing.Size(50, 98);
            this.txtRnk2.TabIndex = 6;
            // 
            // txtCrpnRnk
            // 
            this.txtCrpnRnk.Location = new System.Drawing.Point(301, 203);
            this.txtCrpnRnk.Multiline = true;
            this.txtCrpnRnk.Name = "txtCrpnRnk";
            this.txtCrpnRnk.ReadOnly = true;
            this.txtCrpnRnk.Size = new System.Drawing.Size(50, 98);
            this.txtCrpnRnk.TabIndex = 6;
            // 
            // txtToleransRnk
            // 
            this.txtToleransRnk.Location = new System.Drawing.Point(372, 203);
            this.txtToleransRnk.Multiline = true;
            this.txtToleransRnk.Name = "txtToleransRnk";
            this.txtToleransRnk.ReadOnly = true;
            this.txtToleransRnk.Size = new System.Drawing.Size(50, 98);
            this.txtToleransRnk.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 345);
            this.Controls.Add(this.txtToleransRnk);
            this.Controls.Add(this.txtRnk2);
            this.Controls.Add(this.txtCrpnRnk);
            this.Controls.Add(this.txtRnk1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTolerans);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.cmbBoxTolerans);
            this.Controls.Add(this.cmbBoxCarpan);
            this.Controls.Add(this.cmbBoxRenk2);
            this.Controls.Add(this.cmbBoxRenk1);
            this.Controls.Add(this.lblTolerans);
            this.Controls.Add(this.lblÇarpan);
            this.Controls.Add(this.lblRnk2);
            this.Controls.Add(this.lblRnk1);
            this.Name = "Form1";
            this.Text = "4 Bantlı Direnç Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRnk1;
        private System.Windows.Forms.Label lblRnk2;
        private System.Windows.Forms.Label lblÇarpan;
        private System.Windows.Forms.Label lblTolerans;
        private System.Windows.Forms.ComboBox cmbBoxRenk1;
        private System.Windows.Forms.ComboBox cmbBoxRenk2;
        private System.Windows.Forms.ComboBox cmbBoxCarpan;
        private System.Windows.Forms.ComboBox cmbBoxTolerans;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.TextBox txtTolerans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtRnk1;
        private System.Windows.Forms.TextBox txtRnk2;
        private System.Windows.Forms.TextBox txtCrpnRnk;
        private System.Windows.Forms.TextBox txtToleransRnk;
    }
}

