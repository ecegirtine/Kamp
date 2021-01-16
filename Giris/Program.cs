using System;

namespace Giris
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategoriler";
            int OgrenciSayisi = 3200;
            double FaizOrani = 1.45;
            bool SistemeGirisYapmisMi = true;
            double DolarDun = 8.45;
            double DolarBugun = 8.55;

            if (DolarBugun>DolarDun)
            {
                Console.WriteLine("Artış oku");
            }

            else if (DolarBugun<DolarDun)
            {
                Console.WriteLine("Azalış oku");
            }

            else
            {
                Console.WriteLine("Değişmedi oku");
            }

            if (SistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine("Giriş yapma butonu");
            }
        }
    }
}
