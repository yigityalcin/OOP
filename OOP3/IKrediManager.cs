using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager // böyle durumlarda kredimanagerı birden fazla kullandıgımız yerlerde,
                            // class olarak değil interface olarak tanımlarız.
                            // interface bizim şablon görevimizi görür
                            // okunurluğu arttırmak için interfaceleri I harfi ile başlatırız ki interface oldugunu anlayalım.
                            // KrediManager bir interface, ve interfaceler kuralları-
                            // içerir ve ilgili onu implemente eden classlar o kuralları kendilerine göre doldurmaları gerekir.

                            //IKrediManager sırf bizim için referans tutsun diye ve aynı zamanda tüm kredi tiplerinin uygulaması zorunlu halde olması istenen operasyonları tutsun diye bu interface'i oluşturuyoruz
                            //bir interface olusturdugumuzda o interfacein icindeki operasyonlar alternatif sistemler icin bir şablon ve buna ek olarak referans tutucu görevi görüyor.
    {                       //***Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.(void Hesapla())***
        void Hesapla();
        void BiseyYap();
        
    }
}
