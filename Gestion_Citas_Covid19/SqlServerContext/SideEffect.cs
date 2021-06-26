using System;
using System.Collections.Generic;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            ObservationPeriods = new HashSet<ObservationPeriod>();
        }

        public int Id { get; set; }
        public int? IdSymptom { get; set; }
        public TimeSpan? SideEffectTime { get; set; }

        public virtual Symptom IdSymptomNavigation { get; set; }
        public virtual ICollection<ObservationPeriod> ObservationPeriods { get; set; }
    }
}
