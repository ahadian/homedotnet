using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace home
{
    public partial class Form1 : Form
    {
        public static void konek()
        {
            String host = "localhost";
            String user = "root";
            String pass = "";
            String database = "nodejs";
            String connSrt = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + pass + ";";
            MySqlConnection conn = new MySqlConnection(connSrt);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Koneksi gagal : " + e.Message);
            }
        }
        
        // konvert string ke sha1
        public static string GetSha1(string value)
        {
            var data = Encoding.ASCII.GetBytes(value);
            var hashData = new SHA1Managed().ComputeHash(data);
            var hash = string.Empty;
            foreach (var b in hashData)
                hash += b.ToString("X2");
            return hash;
        }

        public Form1()
        {
            InitializeComponent();
            konek();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String u = textBox1.Text;
            String p = textBox2.Text;
            //MessageBox.Show(GetSha1(p));
        }
    }
}
