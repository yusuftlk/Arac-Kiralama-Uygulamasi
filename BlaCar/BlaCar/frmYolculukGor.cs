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
    public partial class frmYolculukGor : Form
    {
        public frmYolculukGor()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnYolculugaKatil.Enabled = true;
        }
        private void frmYolculukGor_Load(object sender, EventArgs e)
        {
            IlleriDoldur();
            DataDoldur();
        }
        private void DataDoldur()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=L2PC11;Initial Catalog = BlaCar; Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Ilanlar",baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = komut;
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void IlleriDoldur()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=L2PC11;Initial Catalog = BlaCar; Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Iller",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBaslangic.Items.Add(dr["IlAdi"].ToString());
                cmbBitis.Items.Add(dr["IlAdi"].ToString());
            }
            baglanti.Close();
        }
        private void btnYolculugaKatil_Click(object sender, EventArgs e)
        {
            BlaCar blacar = new BlaCar();
            int ucret = int.Parse(dataGridView1.CurrentRow.Cells["Ucret"].Value.ToString());
            BlaCar.ID = dataGridView1.CurrentRow.Cells["UyeID"].Value.ToString();
            blacar.KazancBul();
            blacar.YolculugaKatil(ucret);
        }
        private void cmbBaslangic_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenDataDoldur();
        }
        private void SecilenDataDoldur()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=L2PC11;Initial Catalog = BlaCar; Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Ilanlar where BaslangicIli = '" + cmbBaslangic.SelectedItem.ToString() + "' and BitisIli = '" + cmbBitis.SelectedItem.ToString() + "' and Tarih = '" + dtpTarih.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = komut;
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
