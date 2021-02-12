using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<TKey,TValue> //dictionary hem anahtar,hem değerleri tutar
    {
        TKey[] keys;
        TValue[] values;

        public Dictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key ,TValue value)
        {
            TKey[] tempArray1 = keys;
            TValue[] temArray2 = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];
                values[i] = temArray2[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public void List()
        {
            for (int i = 0; i < keys. Length; i++)
            {
                Console.WriteLine(keys[i]+ " " + values[i]);
            }
        }
    }
}

