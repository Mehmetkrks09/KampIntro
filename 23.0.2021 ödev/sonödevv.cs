using System;
using System.Collections.Generic;
using System.Text;

namespace _23._0._2021_ödev
{
    class Myclass<T>
    {
        T[] items;
     
        public Myclass()
        {
            items = new T[0];
            
        }
        public void Add(T item)
        {
            T[] Titems = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < Titems.Length; i++)
            {
                items[i] = Titems[i];
            }
            items[items.Length - 1] = item;


        }
        public int length
        {
            get { return items.Length; }
        }
    }
}