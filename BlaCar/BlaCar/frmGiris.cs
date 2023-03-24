using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlaCar
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            BlaCar blacar = new BlaCar();
            blacar.KullaniciAdi = txtKullaniciAdi.Text;
            blacar.Sifre = txtSifre.Text;
            blacar.GirisYap();
            Temizle();
        }
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            BlaCar blacar = new BlaCar();
            blacar.KullaniciAdi = txtKullaniciAdi2.Text;
            blacar.Sifre = txtSifre2.Text;
            blacar.Ad = txtAd.Text;
            blacar.Soyad = txtSoyad.Text;
            blacar.UyeOl();
            Temizle();
        }
        private void Temizle()
        {
            txtKullaniciAdi2.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtSifre2.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
        }
        private void iTalk_TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
