using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace _210601046_ŞilanEkin_ödev2_veri
{
    public partial class Form1 : Form
    {
        public Form1()
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
                GridListele.DataSource = veri;
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void dersekle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void dersisil_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void dersiguncelle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            using (var komut = new NpgsqlCommand("SELECT derskredi, harfnot FROM ders where harfnot IS NOT NULL", baglanti))
            using (var reader = komut.ExecuteReader())
            {
                double toplmkredi = 0;
                double toplmharfNotu = 0;

                while (reader.Read())
                {
                    int dersKredi = (int)reader["derskredi"];
                    string dersHarfNotu = (string)reader["harfnot"];
                    double not = 0;


                    switch (dersHarfNotu)
                    {

                        case "AA": not = 4.00; break;
                        case "BA": not = 3.50; break;
                        case "BB": not = 3.00; break;
                        case "CB": not = 2.50; break;
                        case "CC": not = 2.00; break;
                        case "DC": not = 1.50; break;
                        case "DD": not = 1.00; break;
                        case "FF": not = 0.00; break;

                    }

                    toplmkredi += dersKredi;
                    toplmharfNotu += dersKredi * not;

                }
                double GNO = (toplmharfNotu / toplmkredi);

                double Gano = Math.Round(GNO, 2);
                gano.Text = Gano.ToString();
            }

            baglanti.Close();

            showData("select * from ders");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showData("select * from ders");

        }
    }
}
