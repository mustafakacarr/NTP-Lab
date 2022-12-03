using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Db;

namespace LoginFormHw
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
        }


      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String username = textBox1.Text;
            String password = textBox2.Text;

            DbConnection db = new DbConnection();
            NpgsqlConnection conn = db.connect();

            var sql = "Select * from users where username='"+username+ "' AND password='" + password + "'";
            var cmd = new NpgsqlCommand(sql, conn);

            var rdr = cmd.ExecuteReader();

            if (rdr.Read()) MessageBox.Show("Giriş İşlemi Başarılı","Başarılı"); else MessageBox.Show("Böyle bir kullanıcı bulunamadı.","HATA!");


            /* while (rdr.Read())

            {
                
            }*/



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum SifremiUnuttum_f = new SifremiUnuttum();
            SifremiUnuttum_f.Show();
        }
    }
}
