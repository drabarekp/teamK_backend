﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VaccinationSystemApi.Data;

namespace VaccinationSystemApi.Migrations
{
    [DbContext(typeof(VaccinationContext))]
    [Migration("20220326230702_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VaccinationSystemApi.Models.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Patient_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("TimeSlot_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VaccineBatchNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Vaccine_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("WhichDose")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Patient_Id");

                    b.HasIndex("TimeSlot_Id");

                    b.HasIndex("Vaccine_Id");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Certificate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PatientAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VaccinationCenter_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PatientAccountId");

                    b.HasIndex("VaccinationCenter_Id");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.OpeningHours", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FridayCloseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FridayOpenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MondayCloseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MondayOpenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SaturdayCloseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SaturdayOpenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SundayCloseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SundayOpenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ThursdayCloseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ThursdayOpenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TuesdayCloseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TuesdayOpenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WednesdayCloseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WednesdayOpenId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FridayCloseId");

                    b.HasIndex("FridayOpenId");

                    b.HasIndex("MondayCloseId");

                    b.HasIndex("MondayOpenId");

                    b.HasIndex("SaturdayCloseId");

                    b.HasIndex("SaturdayOpenId");

                    b.HasIndex("SundayCloseId");

                    b.HasIndex("SundayOpenId");

                    b.HasIndex("ThursdayCloseId");

                    b.HasIndex("ThursdayOpenId");

                    b.HasIndex("TuesdayCloseId");

                    b.HasIndex("TuesdayOpenId");

                    b.HasIndex("WednesdayCloseId");

                    b.HasIndex("WednesdayOpenId");

                    b.ToTable("OpeningHours");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.TimeSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TimeSlot");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Utils.TimeHours", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Hour")
                        .HasColumnType("int");

                    b.Property<int>("Minutes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TimeHours");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.VaccinationCenter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OpeningHours_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OpeningHours_Id");

                    b.ToTable("VaccinationCenter");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Vaccine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxDaysBetweenDoses")
                        .HasColumnType("int");

                    b.Property<int>("MaxPatientAge")
                        .HasColumnType("int");

                    b.Property<int>("MinDaysBetweenDoses")
                        .HasColumnType("int");

                    b.Property<int>("MinPatientAge")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfDoses")
                        .HasColumnType("int");

                    b.Property<bool>("Used")
                        .HasColumnType("bit");

                    b.Property<Guid?>("VaccinationCenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Virus_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VaccinationCenterId");

                    b.HasIndex("Virus_Id");

                    b.ToTable("Vaccine");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Virus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Virus");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Appointment", b =>
                {
                    b.HasOne("VaccinationSystemApi.Models.Patient", "Patient_")
                        .WithMany("Appointments")
                        .HasForeignKey("Patient_Id");

                    b.HasOne("VaccinationSystemApi.Models.TimeSlot", "TimeSlot_")
                        .WithMany()
                        .HasForeignKey("TimeSlot_Id");

                    b.HasOne("VaccinationSystemApi.Models.Vaccine", "Vaccine_")
                        .WithMany()
                        .HasForeignKey("Vaccine_Id");

                    b.Navigation("Patient_");

                    b.Navigation("TimeSlot_");

                    b.Navigation("Vaccine_");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Certificate", b =>
                {
                    b.HasOne("VaccinationSystemApi.Models.Patient", "Owner")
                        .WithMany("Certificates")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Doctor", b =>
                {
                    b.HasOne("VaccinationSystemApi.Models.Patient", "PatientAccount")
                        .WithMany()
                        .HasForeignKey("PatientAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VaccinationSystemApi.Models.VaccinationCenter", "VaccinationCenter_")
                        .WithMany("Doctors")
                        .HasForeignKey("VaccinationCenter_Id");

                    b.Navigation("PatientAccount");

                    b.Navigation("VaccinationCenter_");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.OpeningHours", b =>
                {
                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "FridayClose")
                        .WithMany()
                        .HasForeignKey("FridayCloseId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "FridayOpen")
                        .WithMany()
                        .HasForeignKey("FridayOpenId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "MondayClose")
                        .WithMany()
                        .HasForeignKey("MondayCloseId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "MondayOpen")
                        .WithMany()
                        .HasForeignKey("MondayOpenId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "SaturdayClose")
                        .WithMany()
                        .HasForeignKey("SaturdayCloseId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "SaturdayOpen")
                        .WithMany()
                        .HasForeignKey("SaturdayOpenId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "SundayClose")
                        .WithMany()
                        .HasForeignKey("SundayCloseId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "SundayOpen")
                        .WithMany()
                        .HasForeignKey("SundayOpenId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "ThursdayClose")
                        .WithMany()
                        .HasForeignKey("ThursdayCloseId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "ThursdayOpen")
                        .WithMany()
                        .HasForeignKey("ThursdayOpenId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "TuesdayClose")
                        .WithMany()
                        .HasForeignKey("TuesdayCloseId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "TuesdayOpen")
                        .WithMany()
                        .HasForeignKey("TuesdayOpenId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "WednesdayClose")
                        .WithMany()
                        .HasForeignKey("WednesdayCloseId");

                    b.HasOne("VaccinationSystemApi.Models.Utils.TimeHours", "WednesdayOpen")
                        .WithMany()
                        .HasForeignKey("WednesdayOpenId");

                    b.Navigation("FridayClose");

                    b.Navigation("FridayOpen");

                    b.Navigation("MondayClose");

                    b.Navigation("MondayOpen");

                    b.Navigation("SaturdayClose");

                    b.Navigation("SaturdayOpen");

                    b.Navigation("SundayClose");

                    b.Navigation("SundayOpen");

                    b.Navigation("ThursdayClose");

                    b.Navigation("ThursdayOpen");

                    b.Navigation("TuesdayClose");

                    b.Navigation("TuesdayOpen");

                    b.Navigation("WednesdayClose");

                    b.Navigation("WednesdayOpen");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.VaccinationCenter", b =>
                {
                    b.HasOne("VaccinationSystemApi.Models.OpeningHours", "OpeningHours_")
                        .WithMany()
                        .HasForeignKey("OpeningHours_Id");

                    b.Navigation("OpeningHours_");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Vaccine", b =>
                {
                    b.HasOne("VaccinationSystemApi.Models.VaccinationCenter", null)
                        .WithMany("AvailableVaccines")
                        .HasForeignKey("VaccinationCenterId");

                    b.HasOne("VaccinationSystemApi.Models.Virus", "Virus_")
                        .WithMany()
                        .HasForeignKey("Virus_Id");

                    b.Navigation("Virus_");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Certificates");
                });

            modelBuilder.Entity("VaccinationSystemApi.Models.VaccinationCenter", b =>
                {
                    b.Navigation("AvailableVaccines");

                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
