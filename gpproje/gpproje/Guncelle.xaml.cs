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
    /// <summary>
    /// Guncelle.xaml etkileşim mantığı
    /// </summary>
    public partial class Guncelle : Window
    {
        public Guncelle()
        {
            InitializeComponent();
            List<Ogrenciler> Kayit = new List<Ogrenciler>();
            Kayit.Add(new Ogrenciler() { ID = 1, Adı = "Elvan", Soyadı = "Ekilsin", Alis = new DateTime(2022, 7, 23), Telefon = 05455645});
            Kayit.Add(new Ogrenciler() { ID = 2, Adı = "Ecrin", Soyadı = "Elif", Alis = new DateTime(2022, 1, 17), Telefon = 05445454});
            Kayit.Add(new Ogrenciler() { ID = 3, Adı = "Yusuf", Soyadı = "Arslan", Alis = new DateTime(2022, 11, 20), Telefon = 05446454});
            Kayit.Add(new Ogrenciler() { ID = 4, Adı = "Nazlı", Soyadı = "Akış", Alis = new DateTime(2022, 1, 17), Telefon = 05454534});
          

            KayitliOgr.ItemsSource = Kayit;
        }

        public class Ogrenciler
        {
            public int ID { get; set; }

            public string Adı { get; set; }

            public string Soyadı { get; set; }

            public string mail { get; set; }

            public int Telefon { get; set; }

            public DateTime Alis { get; set; }

            public DateTime Teslim { get; set; }

        }
    }
}
