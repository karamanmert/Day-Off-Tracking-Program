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
    public partial class izintalep : Form
    {
        public izintalep()
        {
            InitializeComponent();
        }
        public static string gonderilecekveri;
        public static string gonderilecekveri1;
        public static string kalanizin;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {         
            comboBox3.Items.Clear();
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(connetionString);
            OleDbCommand kmt = new OleDbCommand();
            DataTable tablo = new DataTable();
           
            baglanti.Open();
            kmt.Connection = baglanti;
            kmt.CommandText = ("select adi+ ' ' +soyadi   from personel where departman like '" + comboBox2.SelectedItem + "%'");
            OleDbDataReader oku1;
            oku1 = kmt.ExecuteReader();
            while (oku1.Read())
            {
                comboBox3.Items.Add(oku1[0].ToString());
            }
            baglanti.Close(); ;
            oku1.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(connetionString);
            OleDbCommand kmt = new OleDbCommand();
            DataTable tablo = new DataTable();
            
            baglanti.Open();
            kmt.Connection = baglanti;
            kmt.CommandText = ("select tc from personel where adi+ ' ' +soyadi like '" + comboBox3.SelectedItem + "%'");
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();

            while (oku.Read())
            {
                label11.Text = oku["tc"].ToString();
            }
           
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gunSayi;
            #region iş günü hesap
            { 
            DateTime baslangic = dateTimePicker1.Value;
            int kullanilan;
            kullanilan = 0;
            do
            {
                if (baslangic.DayOfWeek != DayOfWeek.Saturday
                    && baslangic.DayOfWeek != DayOfWeek.Sunday)
                {
                    kullanilan++;
                }
                baslangic = baslangic.AddDays(1);
            }
            while (baslangic <= dateTimePicker2.Value);
            int kalan;
            kalan = Convert.ToInt32(label10.Text);
            if (kalan < kullanilan)
            {
                MessageBox.Show("İzin sayınız doldu");
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
            {
                DateTime baslangic = dateTimePicker1.Value;

                gunSayi = 0;
                do
                {
                    if (baslangic.DayOfWeek != DayOfWeek.Saturday
                        && baslangic.DayOfWeek != DayOfWeek.Sunday)
                    {
                        gunSayi++;
                    }
                    baslangic = baslangic.AddDays(1);
                }
                while (baslangic <= dateTimePicker2.Value);

                MessageBox.Show(gunSayi + " iş günü izin eklendi");
                
            }
            int kala1;
            kala1 = Convert.ToInt32(label10.Text) - Convert.ToInt32(gunSayi);
            #endregion
            string bastar = Convert.ToString(dateTimePicker1.Text);
            string bittar = Convert.ToString(dateTimePicker2.Text);
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            string ekle = "insert into izin_talep(adiSoyadi,tc_no,izin_turu,bas_tar,bit_tar,aciklama,kullanilan,kalan_izin) values (@adiSoyadi,@tc_no,@izin_turu,@bas_tar,@bit_tar,@aciklama,@kullanilan,@kalan_izin)";
            OleDbCommand komut = new OleDbCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@adiSoyadi", comboBox3.Text);
            komut.Parameters.AddWithValue("@tc_no", label11.Text);
            komut.Parameters.AddWithValue("@izin_turu", comboBox1.Text);
            komut.Parameters.AddWithValue("@bas_tar", bastar);
            komut.Parameters.AddWithValue("@bit_tar", bittar);
            komut.Parameters.AddWithValue("@aciklama", textBox1.Text);
            komut.Parameters.AddWithValue("@kullanilan", gunSayi);
            komut.Parameters.AddWithValue("@kalan",kala1);
            komut.ExecuteNonQuery();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            label11.Text = "";
            label10.Text = "";
            dateTimePicker1.Value = DateTime.Today;
          
                }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hak;
            int kul;
            int kalan;
            {
                string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
                OleDbConnection baglanti = new OleDbConnection(connetionString);
                OleDbCommand kmt = new OleDbCommand();
                DataTable tablo = new DataTable();
                
                baglanti.Open();
                kmt.Connection = baglanti;
                kmt.CommandText = ("select gunu from deneme where izinAdi like '" + comboBox1.SelectedItem + "%'");
                OleDbDataReader oku;
                oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku["gunu"].ToString();
                    hak = Convert.ToInt32(label12.Text);

                }
            }
            {
                string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
                OleDbConnection baglanti = new OleDbConnection(connetionString);
                OleDbCommand kmt = new OleDbCommand();
                DataTable tablo = new DataTable();
                OleDbDataAdapter adtr = new OleDbDataAdapter();
                baglanti.Open();
                kmt.Connection = baglanti;
                kmt.CommandText = ("select sum(kullanilan) as kul from izin_talep where izin_turu+ ' ' +adiSoyadi like '" + comboBox1.SelectedItem + ' ' + comboBox3.SelectedItem + "%'");
                OleDbDataReader oku;
                oku = kmt.ExecuteReader();

                while (oku.Read())
                {
                    label2.Text = oku["kul"].ToString();
                    if (label2.Text != "")
                    {
                        kul = Convert.ToInt32(label2.Text);
                    }
               
                                          
            else
                {
                    label2.Text = "0";
                }
                kalan = Convert.ToInt32(label12.Text) - Convert.ToInt32(label2.Text);
                label10.Text = Convert.ToString(kalan);
                    kalanizin = label10.Text;
            }
         }
        }

        private void izintalep_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label12.Visible = false;
          
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime enaz = dateTimePicker1.Value;
            dateTimePicker2.MinDate = enaz;
           
            DateTime baslangic = dateTimePicker1.Value;
            int kullanilan;
            kullanilan = 0;
            do
            {
                if (baslangic.DayOfWeek != DayOfWeek.Saturday
                    && baslangic.DayOfWeek != DayOfWeek.Sunday)
                {
                    kullanilan++;
                }
                baslangic = baslangic.AddDays(1);
            }
            while (baslangic <= dateTimePicker2.Value);
            int kalan;
            kalan = Convert.ToInt32(label10.Text);
            if (kalan < kullanilan)
            {
                MessageBox.Show("İzin gününüz doldu");
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                gonderilecekveri = comboBox3.Text;
                gonderilecekveri1 = comboBox1.Text;
           
             ikrapor ikrapor = new ikrapor();
            ikrapor.Show();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
        }

