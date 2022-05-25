using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // instance oluşturduk.
            ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            //Interfaceler de o interfacei implemente eden classın referans numarasını tutabilir.
        }
    }
}
