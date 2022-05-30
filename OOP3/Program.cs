using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // instance oluşturduk.
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //üstteki 3 kısım gerçek hayatta şubede çalışan arkadaşımızın ekranıdır.
            
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};
           
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            

            //Interfaceler de o interfacei implemente eden classın referans numarasını tutabilir.


        }
    }
}
