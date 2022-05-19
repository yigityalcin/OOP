using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Yigit ");
            isimler.Add("Kerem ");
            isimler.Add("Yvgriytee "); 
            isimler.Add("Yagız "); 
            isimler.Add("Yohanson ");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);

            }
        }
    }
}
