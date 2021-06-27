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
using Gestion_Citas_Covid19.ViewModels;

namespace Gestion_Citas_Covid19.View
{
    public partial class frmInfoC : Form
    {
        public frmInfoC()
        {
            InitializeComponent();
        }

        private void frmInfoC_Load(object sender, EventArgs e)
        {
            using (SGCCDBContext dbList = new SGCCDBContext())
            {
                var newDs = dbList.Cabins.ToList();
                var mappedDs = new List<InfoCVm>();

                newDs.ForEach(x => mappedDs.Add(dgvMapper.InfoCabin(x)));

                dgvCabin.DataSource = mappedDs;
            }
        }
    }
}
