using System;
using System.Collections.Generic;
using System.Text;

namespace DictKoleksiyon
{
    class Dictint<TKey,TValue>
    {
        TKey[] anahtar;
        TValue[] deger;
        TKey[] tempanahtar;
        TValue[] tempdeger;
        public Dictint()
        {
            anahtar = new TKey[0];
            deger = new TValue[0];

        }

        public void Add(TKey sayi,TValue yazi)
        {
            tempanahtar = anahtar;
            tempdeger = deger;
            anahtar = new TKey[anahtar.Length + 1];
            deger = new TValue[deger.Length + 1];

            for (int i = 0; i < tempanahtar.Length; i++)
            {
                anahtar[i] = tempanahtar[i];
                deger[i] = tempdeger[i];
            }
            
            anahtar[anahtar.Length - 1] = sayi;
            deger[deger.Length - 1] = yazi;
        }

    }
}
