using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLOKWIUM_II
{
    class Miasto_2 : Miasto
    {
        private double powierzchnia;
        public double Powierzchnia
        {
            get { return powierzchnia; }
            set
            {
                if (value < 0)
                    powierzchnia = 0;
                else
                    powierzchnia = value;
            }
        }

        public Miasto_2(string _rodzaj, int _liczbaMieszkancow, double _powierzchnia) 
            : base(_rodzaj, _liczbaMieszkancow)
        {
            Powierzchnia = _powierzchnia;
        }
        public Miasto_2()
        {

        }
        
    }
}
