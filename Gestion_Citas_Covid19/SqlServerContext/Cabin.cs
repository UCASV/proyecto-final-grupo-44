using System;
using System.Collections.Generic;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class Cabin
    {
        public Cabin()
        {
            CabinLogins = new HashSet<CabinLogin>();
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CabinAddress { get; set; }
        public int? IdEmployee { get; set; }

        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual ICollection<CabinLogin> CabinLogins { get; set; }
        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
