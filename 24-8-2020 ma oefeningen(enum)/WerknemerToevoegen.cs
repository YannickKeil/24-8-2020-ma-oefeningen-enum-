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
    public partial class WerknemerToevoegen : Form
    {
        public WerknemerToevoegen()
        {
            InitializeComponent();
        }
        
        private void WerknemerToevoegen_Load(object sender, EventArgs e)
        {        
            cbLandVanHerkomst.DataSource = Enum.GetValues(typeof(LandVanHerkomst));
            cbLandVanHerkomst.SelectedIndex = 0;
            nudBrutoSalaris.Value = Convert.ToDecimal( 2440.55);
            nudPercent.Value = 21;
        }
        public string naam;
        public LandVanHerkomst newland;
        public bool MaandContract;
        public double BrutoLoon;
        public int percent;
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            naam = tbNaam.Text;
            newland = (LandVanHerkomst)cbLandVanHerkomst.SelectedItem;
            if (rbMaandContract.Checked)
            {
                MaandContract = true;
            }
            else
            {
                MaandContract = false;
            }
            BrutoLoon = Convert.ToDouble(nudBrutoSalaris.Value);
            percent = Convert.ToInt32(nudPercent.Value);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
