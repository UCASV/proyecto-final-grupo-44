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
    public partial class frmInfoP : Form
    {
        public frmInfoP()
        {
            InitializeComponent();
        }

        private void frmInfoP_Load(object sender, EventArgs e)
        {
            /*
              using (SGCCDBContext dbList = new SGCCDBContext())
            {
                var newDs = dbList.Appointments.ToList();
                var mappedDs = new List<MainVm>();

                newDs.ForEach(x => mappedDs.Add(dgvMapper.MainVmMapper(x)));

                dgvAppointments.DataSource = mappedDs;
            }
             */
        }
    }
}
