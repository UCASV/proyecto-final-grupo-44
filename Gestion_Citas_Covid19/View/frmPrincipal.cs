using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Citas_Covid19.View;
using Gestion_Citas_Covid19.ViewModels;

namespace Gestion_Citas_Covid19
{
    public partial class FrmPrincipal : Form
    {
        private void AbrFormInPanel(object Formhijo)
        {
            if (this.panel_WorkArea.Controls.Count > 0)
            {
                this.panel_WorkArea.Controls.RemoveAt(0);
            }

            Form fm = Formhijo as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel_WorkArea.Controls.Add(fm);
            this.panel_WorkArea.Tag = fm;
            fm.Show();

        }

        int cabin = 0;

        public FrmPrincipal(int idCabin)
        {
            InitializeComponent();
            AbrFormInPanel(new ShowAppointment());
            cabin = idCabin;
        }

        private void btn_ShowAppointment_Click(object sender, EventArgs e)
        {
            AbrFormInPanel(new ShowAppointment());
        }

        private void btn_AddAppointment_Click(object sender, EventArgs e)
        {
            AbrFormInPanel(new AddAppointment(cabin));
        }

        private void btn_SignOff_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Estas seguro que que quieres salir !", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    //frmLogin login = new frmLogin();
                    //login.Show();
                }
            }
            catch
            {
                throw;
            }
        }

        private void btn_HideSidebar_Click(object sender, EventArgs e)
        {
            //Sidebar.Width = 49;
            if (Sidebar.Width == 40)
            {
                Sidebar.Width = 179;
            }
            else
            {
                Sidebar.Width = 40;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_PersonnelInformation_Click(object sender, EventArgs e)
        {
            AbrFormInPanel(new frmInfoP());

        }

        private void btn_CabinInformation_Click(object sender, EventArgs e)
        {
            AbrFormInPanel(new frmInfoC());
        }
    }
}



