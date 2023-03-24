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
    public partial class frmYolculuklarim : Form
    {
        public frmYolculuklarim()
        {
            InitializeComponent();
        }
        private void frmYolculuklarim_Load(object sender, EventArgs e)
        {
            YolculuklariGoster();
            KazancGoster();
        }
        private void KazancGoster()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=L2PC11;Initial Catalog = BlaCar; Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Uyeler Where UyeID = " + BlaCar.UyeID + "",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            lblKazanc.Text = dr["KazanilanPara"].ToString();
            baglanti.Close();
        }
        private void YolculuklariGoster()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=L2PC11;Initial Catalog = BlaCar; Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Ilanlar where UyeID = '" + BlaCar.UyeID + "'",baglanti);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = komut;
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
