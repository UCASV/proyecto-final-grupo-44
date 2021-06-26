using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Citas_Covid19
{
    public partial class FrmCabinChoice : Form
    {
        public FrmCabinChoice()
        {
            InitializeComponent();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnToContinue_Click(object sender, EventArgs e)
        {
            if (radCabin1.Checked == false && radCabin2.Checked == false && radCabin3.Checked == false &&
                radCabin4.Checked == false && radCabin5.Checked == false && radCabin6.Checked == false &&
                radCabin7.Checked == false && radCabin8.Checked == false && radCabin9.Checked == false && 
                radCabin10.Checked == false)
            {
                MessageBox.Show("¡Debe elegir una cabina!", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
