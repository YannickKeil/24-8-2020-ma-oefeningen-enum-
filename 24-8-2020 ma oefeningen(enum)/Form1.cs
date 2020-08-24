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
        List<Bedrijf> bedrijven = new List<Bedrijf>();
        public List<Werknemer> werknemers = new List<Werknemer>();
        Bedrijf bedrijf1 = new Bedrijf("MediaMarkt", "BE 0477.104.426");
        Bedrijf bedrijf2 = new Bedrijf("GameMania", "BE 0451.190.253");
        Salaris loon1 = new Salaris(false);     
        Werknemer werknemer1 = new Werknemer("Geert");        
        Salaris loon2 = new Salaris(brutoLoon: 2200.00);
        Werknemer werknemer2 = new Werknemer("Frank"/*, salaris: 2200.00*/);
        Salaris loon3 = new Salaris(false);
        Werknemer werknemer3 = new Werknemer("Daniel",/* land: */LandVanHerkomst.Nederland);
        Salaris loon4 = new Salaris(brutoLoon: 3110.00);
        Werknemer werknemer4 = new Werknemer("Sofia",/* 3110.00,*/ LandVanHerkomst.Nederland);
        public void Form1_Load(object sender, EventArgs e)
        {         
            werknemers.Add(werknemer1);
            werknemer1.Loon.Add(loon1);
            werknemers.Add(werknemer2);
            werknemer2.Loon.Add(loon2);
            werknemers.Add(werknemer3);
            werknemer3.Loon.Add(loon3);
            werknemers.Add(werknemer4);
            werknemer4.Loon.Add(loon4);
            bedrijven.Add(bedrijf1);
            bedrijven.Add(bedrijf2);
            bedrijf1.Werknemers.Add(werknemer1);
            bedrijf1.Werknemers.Add(werknemer3);
            bedrijf2.Werknemers.Add(werknemer2);
            bedrijf2.Werknemers.Add(werknemer4);
            LoadComboBox();
            cbWerknemers.SelectedIndex = 0;
            cbBedrijf.SelectedIndex = 0;


        }
        private void cbWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Werknemer selected = (Werknemer)cbWerknemers.SelectedItem;
            if (cbWerknemers.DataSource != null)
            {
                //lSalaris.Text = $"salaris = €{/*werknemers[cbWerknemers.SelectedIndex]*/selected.Loon[0].BrutoLoon}";
                lSalaris.Text = selected.Loon[0].ToString();
                lLandVanHerkomst.Text = $"Land van herkomst = {/*werknemers[cbWerknemers.SelectedIndex]*/selected.Land}";
                if (/*werknemers[cbWerknemers.SelectedIndex].Loon[0].MaandWeekContract*/ selected.Loon[0].MaandWeekContract)
                    rbMaandContract.Checked = true;
                else
                    rbWeekContract.Checked = true;
            }
            
        }
        private void LoadComboBox() 
        {
            cbBedrijf.DataSource = null;
            cbBedrijf.DataSource = bedrijven;
            LoadComboBoxWerkNemers();
        }
        private void LoadComboBoxWerkNemers()
        {
            //cbWerknemers.Items.Clear();
            //foreach (var item in werknemers)
            //{
            //    cbWerknemers.Items.Add(item.Naam);
            //}
            Bedrijf selected = (Bedrijf)cbBedrijf.SelectedItem;
            if (cbBedrijf.DataSource != null)
            {
                cbWerknemers.DataSource = null;
                cbWerknemers.DataSource = selected.Werknemers; /*->vergeet dan niet uw ToString to overide in Werknemers*/
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Bedrijf selected = (Bedrijf)cbBedrijf.SelectedItem;
            selected.VoegToe();
            LoadComboBox();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Bedrijf selected = (Bedrijf)cbBedrijf.SelectedItem;
            selected.Verwijder(cbWerknemers.SelectedIndex);
            LoadComboBox();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbBedrijf_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboBoxWerkNemers();
        }
    }
}
