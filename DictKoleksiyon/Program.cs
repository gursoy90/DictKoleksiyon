using System;
using System.Collections.Generic;

namespace DictKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sozluk = new Dictionary<int, string>();

            sozluk.Add(1990, "Ramazan");
            sozluk.Add(1992, "Özge");
            sozluk.Add(2020, "Aslan");
            int dtarih = int.Parse(Console.ReadLine());

            Console.WriteLine(sozluk[dtarih]);

            Dictint<int, string> sozluk1 = new Dictint<int, string>();
            sozluk1.Add(1990, "Ramazan");

            




        }
    }
}
