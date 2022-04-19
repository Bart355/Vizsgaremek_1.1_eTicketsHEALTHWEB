﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eTicketsHEALTHWEB.Data;

namespace eTicketsHEALTHWEB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220227100944_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.Doctor_VirusName", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("VirusNameId")
                        .HasColumnType("int");

                    b.HasKey("DoctorId", "VirusNameId");

                    b.HasIndex("VirusNameId");

                    b.ToTable("Doctors_VirusNames");
                });

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.VirusName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VirusNameCategory")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("HospitalId");

                    b.ToTable("VirusNames");
                });

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.Doctor_VirusName", b =>
                {
                    b.HasOne("eTicketsHEALTHWEB.Models.Doctor", "Doctor")
                        .WithMany("Doctors_VirusNames")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTicketsHEALTHWEB.Models.VirusName", "VirusName")
                        .WithMany("Doctors_VirusNames")
                        .HasForeignKey("VirusNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("VirusName");
                });

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.VirusName", b =>
                {
                    b.HasOne("eTicketsHEALTHWEB.Models.Company", "Company")
                        .WithMany("VirusNames")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTicketsHEALTHWEB.Models.Hospital", "Hospital")
                        .WithMany("VirusNames")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.Company", b =>
                {
                    b.Navigation("VirusNames");
                });

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.Doctor", b =>
                {
                    b.Navigation("Doctors_VirusNames");
                });

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.Hospital", b =>
                {
                    b.Navigation("VirusNames");
                });

            modelBuilder.Entity("eTicketsHEALTHWEB.Models.VirusName", b =>
                {
                    b.Navigation("Doctors_VirusNames");
                });
#pragma warning restore 612, 618
        }
    }
}
