using System;
using System.Collections.Generic;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appointments = new HashSet<Appointment>();
            ChronicIllnesses = new HashSet<ChronicIllness>();
        }

        public string Dui { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int? IdCabin { get; set; }
        public string HomeAddress { get; set; }
        public int? IdDose { get; set; }
        public int? Age { get; set; }
        public int? IdOccupation { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Dose IdDoseNavigation { get; set; }
        public virtual Occupation IdOccupationNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<ChronicIllness> ChronicIllnesses { get; set; }
    }
}
