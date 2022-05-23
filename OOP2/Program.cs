using System;

namespace OOP2 //abstraction yani soyutlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yiğit Yalçın - Hatalı kullanım 👇
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Yalçın";
            musteri1.Id = 1;
            musteri1.TcNo = "11111111111";
            musteri1.MusteriNo = "12345";
            musteri1.SirketAdi = "?";

            //Gerçek Müşteri (Bireysel) - Tüzel Müşteri(Kurumsal)
            //ikiside müşteri fakat farklı müşteriler asla birbirleri yerine kullanılamazlar.
            //SOLID(L)
        }
    }
}
