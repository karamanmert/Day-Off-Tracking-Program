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
    public partial class personelKayit : Form
    {



        public personelKayit()
        {
            InitializeComponent();
        }


        private void personelKayit_Load(object sender, EventArgs e)
        {
            {
                string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
                OleDbConnection baglanti = new OleDbConnection(vtyolu);
                baglanti.Open();
                baglanti.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                {
                    if (ctl.Text == String.Empty)
                    {
                        MessageBox.Show(Convert.ToString(((TextBox)ctl).Text + " boş!"));
                    }
                   
                }
            if (txtTc.Text.Length != 11)
            {
                MessageBox.Show("Lüften doğru TC kimlik numarası giriniz");
            }
            else
            {
                string tarih = Convert.ToString(dateTimePicker1.Text);
                string ceptel = Convert.ToString(txtTelefon.Text);
                string tc = Convert.ToString(txtTc.Text);
                string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
                OleDbConnection baglanti = new OleDbConnection(vtyolu);
                baglanti.Open();
                string ekle = "insert into personel(adi,soyadi,tc,departman,gorevi,iseGiris,telefon,adres) values (@adi,@soyadi,@tc,@departman,@gorevi,@iseGiris,@telefon,@adres)";
                OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                komut.Parameters.AddWithValue("@adi", txtAdi.Text);
                komut.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
                komut.Parameters.AddWithValue("@tc", tc);
                komut.Parameters.AddWithValue("@departman", cmbDepartman.Text);
                komut.Parameters.AddWithValue("@gorevi", txtGorevi.Text);
                komut.Parameters.AddWithValue("@iseGiris", tarih);
                komut.Parameters.AddWithValue("@telefon", ceptel);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarıyla kayıt edildi");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tbox = (TextBox)item;
                        tbox.Clear();
                    }
                    
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 