using System;

namespace _23._0._2021_ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclass<string> kelimeler = new Myclass<string>();
            MyDictionary<string> Sayılar = new MyDictionary<string>();
            kelimeler.Add("Mehmet");
            Sayılar.Add("203221012", "Mehmet_Karakas");

            Console.WriteLine(kelimeler.length+"bu son yapılan");
            Console.WriteLine(Sayılar.length + "en önceki");
            
        }
    }
}
