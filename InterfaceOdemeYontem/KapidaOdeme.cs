using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOdemeYontem 
{
    public class KapidaOdeme :Odeme, IOdeme
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string tc { get; set; }
        public string adres { get; set; }
        public string kuryeBilgisi { get; set; }

        public void odemeSekliAyariYap()
        {
            Console.WriteLine("Kapıda Ödeme şekli-2");
        }

        public void odemeYap()
        {
            Console.WriteLine("TEslimatı yapan Kurye ad soyad: ");
            kuryeBilgisi = Console.ReadLine();
            Console.WriteLine("Hasarsız mı?");

            if (Console.ReadKey().Key==ConsoleKey.E)
            {
                Console.WriteLine("Başarılı...");
            }
            else
            {
                Console.WriteLine("Bşarısız...0");
            }
        }
    }
}
