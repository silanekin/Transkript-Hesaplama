using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210601046_ŞilanEkin_ödev2_veri
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=silan;User Id=postgres;Password=1234");
        public void showData(string text)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = text;
            NpgsqlDataReader dataread = komut.ExecuteReader();

            if (dataread.HasRows)
            {
                DataTable veri = new DataTable();
                veri.Load(dataread);
                dersGuncelleGridListele.DataSource = veri;
            }

            komut.Dispose();
            baglanti.Close();
        }

        private void dersGuncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand Guncelle = new NpgsqlCommand();
            Guncelle.Connection = baglanti;

            Guncelle.Parameters.AddWithValue("@derskod", dersGuncelledersid.Text);
            Guncelle.Parameters.AddWithValue("@dersad", dersGuncelledersAd.Text);
            Guncelle.Parameters.AddWithValue("@derskredi", Convert.ToInt32(dersGuncelledersKredi.Text));
            Guncelle.Parameters.AddWithValue("@dersakts", Convert.ToInt32(dersGuncelleAkts.Text));
            Guncelle.Parameters.AddWithValue("@ogretimuye", dersGuncelleogretimuye.Text);
            Guncelle.Parameters.AddWithValue("@dersdonem", dersGuncelledonem.Text);
            Guncelle.Parameters.AddWithValue("@harfnot", dersGuncelleHarfnotu.Text);

            Guncelle.CommandType = CommandType.Text;
            Guncelle.CommandText = "update ders set derskod=@derskod, dersad=@dersad, derskredi=@derskredi, dersakts=@dersakts, ogretimuye=@ogretimuye, dersdonem=@dersdonem, harfnot=@harfnot where derskod = '" + dersGuncelledersid.Text + "'";
            NpgsqlDataReader okuma = Guncelle.ExecuteReader();

            if (okuma.HasRows)
            {
                DataTable veri = new DataTable();
                veri.Load(okuma);
                dersGuncelleGridListele.DataSource = veri;
            }

            Guncelle.Dispose();
            baglanti.Close();

            showData("select * from ders where derskod = '" + dersGuncelledersid.Text + "'");
        }

        private void dersGuncelleiptalBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            showData("select * from ders");
        }

        private void dersGuncellegosterBtn_Click(object sender, EventArgs e)
        {
            showData("select * from ders where derskod = '" + dersGuncelledersid.Text + "'");
        }
    }

        
    }

