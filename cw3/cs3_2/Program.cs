using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] table = new int[2];
            //try
            //{
            //    table[25] = 2;
            //    throw new IndexOutOfRangeException();

            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch
            //{
            //    Console.WriteLine("Blad");
            //}
            //Console.ReadKey();
           Obliczanie wynik1 = new Obliczanie();
            wynik1.a = 4.0;
            wynik1.b = 2.0;

            

            Console.WriteLine(wynik1.Pierwiastkowanie(wynik1.a));
            Console.ReadKey();
        }
    }
}
