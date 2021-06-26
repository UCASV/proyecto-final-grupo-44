using System;
using System.Collections.Generic;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class ApptStatus
    {
        public ApptStatus()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string ApptStatus1 { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
