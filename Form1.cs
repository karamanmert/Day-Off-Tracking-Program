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
    public partial class Form1 : Form
    {
        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        internal static string gonderilecekveri;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
         }

        private void kayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelKayit personelKayit = new personelKayit();
            personelKayit.Show();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istenCikis istencikis = new istenCikis();
            istencikis.Show();

        }

        private void izinGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izinKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            izintalep izintalep = new izintalep();
            izintalep.Show();
        }

        private void raporlamaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ik ik = new ik();
            ik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void düzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            düzenleme düzenleme= new düzenleme();
            düzenleme.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            {
                string ad = textBox1.Text;
                string sifre = textBox2.Text;
                con = new OleDbConnection ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM kullanici where k_ad='" + textBox1.Text + "' AND k_sifre='" + textBox2.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    menuStrip1.Visible = true;
                    con.Close();
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    button1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                }

             
            }
        }
    }
    
}
