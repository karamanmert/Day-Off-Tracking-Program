using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace takip1
{
    public partial class istenCikis : Form
    {
        public istenCikis()
        {
            InitializeComponent();
        }

        public void istenCikis_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tarih = Convert.ToString(dateTimePicker1.Text);

            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(connetionString);
            OleDbCommand kmt = new OleDbCommand();
            DataTable tablo = new DataTable();

            baglanti.Open();
            kmt.Connection = baglanti;
            kmt.CommandText = ("delete from personel where departman+ ' ' +adi+ ' ' +soyadi like '" + comboBox1.SelectedItem + ' ' + comboBox2.SelectedItem + "%'");
            kmt.ExecuteNonQuery();


            string ekle = "insert into istenCikis(adiSoyadi,departman,istenCikisTarih,aciklama) values (@adiSoyadi,@departman,@istenCikisTarih,@aciklama)";
            OleDbCommand komut = new OleDbCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@adiSoyadi", comboBox2.SelectedItem);
            komut.Parameters.AddWithValue("@departman", comboBox1.SelectedItem);
            komut.Parameters.AddWithValue("@istenCikisTarih", tarih);
            komut.Parameters.AddWithValue("@aciklama", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıdınız başarıyla silindi");
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(connetionString);
            OleDbCommand kmt = new OleDbCommand();
            DataTable tablo = new DataTable();

            baglanti.Open();
            kmt.Connection = baglanti;
            kmt.CommandText = ("select adi+ ' ' +soyadi   from personel where departman like '" + comboBox1.SelectedItem + "%'");
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            comboBox2.Items.Clear();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku[0].ToString());
            }
            oku.Close();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void label4_Click(object sender, EventArgs e)
        {

        }
}
    }