using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual Customer
    class GercekMusteri:Musteri // classların iki temel özelliği 1. içerisinde özellikler(prop aşağıdaki gibi) tutar
                        // ya da 2. içerisinde operasyonlar tutar. İçerisinde ikisinden birini tutmak zorundadır,
                        //özellik sınıfında(Musteri,Urun,Customer,Employee,Personel bunlar varlıktır, entitydir.) operasyon tutmamalısın,
                        //operasyon sınıfında(müsteri ekleme) özellik tutmamalısın.
    {
       
        public string TcNo { get; set; } //TcNo, VergiNo gibi veriler int ile değil string ile yazılır
                                         //çünkü o verilerle matematiksel işlem yapmayız, üzerinde değişiklik yapmayız hep aynıdır.
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
