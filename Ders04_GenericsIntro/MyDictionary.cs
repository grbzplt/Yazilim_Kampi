using System;
using System.Collections.Generic;
using System.Text;

namespace Ders04_GenericsIntro
{
    public class MyDictionary<T1, T2>
    {
        T1[] keys;
        T2[] values;

        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }

        public void Add(T1 key, T2 value)
        {
            T1[] tempKey = keys;
            T2[] tempValue = values;
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;

            values[values.Length - 1] = value;
        }

        public int Length
        {
            get { return keys.Length; }
        }

        public T1[] Keys
        {
            get { return keys; }
        }
        public T2[] Values
        {
            get { return values; }
        }
    }
}
