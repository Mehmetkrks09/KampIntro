using System;
using System.Collections.Generic;
using System.Text;

namespace _23._0._2021_ödev
{
    class MyDictionary<T>
    {
        T[] Key;
        T[] Value;
   
        public MyDictionary()
        {
            Key = new T[0];
            
            Value = new T[0];
          
        }
        public void Add(T item, T item1)
        {
            T[] Tkey = Key;
            T[] TValue = Value;
            Key = new T[Key.Length + 1];
            Value = new T[Value.Length + 1];
            for (int i = 0; i < Tkey.Length; i++)
            {
                Key[i] = Tkey[i];
                Value[i] = TValue[i];
            }
            Key[Key.Length - 1] = item;
            Value[Value.Length - 1] = item1;
           
            

        }
        public int length
        {
            get { return Key.Length ; }

        }
    }
}
