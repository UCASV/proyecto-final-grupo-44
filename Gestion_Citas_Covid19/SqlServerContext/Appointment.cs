using System;
using System.Collections.Generic;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class Appointment
    {
        public Appointment()
        {
            ObservationPeriods = new HashSet<ObservationPeriod>();
        }

        public int Id { get; set; }
        public DateTime? DtAppointment { get; set; }
        public DateTime? DtWaitlist { get; set; }
        public DateTime? DtVaccination { get; set; }
        public string ApptAddress { get; set; }
        public int? IdStatus { get; set; }
        public string DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        public virtual ApptStatus IdStatusNavigation { get; set; }
        public virtual ICollection<ObservationPeriod> ObservationPeriods { get; set; }
    }
}
