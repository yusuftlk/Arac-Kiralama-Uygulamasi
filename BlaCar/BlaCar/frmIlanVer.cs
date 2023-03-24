using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BlaCar
{
    public partial class frmIlanVer : Form
    {
        public frmIlanVer()
        {
            InitializeComponent();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BlaCar blacar = new BlaCar();
            blacar.Arac = cmbAraclar.SelectedItem.ToString();
            blacar.BaglangicIli = cmbBaslangicIli.SelectedItem.ToString();
            blacar.BitisIli = cmbBitisIli.SelectedItem.ToString();
            blacar.Tarih = dtpTarih.Text;
            blacar.Ucret = txtUcret.Text;
            blacar.IlanVer();
        }
        private void frmIlanVer_Load(object sender, EventArgs e)
        {
            IlleriDoldur();
        }
        private void IlleriDoldur()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=L2PC11;Initial Catalog = BlaCar; Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Iller", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBaslangicIli.Items.Add(dr["IlAdi"].ToString());
                cmbBitisIli.Items.Add(dr["IlAdi"].ToString());
            }
            baglanti.Close();
        }
    }
}
