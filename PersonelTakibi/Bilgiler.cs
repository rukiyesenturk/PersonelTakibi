using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakibi
{
    public class Bilgiler
    {
        public int hata =0;
        private string Tc;
        public string Tc1
        {
            get { return Tc; }
            set { 
                Tc = value;
                if (Tc.Length != 11)
                {
                    System.Windows.Forms.MessageBox.Show("Tc 11 harfli olmalıdır. ");
                    hata = 1;                
                }
            }
        }

        private string Ad;

        public string Ad1
        {
            get { return Ad; }
            set
            {
                Ad = value;
                Ad = Ad.Trim();
                Ad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Ad);

            }
        }
        private string Soyad;

        public string Soyad1
        {
            get { return Soyad; }
            set
            { 
                Soyad = value;
                Soyad = Soyad.Trim();
                Soyad = Soyad.ToUpper();
            }
        }

        private DateTime DogumTarihi;
        private int maxage = 30;
        private int minage = 22;
        public DateTime DogumTarihi1 
        {
            get { return DogumTarihi; }
            set
            {
                DogumTarihi = value;
                int age = DateTime.Now.Year - DogumTarihi.Year;
                if(age < minage || age > maxage)
                {
                    System.Windows.Forms.MessageBox.Show("Aranılan kriterlere uygun değilsiniz.");
                    hata = 1;
                }
            }
        }
        
        public string Telefon;
        public string Email;
        public string Adres;
        public DateTime İseBaslama;
        
        public string Unvan;
        public string ResimYolu;

        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Clear();
                }
                if (item is MaskedTextBox)
                {
                    MaskedTextBox t = (MaskedTextBox)item;
                    t.Clear();
                }
                if (item is DateTimePicker)
                {
                    DateTimePicker t = (DateTimePicker)item;
                    t.Value = DateTime.Now;
                }
            }
        }

    }
}
