using System;
using System.Collections.Generic;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class CabinLogin
    {
        public int IdEmployee { get; set; }
        public int IdCabin { get; set; }
        public DateTime? DtLogin { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
