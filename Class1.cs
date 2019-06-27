using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;

namespace takip1
{
    public class DBIslemleri
    {
        public OleDbConnection baglanti;
  
        public void DbKapat()
        {
            baglanti.Close();
        }

        public void DbAc()
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database2.accdb;Persist Security Info=True";
            baglanti = new OleDbConnection(connetionString);
            baglanti.Open();
        }
    }
}
