using System;
using System.Collections.Generic;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class ObservationPeriod
    {
        public int IdAppointment { get; set; }
        public int IdSideEffect { get; set; }

        public virtual Appointment IdAppointmentNavigation { get; set; }
        public virtual SideEffect IdSideEffectNavigation { get; set; }
    }
}
