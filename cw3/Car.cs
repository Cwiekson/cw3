using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw3
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        static int iloscKol;
        Car()
        {

        }
        public Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }
        public static Car Create(double pojemnoscSilnika, string marka)
        {

            Car car = new Car(pojemnoscSilnika, marka);

            return car;
        }
        static Car() 
        {
            iloscKol = 4;

        }
        ~Car()
        {
            MessageBox.Show("Zwalniam pamiec");
        }
    }
}
