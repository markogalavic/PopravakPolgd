using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićPolugodišnji
{
   public class Osoba
    {
        private string ime;
        private string prezime;
        private float oib;
        private string spol;

        public override string ToString()
        {
            string ispis = ime + " " + prezime + " " + oib + " " + spol + "";
            return ispis;
        }
        string upis;

        public Osoba(string ime, string prezime, float oib, string spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.oib = oib;
            this.spol = spol;
        }
        public string getime()
        {
            return ime;
        }
        public void setime(string ime)
        {
            this.ime = ime;
        }
        public string getprezime()
        {
            return prezime;
        }
        public void setprezime(string prezime)
        {
            this.prezime = prezime;
        }
        public float getoib()
        {
            return oib;
        } 
        public void setoib(float oib)
        {
            this.oib = oib;
        }
        public string getspol()
        {
            return spol;
        }
        public void setspol(string spol)
        {
            this.spol = spol;
        }
    }
}
