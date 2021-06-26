using System;
using System.Collections.Generic;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class Occupation
    {
        public Occupation()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string Occupation1 { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
