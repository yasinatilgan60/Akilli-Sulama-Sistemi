using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;

namespace AkilliSulamaSistemi
{
    public partial class bilgiEkrani : Form
    {
        string[] Portlar = SerialPort.GetPortNames(); //Bilgisayarda açık olan portlar alınır.
        SqlConnection baglanti = new SqlConnection("Data Source=ATILGAN;Initial Catalog=AkilliSulamaSistem;Integrated Security=True"); //Sql bağlantı adresi.
        public bilgiEkrani()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void baslat_Click(object sender, EventArgs e)
        {
            
            timer1.Start(); //timer ile masaüstü uygulaması bir döngü içerisinde çalıştırılır.
            timer1.Interval = 305;
            if(serialPort1.IsOpen == false)
            {
                if(portCombobox.Text=="")
                  return;
                serialPort1.PortName = portCombobox.Text; //açık olan portlar combobox içerisine yazdırılır.
                serialPort1.BaudRate = 9600;
                try
                {
                    serialPort1.Open(); //Seri port sorun olmaması halinde açılır.
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata" + ex.Message);
                }
            }
           
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize eminmisiniz?", "Uyarı!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            girisForm form = new girisForm(); //geri butonuna basıldığında giris formu tekrar açılır.
            this.Hide();
            form.Show();
        }

        private void suMotoruCalistir_Click(object sender, EventArgs e)
        {
            // başlat butonu ile sistem çalışıyor ise su motoru çalıştırılabilir.
            if (timer1.Enabled == true) // timer aktif ise yani sistem başlat ile çalışıyorken müdahale edilebilmesi için yazılmıştır.
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.Open();
                }
                serialPort1.Write("1"); // Arduino'ya 1 mesajı yollanmıştır.
                timer1.Interval = 5005; //Arduino tarafında 5000 ms bekletildiği için burada interval ayarı arayüzün donmaması için değiştirilmiştir.
            }
            
        }

        private void bilgiEkrani_Load(object sender, EventArgs e)
        {
            
            foreach (string port in Portlar)
            {
                portCombobox.Items.Add(port); //bilgi ekranı yüklenince açık olan portlar combobox içerisine yazdırılmıştır.
            }
        }

        private void portCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = portCombobox.SelectedItem.ToString();
            serialPort1.Open();
        }

        private void suMotoruKapat_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2"); //Arduino'ya 2 mesajı yollanmıştır.
        }
        public void degerleriKaydet(string nem,string su)
        {
            try
            {
                //Buradaki kodlar ile veritabanına veriler kaydedilecektir.
                if(baglanti.State== ConnectionState.Closed)
                {
                    baglanti.Open();
                    String zaman;
                    zaman = DateTime.Now.ToString();
                    string kaydet = "insert into toprak_nem(nemDeger,tarih) values(@nem,@tarih) insert into su_seviyesi(suSeviyesi,tarih) values(@su,@tarih)";
                    SqlCommand komut = new SqlCommand(kaydet, baglanti);
                    komut.Parameters.AddWithValue("@nem", nem);
                    komut.Parameters.AddWithValue("@tarih", zaman);
                    komut.Parameters.AddWithValue("@su", su);
                    komut.ExecuteNonQuery();
                    
                    //su motoru çalışıyorken(toprak nem,su seviyesi
                    //durumuna göre) nemListesi adlı listviewa veriler yazdırılsın 
                    // ve su_motoru adlı tabloya bilgiler kaydedilsin.
                    if(Convert.ToInt16(nem)>750 && Convert.ToInt16(su)>=300)
                    {
                        string kaydet2 = "insert into su_motoru(nemDeger,tarih) values(@nemDeger,@tarihDeger)";
                        SqlCommand komut2 = new SqlCommand(kaydet2, baglanti);
                        komut2.Parameters.AddWithValue("@nemDeger", nem);
                        komut2.Parameters.AddWithValue("@tarihDeger", zaman);
                        komut2.ExecuteNonQuery();
                        string[] row2 = { nem, zaman };
                        var satir2 = new ListViewItem(row2);
                        nemListesi.Items.Add(satir2);
                    }
                    baglanti.Close();
                    //Aynı anda veri tabanına giden veriyi listView'a veri ekliyoruz.
                    string[] row = { nem, su, zaman };
                    var satir = new ListViewItem(row);
                    degerlerListesi.Items.Add(satir);

                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                String sonuc = serialPort1.ReadLine(); //Arduino'nun seri portundan gelen bilgiler okunmuştur.
                string[] degerler = sonuc.Split('*'); //Split metodu ile toprak nem ve su seviyesi bilgileri ayrı ayrı yazdırılır.
                nemDegeri.Text = degerler[0];
                suDegeri.Text = degerler[1];
                toprakNem.Minimum = 0; // İki değeri grafiksel olarak gösteren progress bar kodlarıdır.
                toprakNem.Maximum = 1100;
                toprakNem.Value = Convert.ToInt16(nemDegeri.Text);
                suSeviyesi.Minimum = 0;
                suSeviyesi.Maximum = 750;
                suSeviyesi.Value = Convert.ToInt16(suDegeri.Text);
                degerleriKaydet(nemDegeri.Text,suDegeri.Text);
                serialPort1.DiscardInBuffer(); //Seri portun bufferını temizlemek için kullanılmıştır.
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Stop();
                
            }
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Durdur butonunda seri port ve timer kapatılır.
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }

        private void bilgiEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }
    }
}
