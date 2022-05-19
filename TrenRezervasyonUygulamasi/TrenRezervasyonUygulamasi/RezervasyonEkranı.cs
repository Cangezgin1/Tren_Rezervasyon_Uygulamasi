using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrenRezervasyonUygulamasi
{
    public partial class RezervasyonEkranı : Form
    {

        #region Ekran Tasarımı


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public RezervasyonEkranı()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        #endregion

        #region Vagon Arrayleri


        string[] vagonBir = new string[100];

        string[] vagonİki = new string[80];

        string[] vagonÜç = new string[60];


        #endregion


        private void RezervasyonEkranı_Load(object sender, EventArgs e)
        {

            // Vagonların test amaçlı for döngüsü ile belli sayıda müşteri eklendi. 

            for (int i = 1; i <= 67; i++)
            {
                vagonBir[i] = "Mustafa Yıldız"; // Vagon kapasitesi 100 ve 67 kişi randevu almış.
            }

            for (int i = 1; i <= 46; i++)
            {
                vagonİki[i] = "Muhammed Can Gezgin"; // Vagon kapasitesi 80 ve 46 kişi randevu almış.
            }

            for (int i = 1; i <= 58; i++)
            {
                vagonÜç[i] = "Ahmet Çeken"; // Vagon kapasitesi 60 ve 58 kişi randevu almış.
            }
        }

        private void RezervasyonBtn_Click(object sender, EventArgs e)
        {
            string AdSoyad = AdSoyadtxt.Text;
            byte KisiSayısı = Convert.ToByte(KisiSayısıComboBox.Text);
            
            // Farklı vagonlar değil de sadece tek bir vagon için olan kısım
            if (FarklıVagonComboBox.Text == "Hayır")
            {
                switch (VagonNoComboBox.Text)
                {
                    case "1": // 1. Vagon için
                        {
                            for (int i = 68; i < (68 + KisiSayısı); i++)
                                vagonBir[i] = AdSoyad;
                            break;
                        }
                    case "2": // 2. Vagon için
                        {
                            for (int i = 47; i < (47 + KisiSayısı); i++)
                                vagonİki[i] = AdSoyad;
                            break;
                        }
                    case "3": // 2. Vagon için, burada kontrol yapılıyor kapasiteyi aşarsa uyarı veriliyor.
                        {
                            if (58 + KisiSayısı > 60)
                            {
                                MessageBox.Show("Üzgünüz vagonda yeterli sayıda yer kalmadı." +
                                    "Lütfen farklı bir vagon seçiniz.");
                            }
                            else
                            {
                                for (int i = 59; i < (59 + KisiSayısı); i++)
                                    vagonÜç[i] = AdSoyad;
                            }
                            break;
                        }
                }
            } 

            // Vagonlarda doluluk olduğu taktirde farklı vagonlara yönlendirme yapılan kısım
            else
            {
                // Kişi sayısı 1 ise direk eklemeler yapılıyor.
                if (KisiSayısı == 1)
                {
                    if (VagonNoComboBox.Text == "1")
                        vagonBir[69] = AdSoyad;

                    else if (VagonNoComboBox.Text == "2")
                        vagonİki[47]= AdSoyad;

                    else
                        vagonÜç[59] = AdSoyad;
                }

                // Kişi sayısı 2 ise direk eklemeler yapılıyor çünkü en az kapasite olan vagonda bile 2 kişilik yer var.
                else if (KisiSayısı== 2)
                {
                    if (VagonNoComboBox.Text == "1")
                    {
                        for (int i = 68; i < (68 + KisiSayısı); i++)
                            vagonBir[i] = AdSoyad;
                    }
                    else if (VagonNoComboBox.Text == "2")
                    {
                        for (int i = 47; i < (47 + KisiSayısı); i++)
                            vagonİki[i] = AdSoyad;
                    }
                    else
                    {
                        for (int i = 59; i < (59 + KisiSayısı); i++)
                            vagonÜç[i] = AdSoyad;
                    }
                }

                // Kişi sayısı 3 ise ve vagonÜç seçilmiş ise 2 kişi vagonÜç'e kalan 1 kişiyi ise vagonBir'e gönderiliyor.
                else if (KisiSayısı==3)
                {
                    if (VagonNoComboBox.Text=="3")
                    {
                        MessageBox.Show("Üzgünüz vagonÜç'te sadece 2 kişilik yerimiz kalmıştır." +
                            "Kalan 1 kişilik yeriniz vagonBir'den ayrılmıştır.");
                        vagonÜç[59] = AdSoyad;
                        vagonÜç[60] = AdSoyad;
                        vagonBir[69] = AdSoyad;
                    }
                    else if (VagonNoComboBox.Text=="1")
                    {
                        for (int i = 68; i < (68 + KisiSayısı); i++)
                            vagonBir[i] = AdSoyad;
                    }
                    else
                    {
                        for (int i = 47; i < (47 + KisiSayısı); i++)
                            vagonİki[i] = AdSoyad;
                    }
                }
            } 
        }
        //................İncelediğiniz için teşekkürler, Junior seviyesinde olduğum için elimden bu kadarı geldi.
        //................Tabi ki zaman geçtikçe düzenlemelerim olacaktır, tekrardan teşekkürler iyi çalışmalar :))))
    }
}
