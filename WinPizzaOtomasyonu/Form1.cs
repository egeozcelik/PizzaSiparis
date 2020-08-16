using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinPizzaOtomasyonu.Model;

namespace WinPizzaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ebat ebat = new Ebat();
        Pizza pizza = new Pizza();
        Malzeme malzeme = new Malzeme();
        Sepet sepet = new Sepet();

        List<Sepet> sepetListesi = new List<Sepet>();
        private void Form1_Load(object sender, EventArgs e)
        {
            EbatDoldur();
            PizzaDoldur();
            MalzemeDoldur();
        }

        private void MalzemeDoldur()
        {
            ListBox chcList = chclstMalzeme;
            chcList.DataSource = malzeme.getirMalzeme();
            chcList.DisplayMember = "Adi";
            chcList.ValueMember = "Id";
        }

        private void PizzaDoldur()
        {

            lstPizza.DataSource = pizza.getirPizza();
            lstPizza.ValueMember = "Id";
            lstPizza.DisplayMember = "Adi";
        }

        private void EbatDoldur()
        {

            cmbEbat.DataSource = ebat.ebatGetir();
            cmbEbat.ValueMember = "Id";
            cmbEbat.DisplayMember = "Adi";
            cmbEbat.Text = "Seçiniz";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            SecilenMalzemeler();
            if (sepet.Ebat == null || sepet.Malzemeler.Count == 0 ||
                sepet.Pizza == null || txtAdet.Text == string.Empty)
            {
                MessageBox.Show("Tüm alanları Seçiniz");
                return;
            }
            int adet = Convert.ToInt32(txtAdet.Text);
            sepet.Adet = adet;
            int kalinlikFarli = 0;
            if (sepet.HamurTipi == HamurTipi.Kalın)
            {
                kalinlikFarli = 2;
            }
            double hesapTutar = (adet * sepet.Pizza.Fiyat * sepet.Ebat.Carpan)
                                                        + (adet * kalinlikFarli);

            sepet.Tutar = hesapTutar;
            txtTutar.Text = hesapTutar.ToString();
        }

        private void SecilenMalzemeler()
        {
            foreach (Malzeme item in chclstMalzeme.CheckedItems)
            {
                sepet.Malzemeler.Add(item);
            }
        }

        private void cmbEbat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int value = (int)cmbEbat.SelectedValue;
            sepet.Ebat = ebat.ebatGetir().FirstOrDefault(z => z.Id == value);
        }

        private void lstPizza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int value = (int)lstPizza.SelectedValue;
            sepet.Pizza = pizza.getirPizza().FirstOrDefault(z => z.Id == value);
            MessageBox.Show("Pizzayı Seçtiniz : " + sepet.Pizza.Adi);
        }

        private void rdInce_CheckedChanged(object sender, EventArgs e)
        {
            sepet.HamurTipi = HamurTipi.Ince;
        }

        private void rdKalin_CheckedChanged(object sender, EventArgs e)
        {
            sepet.HamurTipi = HamurTipi.Kalın;
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            sepetListesi.Add(sepet);
            SepetListesiniTekrarDoldur();
        }

        private void SepetListesiniTekrarDoldur()
        {
            lstSepet.Items.Clear();
            double toplamTutar = 0;
            foreach (Sepet item in sepetListesi)
            {
                string hamurTipi = "Ince Hamur";
                if (item.HamurTipi == HamurTipi.Kalın) hamurTipi = "Kalın Hamur";
                string malzeme = "";
                foreach (Malzeme malzemeEach in item.Malzemeler)
                {
                    malzeme += malzemeEach.Adi + ",";
                }
                string eklenecek = string.Format("{0} , {1} , {2} , {3} : {4} x {5} x {7} = {6} TL",
                    item.Ebat.Adi,
                    item.Pizza.Adi,
                    hamurTipi,
                    malzeme,
                    item.Adet,
                    item.Pizza.Fiyat,
                    item.Tutar,
                    item.Ebat.Carpan
               );
                toplamTutar += item.Tutar;
                lstSepet.Items.Add(eklenecek);
            }
            lblToplamTutar.Text = toplamTutar.ToString();
            sepet = new Sepet();
            sepet.Malzemeler = new List<Malzeme>();
        }

        private void btnSepetOnay_Click(object sender, EventArgs e)
        {
            double toplamTutar = sepetListesi.Sum(z => z.Tutar);
            string mesaj = string.Format("Toplam {0} Adet Siparişiniz {1} Tl Tutarındadır",
                sepetListesi.Count, toplamTutar);
            MessageBox.Show(mesaj);
        }
    }
}
