using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkilliSulamaSistemi
{
    public partial class girisForm : Form
    {
        public girisForm()
        {
            InitializeComponent();
        }
        
        private void girisYap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source = ATILGAN; Initial Catalog = AkilliSulamaSistem; Integrated Security = True");
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select Kullaniciadi,sifre from giris where Kullaniciadi='" + txtKullanıcı.Text + "' and sifre='" + txtSifre.Text + "'", baglanti);
                SqlDataReader okuma;
                okuma = cmd.ExecuteReader();
                int sayac = 0;
                while (okuma.Read())
                {
                    sayac = +1;
                }
                if (sayac == 1)
                {
                    bilgiEkrani ekran = new bilgiEkrani();
                    this.Hide();
                    ekran.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz");
                    girisForm form = new girisForm();
                    this.Hide();
                    form.Show();
                    
                }
            }catch(SqlException hata)
            {
                MessageBox.Show("Kullanıcı girinde hata oluştu."+hata);
            }
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
