using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InterfaceOdemeYontem
{
    public class FastPayOdeme :Odeme, IOdeme
    {

        public string  eposta { get; set; }
        public string  sifre { get; set; }


     



        public void odemeSekliAyariYap()
        {
            Console.WriteLine("FastPay Ödeme şekli-3");
        }

        public void odemeYap()
        {
            Console.WriteLine("Email adresi giriniz:");
            eposta = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz");
            sifre = Console.ReadLine();


            Random rnd = new Random();
            int bekleme = rnd.Next(300, 500);
            Console.WriteLine(bekleme);
            for (int i = 0; i < bekleme; i++)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(i+"...");
                Thread.Sleep(bekleme);
            }
            Console.WriteLine("Ödeme Alındı....");
        }
    }
}
