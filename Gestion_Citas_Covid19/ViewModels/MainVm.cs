using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Citas_Covid19.ViewModels
{
    public class MainVm
    {
        public int ID { get; set; }

        public string DUI { get; set; }

        public DateTime Fecha  { get; set; }

        public string Lugar { get; set; }

        public string Status { get; set; }

    }
}
