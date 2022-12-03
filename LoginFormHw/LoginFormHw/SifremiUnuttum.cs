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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using DevExpress.Utils.Serializing;

namespace LoginFormHw
{
    public partial class SifremiUnuttum : Form
    {
        int dogrulamaKodu,userId;
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email = textBox1.Text;


            DbConnection db = new DbConnection();
            NpgsqlConnection conn = db.connect();

            var sql = "Select * from users where email='" + email + "'";
            var cmd = new NpgsqlCommand(sql, conn);

            var rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                userId=rdr.GetInt16(0);
                Random random = new Random();
                dogrulamaKodu = random.Next(9999999);
                if (sendVerificationMail(email,dogrulamaKodu))
                {
                    MessageBox.Show("Doğrulama kodu " + email + " adresine gönderildi.", "Başarılı!");
                    panel1.Enabled = false;
                    panel2.Enabled = true;


                }
                else
                {
                    MessageBox.Show("Doğrulama kodu gönderilirken bir sorun oluştu.", "Hata!");
                }

            }
            else
            {
                MessageBox.Show("Böyle bir e-posta adresi sistemimizde kayıtlı değil.","HATA!");
            }


        }
 public static bool sendVerificationMail(String email,int dogrulama)
        {

            String mesaj = "Merhaba, şifrenizi yenilemek için kullanmanız gereken doğrulama kodu; " + "<br><strong>" + dogrulama + "</strong><br><br>Bu kodu kullanarak şifre güncelleme aşamasına geçebilirsiniz. ";
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "mail.mustafakacar.com.tr"; // Hostunuzun smtp için mail domaini.
            client.EnableSsl = true; // Güvenlik ayarları, host'a ve gönderilen server'a göre değişebilir.
            client.Timeout = 10000; // Milisaniye cinsten timeout
            client.DeliveryMethod = SmtpDeliveryMethod.Network; // Mailin yollanma methodu
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("my@mustafakacar.com.tr", "*******"); // Burada hangi hesabı kullanarak mail yollayacaksanız onun ayarlarını yapmanız gerekiyor
            MailMessage mm = new MailMessage("my@mustafakacar.com.tr", "mustafakacar48@outlook.com.tr", "Şifre Yenileme",mesaj); // Hangi mail adresinden nereye, konu ve içerik mail ayarlarını yapabilirsiniz
            mm.IsBodyHtml = true; // True: Html olarak Gönderme, False: Text olarak Gönderme
            mm.BodyEncoding = UTF8Encoding.UTF8; // UTF8 encoding ayarı
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure; // Hata olduğunda uyarı ver
            client.Send(mm); // Mail yolla
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String gelen = textBox2.Text;
            if (dogrulamaKodu.ToString().Equals(gelen))
            {
                this.Hide();
                SifreGuncelle sifreGuncelle = new SifreGuncelle(userId);
                sifreGuncelle.Show();

            }
            else
            {
                MessageBox.Show("Doğrulama kodunu yanlış girdiniz.", "Hata!");
            }

        }
    }
}
