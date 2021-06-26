using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Gestion_Citas_Covid19.SqlServerContext
{
    public partial class SGCCDBContext : DbContext
    {
        public SGCCDBContext()
        {
        }

        public SGCCDBContext(DbContextOptions<SGCCDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<ApptStatus> ApptStatuses { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<CabinLogin> CabinLogins { get; set; }
        public virtual DbSet<ChronicIllness> ChronicIllnesses { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Dose> Doses { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<ObservationPeriod> ObservationPeriods { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<Symptom> Symptoms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=SGCCDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("APPOINTMENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApptAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("appt_address");

                entity.Property(e => e.DtAppointment)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_appointment");

                entity.Property(e => e.DtVaccination)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_vaccination");

                entity.Property(e => e.DtWaitlist)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_waitlist");

                entity.Property(e => e.DuiCitizen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui_citizen")
                    .IsFixedLength(true);

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DuiCitizen)
                    .HasConstraintName("fk_citizen_appointment");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("fk_status_appointment");
            });

            modelBuilder.Entity<ApptStatus>(entity =>
            {
                entity.ToTable("APPT_STATUS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApptStatus1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("appt_status");
            });

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("CABIN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CabinAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cabin_address");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Cabins)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_employee_cabin");
            });

            modelBuilder.Entity<CabinLogin>(entity =>
            {
                entity.HasKey(e => new { e.IdCabin, e.IdEmployee });

                entity.ToTable("CABIN_LOGIN");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.DtLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_login");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.CabinLogins)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cabin_login");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.CabinLogins)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_employee_login");
            });

            modelBuilder.Entity<ChronicIllness>(entity =>
            {
                entity.ToTable("CHRONIC_ILLNESS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChronicIllness1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chronic_illness");

                entity.Property(e => e.DuiCitizen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui_citizen")
                    .IsFixedLength(true);

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.ChronicIllnesses)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_citizen_illness");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__D876F1BEACB3C725");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui")
                    .IsFixedLength(true);

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("full_name");

                entity.Property(e => e.HomeAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("home_address");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdDose).HasColumnName("id_dose");

                entity.Property(e => e.IdOccupation).HasColumnName("id_occupation");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone_number")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_cabin_citizen");

                entity.HasOne(d => d.IdDoseNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdDose)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_dose_citizen");

                entity.HasOne(d => d.IdOccupationNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdOccupation)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_occupation_citizen");
            });

            modelBuilder.Entity<Dose>(entity =>
            {
                entity.ToTable("DOSE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dose1).HasColumnName("dose");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("employee_address");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");

                entity.Property(e => e.IdEmployeeType).HasColumnName("id_employee_type");

                entity.Property(e => e.ManagerPassword)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("manager_password");

                entity.Property(e => e.ManagerUsername)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("manager_username");

                entity.HasOne(d => d.IdEmployeeTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdEmployeeType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_employee_type_employee");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("EMPLOYEE_TYPE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeType1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employee_type");
            });

            modelBuilder.Entity<ObservationPeriod>(entity =>
            {
                entity.HasKey(e => new { e.IdAppointment, e.IdSideEffect })
                    .HasName("PK_OBSERVATION");

                entity.ToTable("OBSERVATION_PERIOD");

                entity.Property(e => e.IdAppointment).HasColumnName("id_appointment");

                entity.Property(e => e.IdSideEffect).HasColumnName("id_side_effect");

                entity.HasOne(d => d.IdAppointmentNavigation)
                    .WithMany(p => p.ObservationPeriods)
                    .HasForeignKey(d => d.IdAppointment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointment_period");

                entity.HasOne(d => d.IdSideEffectNavigation)
                    .WithMany(p => p.ObservationPeriods)
                    .HasForeignKey(d => d.IdSideEffect)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_side_effect_period");
            });

            modelBuilder.Entity<Occupation>(entity =>
            {
                entity.ToTable("OCCUPATION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Occupation1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("occupation");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.ToTable("SIDE_EFFECT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdSymptom).HasColumnName("id_symptom");

                entity.Property(e => e.SideEffectTime).HasColumnName("side_effect_time");

                entity.HasOne(d => d.IdSymptomNavigation)
                    .WithMany(p => p.SideEffects)
                    .HasForeignKey(d => d.IdSymptom)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_symptom_effect");
            });

            modelBuilder.Entity<Symptom>(entity =>
            {
                entity.ToTable("SYMPTOM");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Symptom1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("symptom");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
