using Clinic.Common;
using Clinic.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Infrastructure.Persistence;

public class ClinicDbContext : IdentityDbContext<ApplicationUser>
{
    public ClinicDbContext(DbContextOptions<ClinicDbContext> options)
        : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Staff> Staff { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<MedicalRecord> MedicalRecords { get; set; }
    public DbSet<VaccinationRecord> VaccinationRecords { get; set; }
    public DbSet<SurgicalHistory> SurgicalHistories { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<InventoryItem> InventoryItems { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<MedicationAdministration> MedicationAdministrations { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceItem> InvoiceItems { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }

    public DbSet<Service> Services { get; set; }

    public DbSet<ServiceCategory> ServiceCategories { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.DateCreated = DateTime.UtcNow;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.UtcNow;
                    break;
            }

        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure the relationship between ApplicationUser and Client
        modelBuilder.Entity<ApplicationUser>()
            .HasOne(a => a.Client)
            .WithOne() // A client does not have a navigation property back to the user
            .HasForeignKey<Client>(c => c.ApplicationUserId);

        // Configure the relationship between ApplicationUser and Staff
        modelBuilder.Entity<ApplicationUser>()
            .HasOne(a => a.Staff)
            .WithOne() // A staff member does not have a navigation property back to the user
            .HasForeignKey<Staff>(s => s.ApplicationUserId);
    }
}