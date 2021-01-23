using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    //Individual
    //Burada müşteri ebeveyndir. Gerçek müşteri ise çocuktur.
    class GercekMusteri:Musteri //İnheritance -> miras
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
