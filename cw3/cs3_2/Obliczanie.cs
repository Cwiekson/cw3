using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs3_2
{
     public class Obliczanie
    {
        public double wynik;
        public double a;
        public double b;

        public  double Dodowanie(double a,double b)
        {
           return wynik = a + b;
        }
        public  double Odejmowanie(double a, double b)
        {
            return wynik = a - b;
        }
        public double Mnozenie(double a, double b)
        {
           return wynik = a * b;
        }
        public  double Dzielenie(double a, double b)
        {
            try
            {
                wynik = a / b;
            }
            
            catch
            {
                Console.WriteLine("NIe mozna dzielic przez 0");
                
            }
            return wynik;
        }
        public double POtegowanie(double a,double b)
        {
            return wynik = Math.Pow(a, b);
        }
        public  double Pierwiastkowanie(double a)
        {
            return wynik = Math.Sqrt(a);
        }

    }
}
