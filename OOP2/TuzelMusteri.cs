using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{ 
    //Coorporate Customer or Legal Entity 
    class TuzelMusteri:Musteri // Bu olaya (:Musteri) miras yani inheritance denir.//Tüzel müşteri bir müşteridir. demektir bu bu kod :Musteri
    {
        
        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }
    }
}
