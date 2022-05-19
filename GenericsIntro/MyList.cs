using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor block, Class oluştuğu an otomatik çalışır. İsimlerinin aynı olmasından da anlayabiliriz. Consturction aslında bir methoddur ()'lerden anladık.
        public MyList()
        {
            items = new T[0]; // ilk etapta constructor bloğunda 0 elemanlı 1 array oluşturduk
        }
       
        //genel mantık anlatımı ders 4 2:36:00
        public void Add(T item) 
        {
            T[] tempArray = items; //aşağıda her newlediğimizde önceki eleman silineceği için
                                   // ( çünkü referans tip bir öncekini hafızada tutmadan siliyor ) bu şekilde geçici dizi oluştururuz.
                                     
            items = new T[items.Length+1]; //Daha sonra 0 elemanlı dizimize eleman eklemek için newledik
                                           //ve birbir arttırdık bu şekilde (Mevcut eleman sayın kaçsa 1 arttır (items.length+1) ).
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //Benim items'ımın i. elemanı = temparrayden gelen geçici olarak verdiğim i. elemandır. Yani emaneten verdiğimiz değerleri sırasıyla itemsa alıyoruz.
            }

            items[items.Length - 1] = item; // itemsın son elemanı (items.lenght-1(-1 index 0dan başladığı için verilir.) = items yani aslında eklenmek istenen elemanın şu an eklenmesi)
        }
        public int Length 
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}