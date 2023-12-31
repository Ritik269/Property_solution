﻿// <auto-generated />
using System;
using Findpropertymain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Findpropertymain.Migrations
{
    [DbContext(typeof(propertyslnContext))]
    [Migration("20221003021657_ritik")]
    partial class ritik
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Findpropertymain.Models.InterestedCustomer", b =>
                {
                    b.Property<short>("CustomerId")
                        .HasColumnType("smallint");

                    b.Property<short>("PropertyId")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("DateOfInterest")
                        .HasColumnType("date");

                    b.HasKey("CustomerId", "PropertyId")
                        .HasName("PK__Interest__E3A2FEAB2AA52DB1");

                    b.HasIndex("PropertyId");

                    b.ToTable("Interested_Customer");
                });

            modelBuilder.Entity("Findpropertymain.Models.Property", b =>
                {
                    b.Property<short>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BhkType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("BHK_Type");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FloorNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Floor_No");

                    b.Property<string>("Images")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Locality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<short?>("OwnerId")
                        .IsRequired()
                        .HasColumnType("smallint");

                    b.Property<short?>("PropTypeId")
                        .HasColumnType("smallint");

                    b.Property<short>("PropertyAge")
                        .HasColumnType("smallint");

                    b.Property<string>("PropertyFacing")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Property_Facing");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<long?>("PropertyPrice")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("StreetArea")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Street_Area");

                    b.Property<string>("TotalFloorNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Total_Floor_No");

                    b.HasKey("PropertyId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PropTypeId");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("Findpropertymain.Models.PropertyType", b =>
                {
                    b.Property<short>("PropTypeId")
                        .HasColumnType("smallint");

                    b.Property<string>("TypeNmae")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("PropTypeId")
                        .HasName("PK__Property__DA74BA7E448B61CC");

                    b.ToTable("PropertyType");
                });

            modelBuilder.Entity("Findpropertymain.Models.User", b =>
                {
                    b.Property<short>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("TypeId")
                        .HasColumnType("smallint");

                    b.Property<string>("UserEmailId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserMobileNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("TypeId");

                    b.HasIndex(new[] { "UserEmailId" }, "UQ__Users__09C7B32C32D6BA5B")
                        .IsUnique();

                    b.HasIndex(new[] { "UserMobileNumber" }, "UQ__Users__8C28638FF8799D03")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Findpropertymain.Models.UserType", b =>
                {
                    b.Property<short>("TypeId")
                        .HasColumnType("smallint");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("TypeId")
                        .HasName("PK__UserType__516F03B55AC3B524");

                    b.ToTable("UserType");
                });

            modelBuilder.Entity("Findpropertymain.Models.InterestedCustomer", b =>
                {
                    b.HasOne("Findpropertymain.Models.User", "Customer")
                        .WithMany("InterestedCustomers")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__Intereste__Custo__4316F928")
                        .IsRequired();

                    b.HasOne("Findpropertymain.Models.Property", "Property")
                        .WithMany("InterestedCustomers")
                        .HasForeignKey("PropertyId")
                        .HasConstraintName("FK__Intereste__Prope__440B1D61")
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Findpropertymain.Models.Property", b =>
                {
                    b.HasOne("Findpropertymain.Models.User", "Owner")
                        .WithMany("Properties")
                        .HasForeignKey("OwnerId")
                        .HasConstraintName("FK__Property__OwnerI__403A8C7D")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Findpropertymain.Models.PropertyType", "PropType")
                        .WithMany("Properties")
                        .HasForeignKey("PropTypeId")
                        .HasConstraintName("FK__Property__PropTy__3F466844");

                    b.Navigation("Owner");

                    b.Navigation("PropType");
                });

            modelBuilder.Entity("Findpropertymain.Models.User", b =>
                {
                    b.HasOne("Findpropertymain.Models.UserType", "Type")
                        .WithMany("Users")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK__Users__TypeId__3E52440B");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Findpropertymain.Models.Property", b =>
                {
                    b.Navigation("InterestedCustomers");
                });

            modelBuilder.Entity("Findpropertymain.Models.PropertyType", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Findpropertymain.Models.User", b =>
                {
                    b.Navigation("InterestedCustomers");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Findpropertymain.Models.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
