using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Citas_Covid19.SqlServerContext;


namespace Gestion_Citas_Covid19
{
    public partial class FrmCabinChoice : Form
    {
        int managerId;

        public FrmCabinChoice(int employeeId)
        {
            InitializeComponent();
            managerId = employeeId;
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

            else
            {
                int id = 0;

                if (radCabin1.Checked == true)
                    id = 1;
                else if (radCabin2.Checked == true)
                    id = 2;
                else if (radCabin3.Checked == true)
                    id = 3;
                else if (radCabin4.Checked == true)
                    id = 4;
                else if (radCabin5.Checked == true)
                    id = 5;
                else if (radCabin6.Checked == true)
                    id = 6;
                else if (radCabin7.Checked == true)
                    id = 7;
                else if (radCabin8.Checked == true)
                    id = 8;
                else if (radCabin9.Checked == true)
                    id = 9;
                else if (radCabin10.Checked == true)
                    id = 10;

                DateTime loginDt = DateTime.Today; //Fix 

                using (SGCCDBContext dbList = new SGCCDBContext()) 
                {
                    CabinLogin record = new CabinLogin()
                    {
                        IdEmployee = this.managerId,
                        IdCabin = id,
                        DtLogin = loginDt,
                    };

                    dbList.CabinLogins.Add(record);
                    dbList.SaveChanges();
                }
            }


            /*
            //Add DBContext
            using (SGCCDBContext dbList = new SGCCDBContext())
            {
                string managerUser = txtUser.Text;
                string managerPassword = txtPassword.Text;

                var userList = dbList.Employees
                    .Where(x => x.ManagerUsername == managerUser && x.ManagerPassword == managerPassword)
                    .ToList();

                if (txtUser.Text == "Usuario" || txtPassword.Text == "Contraseña")
                {
                    MessageBox.Show("Debe llenar los campos: Usuario y Contraseña", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (userList.Count() == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Observación",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (userList.Count() == 1)
                {
                    FrmCabinChoice cabinChoice = new FrmCabinChoice();
                    this.Hide();
                    cabinChoice.ShowDialog();
                }
            }
            */

        }

        private void FrmCabinChoice_Load(object sender, EventArgs e)
        {

        }
    }
}
