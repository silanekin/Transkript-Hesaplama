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
    public partial class Form2 : Form
    {
        public Form2()
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

            NpgsqlDataReader okuma = komut.ExecuteReader();

            if (okuma.HasRows)
            {
                DataTable veri = new DataTable();
                veri.Load(okuma);
                dersEklegridListele.DataSource = veri;
            }

            komut.Dispose();
            baglanti.Close();
        }
        

        private void dersEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand addCommand = new NpgsqlCommand();
            addCommand.Connection = baglanti;

            addCommand.Parameters.AddWithValue("@derskod", txtdersEkleid.Text);
            addCommand.Parameters.AddWithValue("@dersad", txtdersEkleAd.Text);
            addCommand.Parameters.AddWithValue("@derskredi", Convert.ToInt32(txtdersEkleKredi.Text));
            addCommand.Parameters.AddWithValue("@dersakts", Convert.ToInt32(txtdersEkleAkts.Text));
            addCommand.Parameters.AddWithValue("@ogretimuye", txtdersEkleogretimuye.Text);
            addCommand.Parameters.AddWithValue("@dersdonem", txtdersEkledonem.Text);
            addCommand.Parameters.AddWithValue("@harfnot", txtdersEkleHarfnotu.Text);

            addCommand.CommandType = CommandType.Text;
            addCommand.CommandText = "insert into ders values (@derskod, @dersad, @derskredi, @dersakts, @ogretimuye, @dersdonem, @harfnot)";

            NpgsqlDataReader okuma = addCommand.ExecuteReader();
            if (okuma.HasRows)
            {
                DataTable veri = new DataTable();
                veri.Load(okuma);
                dersEklegridListele.DataSource = veri;
            }
            addCommand.Dispose();
            baglanti.Close();

            showData("Select * from ders");
        }

        private void iptaldersEkleBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void dersEkleGoster_Click(object sender, EventArgs e)
        {
            showData("select * from ders where derskod = '" + txtdersEkleid.Text + "'");

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            showData("select * from ders");
        }

       
    }
   
}
