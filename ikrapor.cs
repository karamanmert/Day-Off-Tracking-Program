using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takip1
{
    public partial class ikrapor : Form
    {
        public static string kalanizin;
        public ikrapor()
        {
            InitializeComponent();
        }

        private void ikrapor_Load(object sender, EventArgs e)
        {

            label1.Text = izintalep.gonderilecekveri;
            comboBox1.Text = izintalep.gonderilecekveri1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                        label5.Text = oku["gunu"].ToString();
                        hak = Convert.ToInt32(label5.Text);

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
                    kmt.CommandText = ("select sum(kullanilan) as kul from izin_talep where izin_turu+ ' ' +adiSoyadi like '" + comboBox1.SelectedItem + ' ' + label1.Text + "%'");
                    OleDbDataReader oku;
                    oku = kmt.ExecuteReader();

                    while (oku.Read())
                    {
                        label6.Text = oku["kul"].ToString();
                        if (label6.Text != "")
                        {
                            kul = Convert.ToInt32(label6.Text);
                        }


                        else
                        {
                            label6.Text = "0";
                        }
                        kalan = Convert.ToInt32(label5.Text) - Convert.ToInt32(label6.Text);
                        label4.Text = Convert.ToString(kalan);
                        kalanizin = label4.Text;
                    }
                }
            }
            {

                string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
                OleDbConnection baglanti = new OleDbConnection(connetionString);
                OleDbCommand kmt = new OleDbCommand();
                DataTable tablo = new DataTable();
                DataSet dtst = new DataSet();
                baglanti.Open();
                if (comboBox1.SelectedItem == "HEPSİ")
                {
                    OleDbDataAdapter adtr = new OleDbDataAdapter("select * from izin_talep where adiSoyadi like '" + label1.Text + "%'", baglanti);
                    adtr.Fill(dtst, "izin_talep");
                    dataGridView1.DataSource = dtst.Tables["izin_talep"];
                    adtr.Dispose();
                    baglanti.Close();
                }
                else
                {
                    OleDbDataAdapter adtr = new OleDbDataAdapter("select * from izin_talep where adiSoyadi+ ' ' +izin_turu like '" + label1.Text + ' ' + comboBox1.SelectedItem + "%'", baglanti);
                    adtr.Fill(dtst, "izin_talep");
                    dataGridView1.DataSource = dtst.Tables["izin_talep"];
                    adtr.Dispose();
                    baglanti.Close();

                }


            }
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}