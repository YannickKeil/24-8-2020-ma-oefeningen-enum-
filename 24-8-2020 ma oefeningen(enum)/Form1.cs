using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_8_2020_ma_oefeningen_enum_
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
        }
        public List<Werknemer> werknemers = new List<Werknemer>();
        public void Form1_Load(object sender, EventArgs e)
        {
            Werknemer werknemer1 = new Werknemer("Geert");
            Werknemer werknemer2 = new Werknemer("Frank", salaris: 2200.00);
            Werknemer werknemer3 = new Werknemer("Daniel", land:LandVanHerkomst.Nederland) ;
            Werknemer werknemer4 = new Werknemer("Sofia",3110.00,LandVanHerkomst.Nederland);          
            werknemers.Add(werknemer1);
            werknemers.Add(werknemer2);
            werknemers.Add(werknemer3);
            werknemers.Add(werknemer4);
            LoadComboBox();
            cbWerknemers.SelectedIndex = 0;
        }
        private void cbWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lSalaris.Text = $"salaris = €{werknemers[cbWerknemers.SelectedIndex].Salaris}";
            lLandVanHerkomst.Text = $"Land van herkomst = {werknemers[cbWerknemers.SelectedIndex].Land}";
        }
        public void LoadComboBox() 
        {
            foreach (var item in werknemers)
            {
                cbWerknemers.Items.Add(item.Naam);
            }
        }


    }
}
