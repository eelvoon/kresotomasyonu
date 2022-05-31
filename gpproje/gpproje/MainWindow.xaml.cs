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
namespace gpproje
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (ad.Text == "" || soyad.Text == "" || tc.Text == "" || comboBox1.Text == "")
            {

                MessageBox.Show("Eksik girildi lütfen tam doldurunuz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            else
            {
                listbox1.Items.Add("Adınız:" +" "+ad.Text + "   " + "Soyadınız:" +" "+ soyad.Text + "     " + "Tc:" +" "+ tc.Text + "   " + "Yaş:" +" "+ comboBox1.Text);

                ad.Text = "";
                soyad.Text = "";
                tc.Text = "";
                comboBox1.Text = "";

                ad.Focus();

            }


        }


        private void Temizle_click(object sender, RoutedEventArgs e)
        {


            ad.Clear();
            soyad.Clear();
            tc.Clear();
            comboBox1.SelectedIndex = -1;




        }

        DialogResultConverter DialogResultConverter = new DialogResultConverter();
        private void Sil_Click(object sender, RoutedEventArgs e)
        {

            int siraNo = listbox1.SelectedIndex;

            if (siraNo > -1)

            {

                listbox1.Items.RemoveAt(siraNo);

                MessageBox.Show("Sevgili öğrencimiz çıkışınız olmuştur :) ", "UYARI", MessageBoxButton.OK, MessageBoxImage.Information);


            }


            else
            {

                MessageBox.Show("Önce çıkarılacak elemanı seçiniz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);


            }

        }

        private void ad_TextChanged(object sender, TextChangedEventArgs e)
        {
            int u = ad.Text.Length;
            if (u == 15)
            {
                MessageBox.Show("Maksimum sınıra ulaştınız!", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void soyad_TextChanged(object sender, TextChangedEventArgs e)
        {
            int u = soyad.Text.Length;
            if (u == 15)
            {
                MessageBox.Show("Maksimum sınıra ulaştınız!","HATA",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tc_TextChanged(object sender, TextChangedEventArgs e)
        {
            int u = tc.Text.Length;
            if (u == 11)
            {
                MessageBox.Show("Maksimum sınıra ulaştınız!", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void guncelle_Click(object sender, RoutedEventArgs e)
        {


            Guncelle gn = new Guncelle();

            gn.ShowDialog();


        }
    }
    }
