namespace MusteriSiparisHesaplama
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMusteri = new System.Windows.Forms.TabPage();
            this.tpSiparis = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpHesap = new System.Windows.Forms.TabPage();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.nCorba = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nSalata = new System.Windows.Forms.NumericUpDown();
            this.nYemek = new System.Windows.Forms.NumericUpDown();
            this.nTatli = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tpMusteri.SuspendLayout();
            this.tpSiparis.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpHesap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTatli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMusteri);
            this.tabControl1.Controls.Add(this.tpSiparis);
            this.tabControl1.Controls.Add(this.tpHesap);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 206);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpMusteri
            // 
            this.tpMusteri.Controls.Add(this.btnGetir);
            this.tpMusteri.Controls.Add(this.txtAdres);
            this.tpMusteri.Controls.Add(this.label3);
            this.tpMusteri.Controls.Add(this.txtTel);
            this.tpMusteri.Controls.Add(this.label2);
            this.tpMusteri.Controls.Add(this.txtAdSoyad);
            this.tpMusteri.Controls.Add(this.label1);
            this.tpMusteri.Location = new System.Drawing.Point(4, 22);
            this.tpMusteri.Name = "tpMusteri";
            this.tpMusteri.Padding = new System.Windows.Forms.Padding(3);
            this.tpMusteri.Size = new System.Drawing.Size(387, 180);
            this.tpMusteri.TabIndex = 0;
            this.tpMusteri.Text = "Müşteri";
            this.tpMusteri.UseVisualStyleBackColor = true;
            // 
            // tpSiparis
            // 
            this.tpSiparis.Controls.Add(this.nTatli);
            this.tpSiparis.Controls.Add(this.nYemek);
            this.tpSiparis.Controls.Add(this.nSalata);
            this.tpSiparis.Controls.Add(this.label7);
            this.tpSiparis.Controls.Add(this.label6);
            this.tpSiparis.Controls.Add(this.label5);
            this.tpSiparis.Controls.Add(this.label4);
            this.tpSiparis.Controls.Add(this.nCorba);
            this.tpSiparis.Location = new System.Drawing.Point(4, 22);
            this.tpSiparis.Name = "tpSiparis";
            this.tpSiparis.Padding = new System.Windows.Forms.Padding(3);
            this.tpSiparis.Size = new System.Drawing.Size(387, 180);
            this.tpSiparis.TabIndex = 1;
            this.tpSiparis.Text = "Sipariş";
            this.tpSiparis.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnOnceki);
            this.panel1.Controls.Add(this.btnSonraki);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 34);
            this.panel1.TabIndex = 0;
            // 
            // tpHesap
            // 
            this.tpHesap.Controls.Add(this.txtBilgi);
            this.tpHesap.Location = new System.Drawing.Point(4, 22);
            this.tpHesap.Name = "tpHesap";
            this.tpHesap.Padding = new System.Windows.Forms.Padding(3);
            this.tpHesap.Size = new System.Drawing.Size(387, 180);
            this.tpHesap.TabIndex = 2;
            this.tpHesap.Text = "Hesap";
            this.tpHesap.UseVisualStyleBackColor = true;
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(293, 6);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(92, 23);
            this.btnSonraki.TabIndex = 0;
            this.btnSonraki.Text = "Sonraki Sayfa";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnOnceki
            // 
            this.btnOnceki.Location = new System.Drawing.Point(195, 6);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(92, 23);
            this.btnOnceki.TabIndex = 1;
            this.btnOnceki.Text = "Önceki Sayfa";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(4, 6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(101, 15);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(136, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(101, 46);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(136, 20);
            this.txtTel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(74, 76);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(163, 81);
            this.txtAdres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres:";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(243, 44);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 1;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // txtBilgi
            // 
            this.txtBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBilgi.Location = new System.Drawing.Point(3, 3);
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(381, 174);
            this.txtBilgi.TabIndex = 0;
            // 
            // nCorba
            // 
            this.nCorba.Location = new System.Drawing.Point(151, 37);
            this.nCorba.Name = "nCorba";
            this.nCorba.Size = new System.Drawing.Size(120, 20);
            this.nCorba.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(93, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Çorba";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(93, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Salata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(56, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ana Yemek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(104, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tatlı";
            // 
            // nSalata
            // 
            this.nSalata.Location = new System.Drawing.Point(151, 66);
            this.nSalata.Name = "nSalata";
            this.nSalata.Size = new System.Drawing.Size(120, 20);
            this.nSalata.TabIndex = 5;
            // 
            // nYemek
            // 
            this.nYemek.Location = new System.Drawing.Point(151, 89);
            this.nYemek.Name = "nYemek";
            this.nYemek.Size = new System.Drawing.Size(120, 20);
            this.nYemek.TabIndex = 6;
            // 
            // nTatli
            // 
            this.nTatli.Location = new System.Drawing.Point(151, 115);
            this.nTatli.Name = "nTatli";
            this.nTatli.Size = new System.Drawing.Size(120, 20);
            this.nTatli.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 239);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Müşteri Sipariş Hesaplama";
            this.tabControl1.ResumeLayout(false);
            this.tpMusteri.ResumeLayout(false);
            this.tpMusteri.PerformLayout();
            this.tpSiparis.ResumeLayout(false);
            this.tpSiparis.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tpHesap.ResumeLayout(false);
            this.tpHesap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTatli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMusteri;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpSiparis;
        private System.Windows.Forms.TabPage tpHesap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnOnceki;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nCorba;
        private System.Windows.Forms.NumericUpDown nTatli;
        private System.Windows.Forms.NumericUpDown nYemek;
        private System.Windows.Forms.NumericUpDown nSalata;
    }
}

