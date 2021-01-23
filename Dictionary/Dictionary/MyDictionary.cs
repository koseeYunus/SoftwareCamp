using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T_Key, T_Value>
    {
        //Sözlüğümüzün anahtar ve değer tiplerimizi tanımlıyoruz.
        T_Key[] _Keys;
        T_Value[] _Values;

        //Yeni değer atadığımızda eski verilerimizi tutmak için T_Key ve T_Value dizilerimizi oluşturuyoruz.
        T_Key[] _TempKeys = new T_Key[0];
        T_Value[] _TempValues = new T_Value[0];

        //Sözlüğümüze heap'de yer ayarlandığında anahtar ve değer tiplerimiz içinde yer ayırıyoruz.
        public MyDictionary()
        {
            _Keys = new T_Key[0];
            _Values = new T_Value[0];
        }

        public void Add(T_Key key, T_Value value)
        {
            //Yeni değer eklemeden önce eski değereleri temp array'lere atama işlemini yapıyoruz.
            _TempKeys = _Keys;
            _TempValues = _Values;

            //Yeni değer atanacağından dolayı dizinin alanını 1 arttırıyoruz.
            _Keys = new T_Key[_Keys.Length + 1];
            _Values = new T_Value[_Values.Length + 1];

            //Eski dizimizdeki değerleri yeni keys ve values dizilerimize alıyoruz.
            for (int i = 0; i < _TempKeys.Length; i++)
            {
                _Keys[i] = _TempKeys[i];
                _Values[i] = _TempValues[i];
            }

            //Ve son olarak yeni eklenecek elemanlarımızı dizimizin sonuna ekliyoruz.
            _Keys[_Keys.Length - 1] = key;
            _Values[_Values.Length - 1] = value;
        }

        public void Delete(T_Key key, T_Value value)
        {
            //Yeni değer eklemeden önce eski değereleri temp array'lere atama işlemini yapıyoruz.
            _TempKeys = _Keys;
            _TempValues = _Values;
            
            Boolean durum = false;
            int index = 0;

            //Key ve Value değerlerini dizimizde arıyoruz.
            for (int i = 0; i < _TempKeys.Length; i++)
            {
                if(_TempKeys[i].Equals(key) && _TempValues[i].Equals(value))
                {
                    //Var ise elemanı silmek için "durum" değişkeşkenini true ve elemanın dizede bulunduğu index'i alıyoruz.
                    durum = true;
                    index = i;
                }               
            }

            if (durum)
            {                
                //Aranan değer silineceğinden dolayı dizinin boyutu 1 düşürülüyor.
                _Keys = new T_Key[_Keys.Length - 1];
                _Values = new T_Value[_Values.Length - 1];

                //Silinecek eleman arar iken yeni değerler ataması yapılıyor.
                for (int i = 0; i < _Keys.Length; i++)
                {
                    //Silinecek elemanın olup olmadığı kontrol ediliyor
                    if (index==i)
                    {
                        //Aranan eleman bulundu ise sondaki elemanı silinecek elemanın yerine yaz.
                        _Keys[i] = _TempKeys[_TempKeys.Length - 1];
                        _Values[i] = _TempValues[_TempValues.Length - 1];
                    }
                    else
                    {
                        _Keys[i] = _TempKeys[i];
                        _Values[i] = _TempValues[i];
                    }

                }
            }
            else
            {
                Console.WriteLine("Aranan eleman bulunamadı.");
            }
        }

        //Sözlüğümüzdeki verileri yazdırma işlemini yapıyoruz.
        public void WriteData()
        {
            for (int i = 0; i < _Keys.Length; i++)
            {
                Console.WriteLine("Anahtar = "+_Keys[i]+", Değer = "+_Values[i]);
            }
        }
    }
}
