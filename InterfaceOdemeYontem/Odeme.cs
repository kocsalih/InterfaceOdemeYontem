using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOdemeYontem
{
    public class Odeme : IOdeme
    {
        public decimal odenecekTutar { get; set; }

        public void odemeSekliAyariYap()
        {
            Console.WriteLine("Ödeme Yöntemi SEçiniz:\n1-FastPay\n2-Kapıda Ödeme\n3-Kredi Kartı");
        }

        public void OdemeTutariniKullanicidanAl()
        {
            Console.WriteLine("Ödenecek Tutarı Giriniz");
            odenecekTutar = Convert.ToDecimal(Console.ReadLine());

        }

        public void odemeYap()
        {
            
        }
    }
}
