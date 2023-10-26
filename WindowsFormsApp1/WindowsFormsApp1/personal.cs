using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class personal
    {
        string ad;
        public string Ad
        {
            get => ad;
            set => ad = value;

        }
        string adres;

        public string Adres
        {
            get => adres;
            set => adres = value;

        }
        int yas;
        public int Yas
        {
            get => yas;
            set => yas = value;
        }
        int mesaı;
        public int Mesaı
        {
            get => mesaı; 
            set => mesaı = value;
        }
           
           string unvan;
        public string Unvan
        {
            get => unvan;
            set => unvan = value;
        }
        public personal (string gAd,  string gAdres, int gYas, int gMesaı, string gUnvan)
        {
            this.Ad = gAd;
            this.Adres = gAdres;
            this.Yas = gYas;
            this.Mesaı = gMesaı;
            this.Unvan = gUnvan;
        }
        public int ucrethesapla()
        { return this.Mesaı * 100;


        }

        public void ucrethesapla(int ekUcret)
        {
            int odenecek = this.Mesaı * 100 + ekUcret;
            MessageBox.Show(odenecek.ToString());
        }
    }
    
}
