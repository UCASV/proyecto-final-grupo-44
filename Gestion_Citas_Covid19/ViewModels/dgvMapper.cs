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
            string employeeType = "empty";

            if (e.IdEmployeeType == 1)
                employeeType = "Gestor";
            else if (e.IdEmployeeType == 2)
                employeeType = "Vacunador";
            else if (e.IdEmployeeType == 3)
                employeeType = "Asistente de Salud";
            else if (e.IdEmployeeType == 4)
                employeeType = "Otro trabajo";



            return new InfoEVm
            {
                ID = e.Id,
                NOMBRE = e.EmployeeName,
                EMAIL = e.Email,
                PUESTO = employeeType
            };
        }

        public static InfoCVm InfoCabin(Cabin c)
        {
            string employeeName = "empty";

            using (SGCCDBContext dbList = new SGCCDBContext())
            {
                Employee manager = dbList.Employees.Find(c.IdEmployee);
                employeeName = manager.EmployeeName;
            }

                return new InfoCVm
                {
                    ID = c.Id,
                    UBICACION = c.CabinAddress,
                    ENCARGADO = employeeName,
                    TELEFONO = c.PhoneNumber,
                    EMAIL = c.Email               
                };
        }

    }
}
