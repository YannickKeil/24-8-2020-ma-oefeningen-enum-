using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_8_2020_ma_oefeningen_enum_
{
    public enum LandVanHerkomst
    {
        België,
        Nederland,
        Duitsland,
        Luxemburg
    }
    public class Werknemer
    {
        public string Naam { get; set; }
        //public double Salaris { get; set; }
        public LandVanHerkomst Land { get; set; }
        public List<Salaris>Loon { get; set; }
        public Werknemer(string naam,/* double salaris = 2440.55,*/ LandVanHerkomst land = LandVanHerkomst.België)
        {
            Naam = naam;
            //Salaris = salaris;
            Land = land;
            Loon = new List<Salaris>();

        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
