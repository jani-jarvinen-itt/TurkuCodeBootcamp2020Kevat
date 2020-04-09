using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSqlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello World!");

            string yhteysmerkkijono = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            SqlConnection yhteys = new SqlConnection(yhteysmerkkijono);

            yhteys.Open();
            MessageBox.Show("Tietokantayhteys avattu.");

            string sql = "SELECT * FROM Customers";
            SqlCommand komento = new SqlCommand(sql, yhteys);

            SqlDataReader lukija = komento.ExecuteReader();
            while (lukija.Read())
            {
                string id = lukija["CustomerID"].ToString();
                string nimi = lukija["CompanyName"].ToString();

                MessageBox.Show($"{id} = {nimi}");

                if (id == "BONAP")
                {
                    break;
                }
            }

            yhteys.Close();
            MessageBox.Show("Tietokantayhteys suljettu.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string yhteysmerkkijono = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            SqlConnection yhteys = new SqlConnection(yhteysmerkkijono);

            yhteys.Open();

            string sql = "SELECT * FROM Customers";
            SqlCommand komento = new SqlCommand(sql, yhteys);

            SqlDataReader lukija = komento.ExecuteReader();
            List<Asiakas> asiakkaat = new List<Asiakas>();
            while (lukija.Read())
            {
                Asiakas asiakas = new Asiakas()
                {
                    AsiakasId = lukija["CustomerID"].ToString(),
                    Nimi = lukija["CompanyName"].ToString(),
                    Kontaktihenkilö = lukija["ContactName"].ToString(),
                    Maa = lukija["Country"].ToString(),
                };

                asiakkaat.Add(asiakas);
            }

            yhteys.Close();

            // näytetään tulokset ruudulla
            dataGridView1.DataSource = asiakkaat;
        }
    }
}
