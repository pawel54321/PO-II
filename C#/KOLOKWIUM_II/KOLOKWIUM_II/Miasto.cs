using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLOKWIUM_II
{
    class Miasto 
    {

        public Miasto (string _rodzaj, int _liczbaMieszkancow)
        {
            Rodzaj = _rodzaj;
            LiczbaMieszkancow = _liczbaMieszkancow;
        }
        public Miasto()
        {

        }

        private string rodzaj;
        public string Rodzaj
        {
            get { return rodzaj; }
            set
            {
             if (value == "male")
                    rodzaj = "male";
             else if (value == "srednie")
                    rodzaj = "srednie";
             else if (value == "duze")
                    rodzaj = "duze";
             else
                    return;
            }
        }


        private int liczbaMieszkancow;
        public int LiczbaMieszkancow
        {
            get { return liczbaMieszkancow; }
            set
            {
                if (value < 0)
                    liczbaMieszkancow = 0;
                else
                    liczbaMieszkancow = value;
            }
        }


    }
}
