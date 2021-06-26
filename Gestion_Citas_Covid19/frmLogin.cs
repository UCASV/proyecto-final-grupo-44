using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Citas_Covid19
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtHide.Enabled = true;
            txtUser.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtHide.Text == "Usuario")
            {
                txtHide.Text = "";
                txtHide.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtHide.Text == "")
            {
                txtHide.Text = "Usuario";
                txtHide.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void ptbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnToAccess_Click(object sender, EventArgs e)
        {
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
        }


        private void txtUser_Enter_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }
    }
}
