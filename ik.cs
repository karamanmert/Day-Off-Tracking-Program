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
namespace takip1
{
    public partial class ik : Form
    {
        public ik()
        {
            InitializeComponent();
        }

         

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(connetionString);
            OleDbCommand kmt = new OleDbCommand();
            DataTable tablo = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            baglanti.Open();
            kmt.Connection = baglanti;
            kmt.CommandText = ("select adi+ ' ' +soyadi   from personel where departman like '" + comboBox1.SelectedItem + "%'");
            OleDbDataReader oku1;
            oku1 = kmt.ExecuteReader();
            while (oku1.Read())
            {
                comboBox2.Items.Add(oku1[0].ToString());
            }
            baglanti.Close();
            oku1.Close();
            DataSet dtst = new DataSet();
            if (comboBox2.SelectedItem == "HEPSİ" || comboBox1.SelectedItem == "HEPSİ")
            {
                OleDbDataAdapter adtr1 = new OleDbDataAdapter("select * from izin_talep", baglanti);
                adtr1.Fill(dtst, "izin_talep");
                dataGridView1.DataSource = dtst.Tables["izin_talep"];
                adtr1.Dispose();
                baglanti.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(connetionString);
            OleDbCommand kmt = new OleDbCommand();
            DataTable tablo = new DataTable();
            DataSet dtst = new DataSet();
            baglanti.Open();
            if (comboBox3.SelectedItem == "HEPSİ")
            {
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * from izin_talep where adiSoyadi like '" + comboBox2.SelectedItem + "%'", baglanti);
                adtr.Fill(dtst, "izin_talep");
                dataGridView1.DataSource = dtst.Tables["izin_talep"];
                adtr.Dispose();
                baglanti.Close();
            }
            else
            {
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * from izin_talep where adiSoyadi+ ' ' +izin_turu like '" + comboBox2.SelectedItem + ' ' + comboBox3.SelectedItem + "%'", baglanti);
                adtr.Fill(dtst, "izin_talep");
                dataGridView1.DataSource = dtst.Tables["izin_talep"];
                adtr.Dispose();
                baglanti.Close();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime enaz = dateTimePicker1.Value;
            dateTimePicker2.MinDate = enaz;
            string bastar = Convert.ToString(dateTimePicker1.Text);
            string bittar = Convert.ToString(dateTimePicker2.Text);
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
            OleDbConnection baglanti = new OleDbConnection(connetionString);
            OleDbCommand kmt = new OleDbCommand();
            DataTable tablo = new DataTable();
            DataSet dtst = new DataSet();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from izin_talep where [bas_tar]>='" + bastar + "' and [bit_tar] <= '" + bittar + "'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            baglanti.Close();

        }

        private void ik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            this.Close();
        }
    }
}