﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Citas_Covid19.SqlServerContext;

namespace Gestion_Citas_Covid19.Classes
{
    public static class Generators 
    {
        public static void GenerateAppointment(string dui, string cabinAddres, int idDose) // id(1) -> dose(0)
        {
            if(idDose == 1)
            {
                DateTime apptDate = DateTime.Today;
                apptDate.AddDays(72);
                CreateAppointment(dui, cabinAddres, idDose, apptDate.AddDays(72));
            }
            else if (idDose == 2)
            {
                using (SGCCDBContext dbLista = new SGCCDBContext())
                {
                    var firstAppointment = dbLista.Appointments.Where(x => x.DuiCitizen == dui).ToList();
                    
                    if(firstAppointment[0].IdStatus == 3)
                    {
                        DateTime newAppointment = (DateTime)firstAppointment[0].DtAppointment;
                        newAppointment.AddDays(70);

                        CreateAppointment(dui, cabinAddres, idDose, newAppointment.AddDays(70));
                    }
                }
            }


        }

        private static void CreateAppointment(string dui, string cabinAddres, int idDose, DateTime apptDate)
        {
            using (SGCCDBContext dbList = new SGCCDBContext())
            {
                Appointment appt = new Appointment()
                {
                    DtAppointment = apptDate,
                    DtWaitlist = null,
                    DtVaccination = null,
                    ApptAddress = cabinAddres,
                    IdStatus = 1,
                    DuiCitizen = dui
                };

                dbList.Appointments.Add(appt);
                dbList.SaveChanges();
            }
        }
    }
}