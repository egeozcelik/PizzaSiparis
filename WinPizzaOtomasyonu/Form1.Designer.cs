namespace WinPizzaOtomasyonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEbat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPizza = new System.Windows.Forms.ListBox();
            this.rdInce = new System.Windows.Forms.RadioButton();
            this.rdKalin = new System.Windows.Forms.RadioButton();
            this.chclstMalzeme = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSepet = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSepetOnay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ebatlar : ";
            // 
            // cmbEbat
            // 
            this.cmbEbat.FormattingEnabled = true;
            this.cmbEbat.Location = new System.Drawing.Point(68, 10);
            this.cmbEbat.Name = "cmbEbat";
            this.cmbEbat.Size = new System.Drawing.Size(197, 21);
            this.cmbEbat.TabIndex = 1;
            this.cmbEbat.SelectionChangeCommitted += new System.EventHandler(this.cmbEbat_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pizzalar :";
            // 
            // lstPizza
            // 
            this.lstPizza.FormattingEnabled = true;
            this.lstPizza.Location = new System.Drawing.Point(68, 37);
            this.lstPizza.Name = "lstPizza";
            this.lstPizza.Size = new System.Drawing.Size(197, 134);
            this.lstPizza.TabIndex = 3;
            this.lstPizza.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPizza_MouseDoubleClick);
            // 
            // rdInce
            // 
            this.rdInce.AutoSize = true;
            this.rdInce.Location = new System.Drawing.Point(68, 177);
            this.rdInce.Name = "rdInce";
            this.rdInce.Size = new System.Drawing.Size(77, 17);
            this.rdInce.TabIndex = 4;
            this.rdInce.Text = "İnce Kenar";
            this.rdInce.UseVisualStyleBackColor = true;
            this.rdInce.CheckedChanged += new System.EventHandler(this.rdInce_CheckedChanged);
            // 
            // rdKalin
            // 
            this.rdKalin.AutoSize = true;
            this.rdKalin.Checked = true;
            this.rdKalin.Location = new System.Drawing.Point(159, 177);
            this.rdKalin.Name = "rdKalin";
            this.rdKalin.Size = new System.Drawing.Size(79, 17);
            this.rdKalin.TabIndex = 4;
            this.rdKalin.TabStop = true;
            this.rdKalin.Text = "Kalın Kenar";
            this.rdKalin.UseVisualStyleBackColor = true;
            this.rdKalin.CheckedChanged += new System.EventHandler(this.rdKalin_CheckedChanged);
            // 
            // chclstMalzeme
            // 
            this.chclstMalzeme.FormattingEnabled = true;
            this.chclstMalzeme.Location = new System.Drawing.Point(15, 19);
            this.chclstMalzeme.Name = "chclstMalzeme";
            this.chclstMalzeme.Size = new System.Drawing.Size(170, 154);
            this.chclstMalzeme.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chclstMalzeme);
            this.groupBox1.Location = new System.Drawing.Point(68, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 189);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tutar";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(49, 399);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(84, 20);
            this.txtAdet.TabIndex = 9;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(284, 402);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(84, 20);
            this.txtTutar.TabIndex = 11;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(139, 399);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(101, 23);
            this.btnHesapla.TabIndex = 12;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adet";
            // 
            // btnSepet
            // 
            this.btnSepet.Location = new System.Drawing.Point(374, 400);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(75, 23);
            this.btnSepet.TabIndex = 14;
            this.btnSepet.Text = "Sepete Ekle";
            this.btnSepet.UseVisualStyleBackColor = true;
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(284, 10);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.ScrollAlwaysVisible = true;
            this.lstSepet.Size = new System.Drawing.Size(615, 329);
            this.lstSepet.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Toplam Tutar : ";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(698, 360);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(22, 13);
            this.lblToplamTutar.TabIndex = 8;
            this.lblToplamTutar.Text = "-----";
            // 
            // btnSepetOnay
            // 
            this.btnSepetOnay.Location = new System.Drawing.Point(581, 399);
            this.btnSepetOnay.Name = "btnSepetOnay";
            this.btnSepetOnay.Size = new System.Drawing.Size(176, 23);
            this.btnSepetOnay.TabIndex = 16;
            this.btnSepetOnay.Text = "Siparişi Onayla";
            this.btnSepetOnay.UseVisualStyleBackColor = true;
            this.btnSepetOnay.Click += new System.EventHandler(this.btnSepetOnay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 439);
            this.Controls.Add(this.btnSepetOnay);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnSepet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdKalin);
            this.Controls.Add(this.rdInce);
            this.Controls.Add(this.lstPizza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEbat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tutar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEbat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPizza;
        private System.Windows.Forms.RadioButton rdInce;
        private System.Windows.Forms.RadioButton rdKalin;
        private System.Windows.Forms.CheckedListBox chclstMalzeme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSepetOnay;
    }
}

