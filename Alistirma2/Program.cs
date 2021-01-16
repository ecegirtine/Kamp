using System;

namespace Alistirma2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ders ders1 = new Ders();
            ders1.OgretmenAdi = "Ece";
            ders1.DersAdi = "Matematik";
            ders1.TiklanmaSayisi = "400";
            ders1.BegeniSayisi = "150";

            Ders ders2 = new Ders();
            ders2.OgretmenAdi = "Ayşe";
            ders2.DersAdi = "Fizik";
            ders2.TiklanmaSayisi = "250";
            ders2.BegeniSayisi = "80";


            Ders ders3 = new Ders();
            ders3.OgretmenAdi = "Emir";
            ders3.DersAdi = "Tarih";
            ders3.TiklanmaSayisi = "360";
            ders3.BegeniSayisi = "120";



            Ders ders4 = new Ders();
            ders4.OgretmenAdi = "Ahmet";
            ders4.DersAdi = "Türkçe";
            ders4.TiklanmaSayisi = "180";
            ders4.BegeniSayisi = "98";

            Ders[] dersler = new Ders[] {ders1,ders2,ders3,ders4 };
            foreach (var ders in dersler)
            {
                Console.WriteLine(ders.DersAdi + " : " + ders.OgretmenAdi + " : ");
            }


            class Ders
        {
            public string DersAdi { get; set; }
            public string OgretmenAdi { get; set; }
            public string TiklanmaSayisi { get; set; }
            public string BegeniSayisi { get; set; }
        }
            



        }
    }
}
