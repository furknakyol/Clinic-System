using Microsoft.EntityFrameworkCore;

public class ClinicContext : DbContext
{
    public DbSet<Patient> Patients { get; set; } 
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<PatientContact> PatientContacts { get; set; }
    public DbSet<DoctorContact> DoctorContacts { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; } 
    public DbSet<Treatment> Treatments { get; set; } 
    public DbSet<Bill> Bills { get; set; } 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ClinicDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // PatientContact ile Patient ilişkisi 
        modelBuilder.Entity<PatientContact>()
            .HasOne(pc => pc.Patient)
            .WithMany(p => p.PatientContacts)
            .HasForeignKey(pc => pc.PatientID);

        // DoctorContact ile Doctor ilişkisi 
        modelBuilder.Entity<DoctorContact>()
            .HasOne(dc => dc.Doctor)
            .WithMany(d => d.DoctorContacts)
            .HasForeignKey(dc => dc.DoctorID);

        // Appointment ile Patient ilişkisi 
        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Patient)
            .WithMany(p => p.Appointments)
            .HasForeignKey(a => a.PatientID);

        // Appointment ile Doctor ilişkisi 
        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Doctor)
            .WithMany(d => d.Appointments)
            .HasForeignKey(a => a.DoctorID);

        // Prescription ile Patient ilişkisi 
        modelBuilder.Entity<Prescription>()
            .HasOne(pr => pr.Patient)
            .WithMany(p => p.Prescriptions)
            .HasForeignKey(pr => pr.PatientID);

        // Prescription ile Doctor ilişkisi 
        modelBuilder.Entity<Prescription>()
            .HasOne(pr => pr.Doctor)
            .WithMany(d => d.Prescriptions)
            .HasForeignKey(pr => pr.DoctorID);

        // Treatment ile Appointment ilişkisi 
        modelBuilder.Entity<Treatment>()
            .HasOne(t => t.Appointment)
            .WithOne(a => a.Treatment)
            .HasForeignKey<Treatment>(t => t.AppointmentID);

        // Bill ile Treatment ilişkisi 
        modelBuilder.Entity<Bill>()
            .HasOne(b => b.Treatment)
            .WithOne(t => t.Bill)
            .HasForeignKey<Bill>(b => b.TreatmentID);
    }
}

