namespace PizzaSiparis
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
            this.Pizzalar = new System.Windows.Forms.Label();
            this.rdbInceKenar = new System.Windows.Forms.RadioButton();
            this.rdbKalinKenar = new System.Windows.Forms.RadioButton();
            this.grpMalzemeler = new System.Windows.Forms.GroupBox();
            this.checkPeynir = new System.Windows.Forms.CheckBox();
            this.checkTonBaligi = new System.Windows.Forms.CheckBox();
            this.checkMantar = new System.Windows.Forms.CheckBox();
            this.checkSucuk = new System.Windows.Forms.CheckBox();
            this.checkSalam = new System.Windows.Forms.CheckBox();
            this.checkZeytin = new System.Windows.Forms.CheckBox();
            this.checkAncuez = new System.Windows.Forms.CheckBox();
            this.checkMisir = new System.Windows.Forms.CheckBox();
            this.checkSosis = new System.Windows.Forms.CheckBox();
            this.checkDanaJambon = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.lstPizzalar = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisiOnayla = new System.Windows.Forms.Button();
            this.grpMalzemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1162, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "PİZZA OTOMASYONU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEbat
            // 
            this.cmbEbat.FormattingEnabled = true;
            this.cmbEbat.Location = new System.Drawing.Point(15, 82);
            this.cmbEbat.Name = "cmbEbat";
            this.cmbEbat.Size = new System.Drawing.Size(306, 24);
            this.cmbEbat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ebat";
            // 
            // Pizzalar
            // 
            this.Pizzalar.AutoSize = true;
            this.Pizzalar.Location = new System.Drawing.Point(12, 135);
            this.Pizzalar.Name = "Pizzalar";
            this.Pizzalar.Size = new System.Drawing.Size(62, 17);
            this.Pizzalar.TabIndex = 3;
            this.Pizzalar.Text = "Pizzalar:";
            // 
            // rdbInceKenar
            // 
            this.rdbInceKenar.AutoSize = true;
            this.rdbInceKenar.Checked = true;
            this.rdbInceKenar.Location = new System.Drawing.Point(15, 282);
            this.rdbInceKenar.Name = "rdbInceKenar";
            this.rdbInceKenar.Size = new System.Drawing.Size(97, 21);
            this.rdbInceKenar.TabIndex = 5;
            this.rdbInceKenar.TabStop = true;
            this.rdbInceKenar.Text = "İnce Kenar";
            this.rdbInceKenar.UseVisualStyleBackColor = true;
            // 
            // rdbKalinKenar
            // 
            this.rdbKalinKenar.AutoSize = true;
            this.rdbKalinKenar.Location = new System.Drawing.Point(144, 282);
            this.rdbKalinKenar.Name = "rdbKalinKenar";
            this.rdbKalinKenar.Size = new System.Drawing.Size(102, 21);
            this.rdbKalinKenar.TabIndex = 6;
            this.rdbKalinKenar.Text = "Kalın Kenar";
            this.rdbKalinKenar.UseVisualStyleBackColor = true;
            // 
            // grpMalzemeler
            // 
            this.grpMalzemeler.Controls.Add(this.checkPeynir);
            this.grpMalzemeler.Controls.Add(this.checkTonBaligi);
            this.grpMalzemeler.Controls.Add(this.checkMantar);
            this.grpMalzemeler.Controls.Add(this.checkSucuk);
            this.grpMalzemeler.Controls.Add(this.checkSalam);
            this.grpMalzemeler.Controls.Add(this.checkZeytin);
            this.grpMalzemeler.Controls.Add(this.checkAncuez);
            this.grpMalzemeler.Controls.Add(this.checkMisir);
            this.grpMalzemeler.Controls.Add(this.checkSosis);
            this.grpMalzemeler.Controls.Add(this.checkDanaJambon);
            this.grpMalzemeler.Location = new System.Drawing.Point(15, 333);
            this.grpMalzemeler.Name = "grpMalzemeler";
            this.grpMalzemeler.Size = new System.Drawing.Size(306, 228);
            this.grpMalzemeler.TabIndex = 7;
            this.grpMalzemeler.TabStop = false;
            this.grpMalzemeler.Text = "Malzemeler";
            // 
            // checkPeynir
            // 
            this.checkPeynir.AutoSize = true;
            this.checkPeynir.Location = new System.Drawing.Point(167, 188);
            this.checkPeynir.Name = "checkPeynir";
            this.checkPeynir.Size = new System.Drawing.Size(70, 21);
            this.checkPeynir.TabIndex = 9;
            this.checkPeynir.Text = "Peynir";
            this.checkPeynir.UseVisualStyleBackColor = true;
            // 
            // checkTonBaligi
            // 
            this.checkTonBaligi.AutoSize = true;
            this.checkTonBaligi.Location = new System.Drawing.Point(167, 146);
            this.checkTonBaligi.Name = "checkTonBaligi";
            this.checkTonBaligi.Size = new System.Drawing.Size(93, 21);
            this.checkTonBaligi.TabIndex = 8;
            this.checkTonBaligi.Text = "Ton Balığı";
            this.checkTonBaligi.UseVisualStyleBackColor = true;
            // 
            // checkMantar
            // 
            this.checkMantar.AutoSize = true;
            this.checkMantar.Location = new System.Drawing.Point(167, 105);
            this.checkMantar.Name = "checkMantar";
            this.checkMantar.Size = new System.Drawing.Size(74, 21);
            this.checkMantar.TabIndex = 7;
            this.checkMantar.Text = "Mantar";
            this.checkMantar.UseVisualStyleBackColor = true;
            // 
            // checkSucuk
            // 
            this.checkSucuk.AutoSize = true;
            this.checkSucuk.Location = new System.Drawing.Point(167, 67);
            this.checkSucuk.Name = "checkSucuk";
            this.checkSucuk.Size = new System.Drawing.Size(69, 21);
            this.checkSucuk.TabIndex = 6;
            this.checkSucuk.Text = "Sucuk";
            this.checkSucuk.UseVisualStyleBackColor = true;
            // 
            // checkSalam
            // 
            this.checkSalam.AutoSize = true;
            this.checkSalam.Location = new System.Drawing.Point(167, 31);
            this.checkSalam.Name = "checkSalam";
            this.checkSalam.Size = new System.Drawing.Size(69, 21);
            this.checkSalam.TabIndex = 5;
            this.checkSalam.Text = "Salam";
            this.checkSalam.UseVisualStyleBackColor = true;
            // 
            // checkZeytin
            // 
            this.checkZeytin.AutoSize = true;
            this.checkZeytin.Location = new System.Drawing.Point(7, 188);
            this.checkZeytin.Name = "checkZeytin";
            this.checkZeytin.Size = new System.Drawing.Size(69, 21);
            this.checkZeytin.TabIndex = 4;
            this.checkZeytin.Text = "Zeytin";
            this.checkZeytin.UseVisualStyleBackColor = true;
            // 
            // checkAncuez
            // 
            this.checkAncuez.AutoSize = true;
            this.checkAncuez.Location = new System.Drawing.Point(7, 146);
            this.checkAncuez.Name = "checkAncuez";
            this.checkAncuez.Size = new System.Drawing.Size(77, 21);
            this.checkAncuez.TabIndex = 3;
            this.checkAncuez.Text = "Ançuez";
            this.checkAncuez.UseVisualStyleBackColor = true;
            // 
            // checkMisir
            // 
            this.checkMisir.AutoSize = true;
            this.checkMisir.Location = new System.Drawing.Point(7, 105);
            this.checkMisir.Name = "checkMisir";
            this.checkMisir.Size = new System.Drawing.Size(59, 21);
            this.checkMisir.TabIndex = 2;
            this.checkMisir.Text = "Mısır";
            this.checkMisir.UseVisualStyleBackColor = true;
            // 
            // checkSosis
            // 
            this.checkSosis.AutoSize = true;
            this.checkSosis.Location = new System.Drawing.Point(7, 67);
            this.checkSosis.Name = "checkSosis";
            this.checkSosis.Size = new System.Drawing.Size(64, 21);
            this.checkSosis.TabIndex = 1;
            this.checkSosis.Text = "Sosis";
            this.checkSosis.UseVisualStyleBackColor = true;
            // 
            // checkDanaJambon
            // 
            this.checkDanaJambon.AutoSize = true;
            this.checkDanaJambon.Location = new System.Drawing.Point(7, 31);
            this.checkDanaJambon.Name = "checkDanaJambon";
            this.checkDanaJambon.Size = new System.Drawing.Size(118, 21);
            this.checkDanaJambon.TabIndex = 0;
            this.checkDanaJambon.Text = "Dana Jambon";
            this.checkDanaJambon.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adet:";
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(71, 587);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(120, 22);
            this.numAdet.TabIndex = 9;
            this.numAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(447, 584);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(154, 22);
            this.txtTutar.TabIndex = 12;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.HorizontalScrollbar = true;
            this.lstSepet.ItemHeight = 16;
            this.lstSepet.Location = new System.Drawing.Point(400, 82);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(622, 468);
            this.lstSepet.TabIndex = 13;
            // 
            // lstPizzalar
            // 
            this.lstPizzalar.FormattingEnabled = true;
            this.lstPizzalar.ItemHeight = 16;
            this.lstPizzalar.Location = new System.Drawing.Point(15, 155);
            this.lstPizzalar.Name = "lstPizzalar";
            this.lstPizzalar.Size = new System.Drawing.Size(306, 100);
            this.lstPizzalar.TabIndex = 14;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(212, 587);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(109, 23);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(616, 583);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(109, 23);
            this.btnSepeteEkle.TabIndex = 15;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(808, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Toplam Tutar:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(928, 564);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 17);
            this.lblToplamTutar.TabIndex = 17;
            // 
            // btnSiparisiOnayla
            // 
            this.btnSiparisiOnayla.Location = new System.Drawing.Point(888, 604);
            this.btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            this.btnSiparisiOnayla.Size = new System.Drawing.Size(134, 23);
            this.btnSiparisiOnayla.TabIndex = 18;
            this.btnSiparisiOnayla.Text = "Siparişi Onayla";
            this.btnSiparisiOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisiOnayla.Click += new System.EventHandler(this.btnSiparisiOnayla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 707);
            this.Controls.Add(this.btnSiparisiOnayla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lstPizzalar);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpMalzemeler);
            this.Controls.Add(this.rdbKalinKenar);
            this.Controls.Add(this.rdbInceKenar);
            this.Controls.Add(this.Pizzalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEbat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMalzemeler.ResumeLayout(false);
            this.grpMalzemeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEbat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Pizzalar;
        private System.Windows.Forms.RadioButton rdbInceKenar;
        private System.Windows.Forms.RadioButton rdbKalinKenar;
        private System.Windows.Forms.GroupBox grpMalzemeler;
        private System.Windows.Forms.CheckBox checkPeynir;
        private System.Windows.Forms.CheckBox checkTonBaligi;
        private System.Windows.Forms.CheckBox checkMantar;
        private System.Windows.Forms.CheckBox checkSucuk;
        private System.Windows.Forms.CheckBox checkSalam;
        private System.Windows.Forms.CheckBox checkZeytin;
        private System.Windows.Forms.CheckBox checkAncuez;
        private System.Windows.Forms.CheckBox checkMisir;
        private System.Windows.Forms.CheckBox checkSosis;
        private System.Windows.Forms.CheckBox checkDanaJambon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.ListBox lstPizzalar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisiOnayla;
    }
}

