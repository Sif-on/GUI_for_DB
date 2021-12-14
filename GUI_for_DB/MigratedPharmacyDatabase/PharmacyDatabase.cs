using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GUI_for_DB
{
    public partial class PharmacyContext : DbContext
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConf"].ConnectionString;
        public PharmacyContext()
        {
        }

        public PharmacyContext(DbContextOptions<PharmacyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Instruction> Instructions { get; set; }
        public virtual DbSet<PharmacologicalGroup> PharmacologicalGroups { get; set; }
        public virtual DbSet<Pharmacy> Pharmacies { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Wish> Wishes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("name");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateFinish).HasColumnName("date_finish");

                entity.Property(e => e.DateStart).HasColumnName("date_start");

                entity.Property(e => e.DiscountPercentage).HasColumnName("discount_percentage");

                entity.Property(e => e.IdPharmacy).HasColumnName("id_pharmacy");

                entity.Property(e => e.IdProduct).HasColumnName("id_product");

                entity.HasOne(d => d.IdPharmacyNavigation)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.IdPharmacy)
                    .HasConstraintName("Discounts_id_pharmacy_fkey");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("Discounts_id_product_fkey");
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdFarmGroup).HasColumnName("id_farm_group");

                entity.Property(e => e.IdInstructions).HasColumnName("id_instructions");

                entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");

                entity.Property(e => e.Name)
                    .HasMaxLength(55)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Recipe)
                    .HasColumnType("bit(1)")
                    .HasColumnName("recipe");

                entity.HasOne(d => d.IdFarmGroupNavigation)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.IdFarmGroup)
                    .HasConstraintName("Drugs_id_farm_group_fkey");

                entity.HasOne(d => d.IdInstructionsNavigation)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.IdInstructions)
                    .HasConstraintName("Drugs_id_instructions_fkey");

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.Drugs)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.IdSupplier)
                    .HasConstraintName("Drugs_id_supplier_fkey");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("first_name");

                entity.Property(e => e.IdPosition).HasColumnName("id_position");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("name");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("surname");

                entity.HasOne(d => d.IdPositionNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdPosition)
                    .HasConstraintName("Employees_id_position_fkey");
            });

            modelBuilder.Entity<Instruction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.OnceDay).HasColumnName("once_day");

                entity.Property(e => e.Restrictions)
                    .HasMaxLength(2048)
                    .HasColumnName("restrictions");
            });

            modelBuilder.Entity<PharmacologicalGroup>(entity =>
            {
                entity.ToTable("Pharmacological_Group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(55)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Pharmacy>(entity =>
            {
                entity.ToTable("Pharmacy");

                entity.HasIndex(e => e.IdDirector, "Pharmacy_id_director_key")
                    .IsUnique();

                entity.HasIndex(e => e.Phone, "Pharmacy_phone_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("address");

                entity.Property(e => e.Hours)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("hours");

                entity.Property(e => e.IdDirector).HasColumnName("id_director");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("phone");

                entity.HasOne(d => d.IdDirectorNavigation)
                    .WithOne(p => p.Pharmacy)
                    .HasForeignKey<Pharmacy>(d => d.IdDirector)
                    .HasConstraintName("Pharmacy_id_director_fkey");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("phone");

                entity.HasOne(d => d.Phone1Navigation)
                    .WithMany(p => p.Phones)
                    .HasPrincipalKey(p => p.Phone)
                    .HasForeignKey(d => d.Phone1)
                    .HasConstraintName("Phones_phone_fkey");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasIndex(e => e.NamePosition, "Positions_name_position_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NamePosition)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("name_position");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdPharmacy).HasColumnName("id_pharmacy");

                entity.Property(e => e.IdProduct).HasColumnName("id_product");

                entity.Property(e => e.Sum).HasColumnName("sum");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("Receipts_id_client_fkey");

                entity.HasOne(d => d.IdPharmacyNavigation)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.IdPharmacy)
                    .HasConstraintName("Receipts_id_pharmacy_fkey");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("Receipts_id_product_fkey");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => new { e.Name, e.Country })
                    .HasName("Suppliers_pkey");

                entity.HasIndex(e => e.Id, "Suppliers_id_key")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(55)
                    .HasColumnName("name");

                entity.Property(e => e.Country)
                    .HasMaxLength(55)
                    .HasColumnName("country");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Wish>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdClients).HasColumnName("id_clients");

                entity.Property(e => e.IdPharmacy).HasColumnName("id_pharmacy");

                entity.Property(e => e.Wish1)
                    .HasMaxLength(2048)
                    .HasColumnName("wish");

                entity.HasOne(d => d.IdClientsNavigation)
                    .WithMany(p => p.Wishes)
                    .HasForeignKey(d => d.IdClients)
                    .HasConstraintName("Wishes_id_clients_fkey");

                entity.HasOne(d => d.IdPharmacyNavigation)
                    .WithMany(p => p.Wishes)
                    .HasForeignKey(d => d.IdPharmacy)
                    .HasConstraintName("Wishes_id_pharmacy_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
