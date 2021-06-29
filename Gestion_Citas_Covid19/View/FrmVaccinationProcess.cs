using Gestion_Citas_Covid19.Classes;
using Gestion_Citas_Covid19.SqlServerContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gestion_Citas_Covid19.View
{
    public partial class FrmVaccinationProcess : Form
    {
        private void AbrFormInPanelSE(object Formhijo)
        {
            if (this.panel_SideEffects.Controls.Count > 0)
            {
                this.panel_SideEffects.Controls.RemoveAt(0);
            }
            Form fm = Formhijo as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panel_SideEffects.Controls.Add(fm);
            this.panel_SideEffects.Tag = fm;
            fm.Show();
        }
        int idAppointment = 0;
        public FrmVaccinationProcess(int appointmentId)
        {
            InitializeComponent();
            idAppointment = appointmentId;
        }
        private void DTP_WaitingRoom_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = DTP_WaitingRoom.Value;
            lbl_DateTime_WaitingRoom.Text = fecha.ToString();
        }
        private void DTP_Vaccination_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = DTP_Vaccination.Value;
            lbl_DateTime_Vaccination.Text = date.ToString();
        }
        private void btn_Yes_Click(object sender, EventArgs e)
        {

        }
        private void btn_No_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime waitTime = DTP_WaitingRoom.Value;
            DateTime vaccineTime = DTP_Vaccination.Value;

            using (SGCCDBContext dbList = new SGCCDBContext())
            {
                Appointment appt = dbList.Appointments.Find(idAppointment);
                appt.DtWaitlist = waitTime;
                appt.DtVaccination = vaccineTime;
                appt.IdStatus = 3;
                dbList.SaveChanges();


                Citizen pacient = dbList.Citizens.Find(appt.DuiCitizen);
                if (pacient.IdDose < 3)
                {
                    pacient.IdDose = pacient.IdDose + 1;
                    dbList.SaveChanges();

                    int idNewAppt = Generators.GenerateAppointment(appt.DuiCitizen, appt.ApptAddress, (int)pacient.IdDose);

                    MessageBox.Show("Informacion almacenada exitosamente", "Felicidades",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                    MessageBox.Show("Ya no puede generar mas citas", "X2error",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmVaccinationProcess_Load(object sender, EventArgs e)
        {
            AbrFormInPanelSE(new SideEffects());
        }
    }
}