using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOdemeYontem
{
    class Program
    {
        static void Main(string[] args)
        {

            KrediKartiOdeme kredikartiileOde = new KrediKartiOdeme();
            KapidaOdeme kapidapdeme = new KapidaOdeme();
            FastPayOdeme fastpayodeme = new FastPayOdeme();

            List<KeyValuePair<byte, IOdeme>> odemeTuruListesi = new List<KeyValuePair<byte, IOdeme>>()
            {
                new KeyValuePair<byte,IOdeme>(1,kredikartiileOde),
                new KeyValuePair<byte,IOdeme>(2,kapidapdeme),
                new KeyValuePair<byte,IOdeme>(3,fastpayodeme)
            };

            foreach (var item in odemeTuruListesi)

            {
                item.Value.odemeSekliAyariYap();
            }
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:

                 kredikartiileOde.OdemeTutariniKullanicidanAl();
                    break;

                case 2:
                    kapidapdeme.OdemeTutariniKullanicidanAl();
                    break;
                case 3:
                    fastpayodeme.OdemeTutariniKullanicidanAl();
                    break;
                default:
                    Console.WriteLine("Hatalı Giriş Yaptınız!!");
                    break;
            }

            Console.ReadKey();

        }
    }
}
