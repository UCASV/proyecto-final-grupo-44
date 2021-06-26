using System;
using System.Collections.Generic;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class Dose
    {
        public Dose()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public int? Dose1 { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
