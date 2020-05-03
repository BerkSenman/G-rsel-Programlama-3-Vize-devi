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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUygulama
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Kullanıcı> liste;
        public MainWindow()
        {
            InitializeComponent();
            liste = new List<Kullanıcı>()
            {
                new Kullanıcı() { Ad = "Hüseyin Berk", Soyad = "Şenman", Yas = 20, Cinsiyet = "Erkek", OgrenciNo = 181130064, Bolum = "Bilgisayar Programcılığı" }
            };

        }
        
        public class Kullanıcı
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }
            public string Cinsiyet { get; set; }
            public int OgrenciNo { get; set; }
            public string Bolum { get; set; }

        }

        private void btnDuzenle_Click(object sender, RoutedEventArgs e)
        {
            Duzenle duzenle = new Duzenle();
            duzenle.Show();
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tablo1.ItemsSource = liste;
        }
    }
}
