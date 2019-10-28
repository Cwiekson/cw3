using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1.0, "mercedes");
            Car car2 = new Car(2.5, "opel");
            Car.Create(2.5, "opel");


            Console.ReadKey();

        }
    }
}