using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)// ben bu methodu aynı zamanda loglamak istiyorum "ILoggerService loggerService"
            //böyle yaptığımızda ise tüm kredi türlerini içerir.
            //birden fazla logger yollamak istiyorsak List<> şeklinde yaparız.
            //Birden fazla yolladığımız için listeyi foreach ile yazarız
        {
            //Başvuran bilgilerini değerlendirme
            //

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); 
            //!!! BÖYLE YAPTIĞIMIZ ZAMAN 👆
            //TÜM BAŞVURANLAR KONUT KREDİSİ ÜZERİNDEN HESAPLANIR Kİ BUNU İSTEMEYİZ.

            //onun yerine sadece şu kullanım doğrudur👇
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            //loggerService.Log();//hangi loglayıcı seçilmişse sistemde onu logla
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        // liste oldugu icin 0 tanede olabilir 100 tanede olabilir 👆
        //bu noktada diyoruzki bana bir liste ver türü IKrediManager olsun 👆                                                                
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
