using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BlaCar
{
    class BlaCar
    {
        SqlConnection baglanti;
        public static string UyeID;
        public static string ID;
        bool KulAdVarMi = false;
        int Kazanc;
        public BlaCar()
        {
            baglanti = new SqlConnection("Data Source=L2PC11;Initial Catalog = BlaCar; Integrated Security=True");
            baglanti.Open();
        }
        string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        string soyad;
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        string sifre;
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        string arac;
        public string Arac
        {
            get { return arac; }
            set { arac = value; }
        }
        string marka;
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        string baglangicIli;
        public string BaglangicIli
        {
            get { return baglangicIli; }
            set { baglangicIli = value; }
        }

        string bitisIli;
        public string BitisIli
        {
            get { return bitisIli; }
            set { bitisIli = value; }
        }

        string tarih;
        public string Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }

        string ucret;
        public string Ucret
        {
            get { return ucret; }
            set { ucret = value; }
        }

        public void UyeOl()
        {
            SqlCommand komut = new SqlCommand("Insert into Uyeler (Adi,Soyadi,KullaniciAdi,Sifre,KazanilanPara) values ('" + ad + "','" + soyad + "','" + kullaniciAdi + "','" + sifre + "',0) ", baglanti);
            KontrolEt();
            if (KulAdVarMi == false)
            {
                komut.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Üye Kaydı Başarılı");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Girdiğiniz Kullanıcı Adı Mevcut");
            }
            baglanti.Close();
        }
        private void KontrolEt()
        {
            baglanti = new SqlConnection("Data Source=L2PC11;Initial Catalog = BlaCar; Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Uyeler", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (KullaniciAdi != dr["KullaniciAdi"].ToString())
                {
                    return;
                }
                else
                {
                    KulAdVarMi = true;
                    break;
                }
            }
        }
        public void GirisYap()
        {
            SqlCommand komut = new SqlCommand("Select * from Uyeler where KullaniciAdi ='" + kullaniciAdi + "' and Sifre = '" + sifre + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                UyeID = dr["uyeID"].ToString();
                System.Windows.Forms.MessageBox.Show("Giriş Başarılı");
                frmAna frm = new frmAna();
                frm.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            baglanti.Close();
        }
        public void AracKaydet()
        {
            SqlCommand komut = new SqlCommand("Insert into Araclar (UyeID,Marka,Model) values ('" + UyeID + "','" + marka + "','" + model + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            System.Windows.Forms.MessageBox.Show("Araç Başarıyla Eklendi");
        }
        public void IlanVer()
        {
            SqlCommand komut = new SqlCommand("Insert into Ilanlar (UyeID,Arac,BaslangicIli,BitisIli,Tarih,Ucret) values ('" + UyeID + "','" + marka + "','" + baglangicIli + "','" + bitisIli + "','" + tarih + "','" + ucret + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            System.Windows.Forms.MessageBox.Show("İlan Verme Başarılı");
        }
        public void YolculugaKatil(int Ucret)
        {
            SqlCommand komut = new SqlCommand("Update set Kazanc = '" + (Ucret + Kazanc).ToString() + "'  Uyeler Where UyeID = " + ID + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            System.Windows.Forms.MessageBox.Show("Yolculuğa katılma başarılı");
        }
        public void KazancBul()
        {
            SqlCommand komut = new SqlCommand("select * from Uyeler Where UyeID = " + ID + "", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            Kazanc = int.Parse(dr["KazanilanPara"].ToString());
            baglanti.Close();
        }
    }
}
