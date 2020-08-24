using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_8_2020_ma_oefeningen_enum_
{
    public class Bedrijf
    {
        public string Naam { get; set; }
        public List<Werknemer> Werknemers { get; set; }
        public string BTWNummer { get; set; }

        public Bedrijf(string naam, string bTWNummer)
        {
            Naam = naam;
            Werknemers = new List<Werknemer>();
            BTWNummer = bTWNummer;
        }
        public void VoegToe()
        {
            WerknemerToevoegen werknemerToevoegen = new WerknemerToevoegen();
            if (werknemerToevoegen.ShowDialog() == DialogResult.OK)
            {
                Werknemer newWerknemer = new Werknemer(werknemerToevoegen.naam, werknemerToevoegen.newland);
                Salaris newSalaris = new Salaris(werknemerToevoegen.MaandContract, werknemerToevoegen.BrutoLoon, werknemerToevoegen.percent);
                newWerknemer.Loon.Add(newSalaris);
                Werknemers.Add(newWerknemer);
            }

        }
        public void Verwijder(int index)
        {
            Werknemers.RemoveAt(index);
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
