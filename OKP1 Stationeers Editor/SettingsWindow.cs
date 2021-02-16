using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKP1_Stationeers_Editor
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        public int DefaultAddQuantity { get { return (int)numericDefaultAddQuantity.Value; } set { numericDefaultAddQuantity.Value = value; } }
        public int TopUpQuantity { get { return (int)numericToppingUp.Value; } set { numericToppingUp.Value = value; } }

        private void Reagents_ValueChanged(object sender, EventArgs e)
        {
            lIngotSizeNote.Visible = (numericDefaultAddQuantity.Value > 500 || numericToppingUp.Value > 500);
        }
    }
}
