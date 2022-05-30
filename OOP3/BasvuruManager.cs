using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)//böyle yaptığımızda ise tüm kredi türlerini içerir.
        {
            //Başvuran bilgilerini değerlendirme
            //

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); 
            //!!! BÖYLE YAPTIĞIMIZ ZAMAN 👆
            //TÜM BAŞVURANLAR KONUT KREDİSİ ÜZERİNDEN HESAPLANIR Kİ BUNU İSTEMEYİZ.

            //onun yerine sadece şu kullanım doğrudur👇
            krediManager.Hesapla();
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
