using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager // böyle durumlarda kredimanagerı birden fazla kullandıgımız yerlerde,
                            // class olarak değil interface olarak tanımlarız
                            // interface bizim şablon görevimizi görür
                            // okunurluğu arttırmak için interfaceleri I harfi ile başlatırız ki interface oldugunu anlayalım.
                            // KrediManager bir interface, ve interfaceler kuralları
                            // içerir ve ilgili onu implemente eden classlar o kuralları kendilerine göre doldurmaları gerekir.
    {
        void Hesapla();
        void BiseyYap();
        
    }
}
