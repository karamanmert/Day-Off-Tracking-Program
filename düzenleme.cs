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
   
    public partial class düzenleme : Form
    {
        public düzenleme()
        {
            InitializeComponent();
        }


        private void düzenleme_Load(object sender, EventArgs e)
        {

        }
  
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DBIslemleri db = new DBIslemleri();

            OleDbCommand kmt = new OleDbCommand();
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            db.DbAc();
            kmt.Connection = db.baglanti;
            kmt.CommandText = ("select adi+ ' ' +soyadi   from personel where departman like '" + comboBox1.SelectedItem + "%'");
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            comboBox2.Items.Clear();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku[0].ToString());
            }
            db.DbKapat();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBIslemleri db = new DBIslemleri();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            db.DbAc();
            kmt.Connection = db.baglanti;

            kmt.CommandText = ("select *   from personel where adi+ ' ' +soyadi like '" + comboBox2.SelectedItem + "%'");
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            
            while (oku.Read())
            {
                txtAdi.Text=(oku[1].ToString());
                txtSoyadi.Text = (oku[2].ToString());
                txtTc.Text = (oku[3].ToString());
                cmbDepartman.Text= (oku[4].ToString());
                txtGorevi.Text = (oku[5].ToString());
                txtTelefon.Text= (oku[7].ToString());
                txtAdres.Text= (oku[8].ToString());

            }
            db.DbKapat();
     }

        private void button1_Click(object sender, EventArgs e)
        {

            DBIslemleri db = new DBIslemleri();

            OleDbCommand kmt = new OleDbCommand();
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            db.DbAc();
            kmt.Connection = db.baglanti;
            kmt.CommandText = "update personel set adi='" + txtAdi.Text + "',soyAdi='" + txtSoyadi.Text + "',tc='" + txtTc.Text + "',departman='" + cmbDepartman.Text + "',gorevi='" + txtGorevi.Text + "',iseGiris='" + dateTimePicker1.Text + "',telefon='" + txtTelefon.Text + "',adres='" + txtAdres.Text + "' where departman+ ' ' +adi+ ' ' +soyadi like '" + comboBox1.SelectedItem + ' ' + comboBox2.SelectedItem + "%'";
            kmt.ExecuteNonQuery();
            db.DbKapat();
            MessageBox.Show("Kayıdınız başarıyla güncellendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
