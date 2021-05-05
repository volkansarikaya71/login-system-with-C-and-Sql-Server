using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yönetici_paneli
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        void cagır()
        {
            baglanti.Open();
            string sql = "Select * From Kullanici where KullaniciAdi=@KullaniciAdi and Password=@Sifre";
            SqlParameter prm1 = new SqlParameter("KullaniciAdi", textBox1.Text.Trim());
            SqlParameter prm2 = new SqlParameter("Sifre", textBox2.Text.Trim());
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);
        }
            private void button1_Click(object sender, EventArgs e)
        {
 
            
try
            {
                SqlCommand komut = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                cagır();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Giriş Başarılı");
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("HATALI GİRİŞ");
                cagır();
            }
        }
    }
}
