using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Findpropertymain.Models
{
    public partial class propertyslnContext : DbContext
    {
        public propertyslnContext()
        {
        }

        public propertyslnContext(DbContextOptions<propertyslnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InterestedCustomer> InterestedCustomers { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-35U7SC8\\SQLEXPRESS; Database=propertysln; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<InterestedCustomer>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.PropertyId })
                    .HasName("PK__Interest__E3A2FEAB2AA52DB1");

                entity.ToTable("Interested_Customer");

                entity.Property(e => e.DateOfInterest).HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.InterestedCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Intereste__Custo__4316F928");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.InterestedCustomers)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Intereste__Prope__440B1D61");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.ToTable("Property");

                entity.Property(e => e.BhkType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BHK_Type");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FloorNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Floor_No");

                entity.Property(e => e.Images)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locality)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyFacing)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Property_Facing");

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StreetArea)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Street_Area");

                entity.Property(e => e.TotalFloorNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Total_Floor_No");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK__Property__OwnerI__403A8C7D");

                entity.HasOne(d => d.PropType)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.PropTypeId)
                    .HasConstraintName("FK__Property__PropTy__3F466844");
            });

            modelBuilder.Entity<PropertyType>(entity =>
            {
                entity.HasKey(e => e.PropTypeId)
                    .HasName("PK__Property__DA74BA7E448B61CC");

                entity.ToTable("PropertyType");

                entity.Property(e => e.PropTypeId).ValueGeneratedNever();

                entity.Property(e => e.TypeNmae)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserEmailId, "UQ__Users__09C7B32C32D6BA5B")
                    .IsUnique();

                entity.HasIndex(e => e.UserMobileNumber, "UQ__Users__8C28638FF8799D03")
                    .IsUnique();

                entity.Property(e => e.UserEmailId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserMobileNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Users__TypeId__3E52440B");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__UserType__516F03B55AC3B524");

                entity.ToTable("UserType");

                entity.Property(e => e.TypeId).ValueGeneratedNever();

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
