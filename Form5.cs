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
    public partial class Form5 : Form
    {
        public Form5()
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
                dersSilGridListele.DataSource = veri;
            }

            komut.Dispose();
            baglanti.Close();
        }

        private void dersSilBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand DeleteCommand = new NpgsqlCommand();
            DeleteCommand.Connection = baglanti;
            DeleteCommand.Parameters.AddWithValue("@derskod", dersSildersKodu.Text);

            DeleteCommand.CommandType = CommandType.Text;
            DeleteCommand.CommandText = "delete from ders where derskod = @derskod";

            NpgsqlDataReader dataread = DeleteCommand.ExecuteReader();

            if (dataread.HasRows)
            {
                DataTable database = new DataTable();
                database.Load(dataread);
                dersSilGridListele.DataSource = database;
            }
            DeleteCommand.Dispose();
            baglanti.Close();

            showData("select * from ders");
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            showData("select * from ders");
        }
    }
}