using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Siparis s;
        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat { Adi = "Küçük", Carpan = 1 };
            Ebat orta = new Ebat { Adi = "Orta", Carpan = 1.25 };
            Ebat buyuk = new Ebat { Adi = "Büyük", Carpan = 1.75 };
            Ebat maxi = new Ebat { Adi = "Maxi", Carpan = 2 };
            cmbEbat.Items.Add(kucuk);
            cmbEbat.Items.Add(orta);
            cmbEbat.Items.Add(buyuk);
            cmbEbat.Items.Add(maxi);

            Pizza klasik = new Pizza { Adi = "Klasik", Fiyat = 15 };
            Pizza karisik = new Pizza { Adi = "Karışık", Fiyat = 17 };
            Pizza turkish = new Pizza { Adi = "Turkish", Fiyat = 20 };
            Pizza tuna = new Pizza {Adi="Tuna",Fiyat=21 };
            Pizza akdeniz = new Pizza { Adi = "Akdeniz", Fiyat = 19 };
            Pizza karadeniz = new Pizza { Adi = "Karadeniz", Fiyat = 22 };
            lstPizzalar.Items.Add(klasik);
            lstPizzalar.Items.Add(karisik);
            lstPizzalar.Items.Add(turkish);
            lstPizzalar.Items.Add(tuna);
            lstPizzalar.Items.Add(akdeniz);
            lstPizzalar.Items.Add(karadeniz);

            KenarTip ince = new KenarTip {Adi="İnce Kenar Kenar", EkFiyat=0 };
            rdbInceKenar.Tag = ince;
            KenarTip kalın = new KenarTip { Adi = "Kalın Kenar", EkFiyat = 2 };
            rdbKalinKenar.Tag = kalın;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Pizza p = (Pizza)lstPizzalar.SelectedItem;
            p.Ebati = (Ebat)cmbEbat.SelectedItem;
            if (rdbInceKenar.Checked)
            {
                p.KenarTipi = (KenarTip)rdbInceKenar.Tag;
            }
            else if (rdbKalinKenar.Checked)
            {
                p.KenarTipi = (KenarTip)rdbKalinKenar.Tag;
            }
            p.Malzemeler = new List<string>();
                foreach (CheckBox item in grpMalzemeler.Controls)
                {
                    if (item.Checked)
                    {
                        p.Malzemeler.Add(item.Text);
                    }
                }
                decimal tutar = numAdet.Value * p.Tutar;
                txtTutar.Text = tutar.ToString();
            s = new Siparis();
            s.Pizza = p;
            s.Adet = (int)numAdet.Value;
            }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (s!=null)
            {
                lstSepet.Items.Add(s);
            }
            
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 0;
            int adet = 0;
            foreach (Siparis item in lstSepet.Items)
            {
                toplamTutar += item.Adet * item.Pizza.Tutar;
                adet++;
            }
            lblToplamTutar.Text = toplamTutar.ToString();


            DialogResult dr=MessageBox.Show(string.Format("Toplam sipariş adediniz: {0} \nToplam sipariş tutarınız: {1} \nOnaylıyor musunuz?", adet, toplamTutar), "Sipariş Bilgileri",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {              
                MessageBox.Show("Sipariş Tamamlandı");
                KontrolTemizle.TemizlemeMakinesi(this.Controls);
            }
            else
            {
                MessageBox.Show("Ödeme İşlemi İptal Edilmiştir. Siparişinizi baştan oluşturun.");
                KontrolTemizle.TemizlemeMakinesi(this.Controls);
            }
        }
    }
    }

