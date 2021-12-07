using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOdemeYontem
{
    public class Odeme
    {
        public decimal odenecekTutar { get; set; }

        public void OdemeTutariniKullanicidanAl()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Ödenecek Tutarı Giriniz:");
            odenecekTutar = Convert.ToDecimal(Console.ReadLine());
        }




    }
}
