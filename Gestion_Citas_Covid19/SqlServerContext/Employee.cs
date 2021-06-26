using System;
using System.Collections.Generic;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class Employee
    {
        public Employee()
        {
            CabinLogins = new HashSet<CabinLogin>();
            Cabins = new HashSet<Cabin>();
        }

        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string Email { get; set; }
        public string ManagerUsername { get; set; }
        public string ManagerPassword { get; set; }
        public int? IdEmployeeType { get; set; }

        public virtual EmployeeType IdEmployeeTypeNavigation { get; set; }
        public virtual ICollection<CabinLogin> CabinLogins { get; set; }
        public virtual ICollection<Cabin> Cabins { get; set; }
    }
}
