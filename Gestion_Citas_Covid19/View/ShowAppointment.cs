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
using Gestion_Citas_Covid19.View;
using Gestion_Citas_Covid19.ViewModels;

namespace Gestion_Citas_Covid19
{
    public partial class ShowAppointment : Form
    {
        public ShowAppointment()
        {
            InitializeComponent();
        }

        private void ShowAppointment_Load(object sender, EventArgs e)
        {
            using (SGCCDBContext dbList = new SGCCDBContext())
            {
                var newDs = dbList.Appointments.ToList();
                var mappedDs = new List<MainVm>();

                newDs.ForEach(x => mappedDs.Add(dgvMapper.MainVmMapper(x)));

                dgvAppointments.DataSource = mappedDs;
            }

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnStart";

            dgvAppointments.Columns.Add(btn);
        }
    
            

        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvAppointments.Columns[e.ColumnIndex].Name == "btnStart")
                {
                    using (SGCCDBContext dbList = new SGCCDBContext())
                    {
                        MainVm selectedItem = (MainVm)dgvAppointments.CurrentRow.DataBoundItem;
                        Appointment appt = dbList.Appointments.Find(selectedItem.ID);

                        MessageBox.Show("Funciona", $"ID = {appt.Id}",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (appt.IdStatus !=3) {
                            appt.IdStatus = 2;
                            dbList.SaveChanges();

                            var window = new FrmVaccinationProcess(appt.Id);
                            this.Hide();

                            window.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Esta cita finalizo",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "No",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
               
    }
}
