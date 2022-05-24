﻿using System;

namespace OOP2 //abstraction yani soyutlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yiğit Yalçın - Hatalı kullanım 👇
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Yiğit";
            musteri1.Soyadi = "Yalçın";
            musteri1.TcNo = "12345678910";
            

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "112233";

            //Gerçek Müşteri (Bireysel) - Tüzel Müşteri(Kurumsal)
            //ikiside müşteri fakat farklı müşteriler asla birbirleri yerine kullanılamazlar.
            //SOLID(L)

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
        }
    }
}
