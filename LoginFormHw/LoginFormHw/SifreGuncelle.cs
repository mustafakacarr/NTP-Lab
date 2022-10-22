using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginFormHw
{
    public partial class SifreGuncelle : Form
    {
        int userId;
        public SifreGuncelle(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String password = textBox1.Text;
            String repassword = textBox2.Text;
            if (password.Equals(repassword))
            {
                DbConnection db = new DbConnection();
                NpgsqlConnection conn = db.connect();

                var sql = "Update users set password=@password where id=@id";
                var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("id", userId);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifreniz başarıyla güncellenmiştir.", "Başarılı");
                this.Hide();


            }
            else
            {
                MessageBox.Show("Lütfen girdiğiniz şifrelerin aynı olduğundan emin olunuz.", "Hata!");
            }
         
        }
    }
}
