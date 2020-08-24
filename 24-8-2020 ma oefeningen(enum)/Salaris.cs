using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_8_2020_ma_oefeningen_enum_
{
    public class Salaris
    { 
        public bool MaandWeekContract { get; set; }
        public double BrutoLoon { get; set; }
        public int Percent { get; set; }

        public Salaris(bool maandWeekContract = true, double brutoLoon = 2440.55, int percent =21)
        {
            MaandWeekContract = maandWeekContract; /*maandWeekContract is true weekcontract is false*/
            BrutoLoon = brutoLoon;
            Percent = percent;
        }
        public double BerekenNetto()
        {
            return Math.Round(BrutoLoon - (BrutoLoon / 100 * Percent),2);
        }
        public override string ToString()
        {
            return $"uw nettoloon is €{BerekenNetto()} en uw brutoloon is €{BrutoLoon} uw btw was {Percent}%";
        }
    }
}
