using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Citas_Covid19.SqlServerContext;

namespace Gestion_Citas_Covid19.ViewModels
{
    public static class dgvMapper
    {
        public static MainVm MainVmMapper(Appointment a)
        {
            string status = "empty";

            if (a.IdStatus == 1)
                status = "Agendada";
            else if (a.IdStatus == 2)
                status = "En proceso";
            else if (a.IdStatus == 3)
                status = "Finalizada";
            
            return new MainVm
            {
                ID = a.Id,
                DUI = a.DuiCitizen,
                Fecha = (DateTime)a.DtAppointment,
                Lugar = a.ApptAddress,
                Status = status
            };
        }

        public static InfoEVm InfoEmployee(Employee e)
        {
            return new InfoEVm
            {
                ID = e.Id,
                NOMBRE = e.EmployeeName,
                PUESTO = e.,

            };
        }

        public static InfoCVm InfoCabin(Cabin e)
        {
            return new InfoCVm
            {

            };
        }

    }
}
