using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InterfaceOdemeYontem
{
    public class KrediKartiOdeme : Odeme, IOdeme
    {


        public string kartSahibiAdi { get; set; }
        public string kartSahibiSoyadi { get; set; }
        public byte sonKullanimAy { get; set; }
        public int sonKullanimYil { get; set; }
        public short cvv { get; set; }

        private string _kartNumarasi;
        public string kartNumarasi
        {
            get
            {
                return _kartNumarasi;
            }
            set
            {
                char[] dizi = value.ToArray();
                bool rakamDegilmi = false;
                foreach (var item in dizi)
                {
                    if (!char.IsDigit(item))
                    {
                        rakamDegilmi = true;
                        break;

                    }

                }

                if (!rakamDegilmi&&value.Length==16)
                {
                    _kartNumarasi = value;

                }
                else
                {
                    throw new FormatException("Kart Numarsı Yanlış Girilmiştir!!!!");
                }
            }

        }

   

        public void odemeSekliAyariYap()
        {
            Console.WriteLine("Kredi Kartı Odeme-1");
        }

        public void odemeYap()
        {
            Console.WriteLine("Kart Sahibinin İsmi:");
            kartSahibiAdi = Console.ReadLine();

            Console.WriteLine("Kart Sahibinin Soyadi:");
            kartSahibiSoyadi = Console.ReadLine();

            Console.WriteLine("Kart Numarasi:");
            kartNumarasi = Console.ReadLine();

            Console.WriteLine("Kartınızın Son kullanın ay bilgisini giriniz:");
            sonKullanimAy = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Kartınızın yıl Bilgisi:");
            sonKullanimYil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kartınızın CVV Bilgisi:");
            cvv = Convert.ToInt16(Console.ReadLine());

            if (kartSahibiAdi.Length>0&&kartNumarasi.Length>0&&sonKullanimYil>0&&sonKullanimAy<13)
            {
                Console.Clear();
                Console.WriteLine($"sayin {kartSahibiAdi} {kartSahibiSoyadi} {odenecekTutar} tl ödeniyor.. Lütfen Bekleyiniz...");

                Random rd = new Random();
                int bekleme = rd.Next(3000, 5000);
                Console.WriteLine(bekleme);
                Console.WriteLine("Ödeme Alındı..");

            }
        }
    }
}
