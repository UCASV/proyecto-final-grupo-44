using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Citas_Covid19.Classes;
using Gestion_Citas_Covid19.SqlServerContext;

namespace Gestion_Citas_Covid19
{
    public partial class AddAppointment : Form
    {
        int idCabin = 0;

        public AddAppointment(int cabin)
        {
            InitializeComponent();
            idCabin = cabin;
        }

        private void btn_SaveData_Click(object sender, EventArgs e)
        {
            string dui = textBox_DUI.Text;
            string fullName = textBox_Name.Text;
            string address = textBox_Address.Text;
            int age = int.Parse(textBox_Age.Text);
            string phoneNumber = textBox_Telephone.Text;
            string? email = textBox_Mail.Text;
            string[] x = textBox_Diseases.Text.Split(',');

            //Validadores


            //Regex regex = new Regex("^\S+@\S+\.\S+$") Correo

            using (SGCCDBContext dbList = new SGCCDBContext())
            {
                try {
                    if (age >= 60 || cmbOccupation.SelectedIndex != 5 || enfC == true || enfT == true) //validar
                    {
                        Occupation occupationRef = (Occupation)cmbOccupation.SelectedItem;
                        Occupation occupationDb = dbList.Set<Occupation>()
                            .SingleOrDefault(x => x.Id == occupationRef.Id);

                        enfC = false;
                        enfT = false;

                        Citizen citizen = new Citizen()
                        {
                            Dui = dui,
                            FullName = fullName,
                            Email = email,
                            PhoneNumber = phoneNumber,
                            IdCabin = this.idCabin,
                            HomeAddress = address,
                            IdDose = 1,
                            Age = age,
                            IdOccupation = occupationDb.Id
                        };

                       foreach(string c in x)
                        {
                            ChronicIllness chrIllness = new ChronicIllness()
                            {
                                DuiCitizen = dui,
                                ChronicIllness1 = c
                            };
                            dbList.ChronicIllnesses.Add(chrIllness);
                        }

                        dbList.Citizens.Add(citizen);
                        dbList.SaveChanges();

                        Cabin auxCabin = dbList.Cabins.Find(idCabin);
                        string cabinAddress = auxCabin.CabinAddress;
                        int idNewAppt = Generators.GenerateAppointment(dui, cabinAddress, 1);
                        MessageBox.Show("cita generada con exito", "Felicidades",
                                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ya no puede generar mas citas", "error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AddAppointment_Load(object sender, EventArgs e)
        {

            using (SGCCDBContext dbList = new SGCCDBContext())
            {
                cmbOccupation.DataSource = dbList.Occupations.ToList();
                cmbOccupation.DisplayMember = "Occupation1";
                cmbOccupation.ValueMember = "Id";
            }
        }

        bool enfC = false;
        bool enfT = false;

        private void btnDis_Click(object sender, EventArgs e)
        {
            enfC = true;
        }

        private void btnEnf_Click(object sender, EventArgs e)
        {
            enfT = true;
        }
    }
    
}
