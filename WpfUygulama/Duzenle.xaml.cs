using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static WpfUygulama.MainWindow;

namespace WpfUygulama
{
    
    public partial class Duzenle : Window
    {
        List<Kullanıcı> OgrenciBilgi = new List<Kullanıcı>();
        Kullanıcı ogrenciler = new Kullanıcı();
        public Duzenle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("Ad alanı boş bırakılamaz!");
                txtUyariAd.Visibility = Visibility.Visible;
            }

            else if (txtSoyad.Text == "")
            {
                MessageBox.Show("Soyad alanı boş bırakılamaz!");
                txtUyariSoyad.Visibility = Visibility.Visible;
            }

            else if (txtYas.Text == "")
            {
                MessageBox.Show("Yaş alanı boş bırakılamaz!");
                txtUyariYas.Visibility = Visibility.Visible;
            }

            else if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Cinsiyet alanı boş bırakılamaz!");
                txtUyariCinsiyet.Visibility = Visibility.Visible;
            }

            else if (txtOgrenciNo.Text == "")
            {
                MessageBox.Show("Öğrenci Numarası alanı boş bırakılamaz!");
                txtUyariNo.Visibility = Visibility.Visible;
            }

            else if (cmbBolum.Text == "")
            {
                MessageBox.Show("Bölüm alanı boş bırakılamaz!");
                txtUyariBolum.Visibility = Visibility.Visible;
            }

            else
            {
                ogrenciler.Ad = txtAd.Text;
                ogrenciler.Soyad = txtSoyad.Text;
                ogrenciler.Yas = int.Parse(txtYas.Text);
                ogrenciler.Cinsiyet = cmbCinsiyet.Text;
                ogrenciler.OgrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
                ogrenciler.Bolum = cmbBolum.Text;
                OgrenciBilgi.Add(ogrenciler);
                tablo2.Items.Add(ogrenciler);
                cmbListele.Items.Add(ogrenciler.Ad + " " + ogrenciler.Soyad);
                txtUyariAd.Visibility = Visibility.Hidden;
                txtUyariSoyad.Visibility = Visibility.Hidden;
                txtUyariYas.Visibility = Visibility.Hidden;
                txtUyariCinsiyet.Visibility = Visibility.Hidden;
                txtUyariNo.Visibility = Visibility.Hidden;
                txtUyariBolum.Visibility = Visibility.Hidden;
                txtAd.Clear();
                txtSoyad.Clear();
                txtYas.Clear();
                cmbCinsiyet.Text = "";
                txtOgrenciNo.Clear();
                cmbBolum.Text = "";

            }
        }

        private void btnSil_Click(object sender, RoutedEventArgs e)
        {
            
            tablo2.Items.Remove(ogrenciler);
        }

        private void btnGeriDon_Click(object sender, RoutedEventArgs e)
        {
            MainWindow anamenu = new MainWindow();
            anamenu.Show();
            this.Hide();
        }

        private void cmbListele_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = cmbListele.SelectedIndex;
            MessageBox.Show("Adı: "+ OgrenciBilgi[index].Ad
            + "\n" + "Soyadı: "+ OgrenciBilgi[index].Soyad
            + "\n" + "Yaşı: "+ OgrenciBilgi[index].Yas.ToString()
            + "\n" + "Cinsiyeti: "+ OgrenciBilgi[index].Cinsiyet
            + "\n" + "Numarası: "+ OgrenciBilgi[index].OgrenciNo.ToString()
            + "\n" + "Bölümü: "+ OgrenciBilgi[index].Bolum);
        }
    }
}
