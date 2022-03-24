using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MusteriSiparisHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex--;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                btnOnceki.Enabled = false;
            else btnOnceki.Enabled = true;
            //btn sonraki altta**********
            if (tabControl1.SelectedIndex == tabControl1.TabPages.Count - 1)
                btnSonraki.Enabled = false;
            else btnSonraki.Enabled = true;

            if (tabControl1.SelectedIndex == 2)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi.Text += txtTel.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;

                if (nCorba.Value > 0)
                {
                    hesap += nCorba.Value*12;
                    txtBilgi.Text += string.Format("Çorba {0:C}", nCorba.Value*12) + "\r\n";
                }
                if (nSalata.Value > 0)
                {
                    hesap += nSalata.Value * 10;
                    txtBilgi.Text += string.Format("Salata {0:C}", nSalata.Value * 10) + "\r\n";
                }
                if (nYemek.Value > 0)
                {
                    hesap += nYemek.Value * 20;
                    txtBilgi.Text += string.Format("Ana Yemek {0:C}", nYemek.Value * 20) + "\r\n";
                }
                if (nTatli.Value > 0)
                {
                    hesap += nTatli.Value * 15;
                    txtBilgi.Text += string.Format("Tatlı {0:C}", nTatli.Value * 15) + "\r\n";
                }
                txtBilgi.Text += "-----------------";
                txtBilgi.Text += string.Format("Toplam {0:C}", hesap);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string satir = txtAdSoyad.Text + ";" + txtTel.Text + ";" + txtAdres.Text + ";";

            File.WriteAllLines(txtTel.Text + ".data", new string[] {satir});

            MessageBox.Show("Veriler kaydedildi!");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtTel.Text + ".data"))
            {
                string[] satirlar = File.ReadAllLines(txtTel.Text + ".data");

                string musteriBilgileri = satirlar[0];

                string[] data = musteriBilgileri.Split(';');

                txtAdSoyad.Text = data[0];
                txtTel.Text = data[1];
                txtAdres.Text = data[2];
            }
            else
                MessageBox.Show("Müşteri bulunamadı!");
        }
    }
}
