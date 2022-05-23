using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual Customer
    class GercekMusteri // classların iki temel özelliği 1. içerisinde özellikler(prop aşağıdaki gibi) tutar ya da 2. içerisinde operasyonlar tutar.
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string TcNo { get; set; } //TcNo, VergiNo gibi veriler int ile değil string ile yazılır
                                         //çünkü o verilerle matematiksel işlem yapmayız, üzerinde değişiklik yapmayız hep aynıdır.
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
