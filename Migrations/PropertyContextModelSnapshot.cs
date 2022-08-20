﻿// <auto-generated />
using System;
using GovHack22API.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GovHack22API.Migrations
{
    [DbContext(typeof(PropertyContext))]
    partial class PropertyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GovHack22API.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("SpaceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("SpaceId");

                    b.ToTable("Availability");
                });

            modelBuilder.Entity("GovHack22API.Models.Facilities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AccessibleAccess")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ContactlessAccess")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lift")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Monitors")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Parking")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Shower")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Stairs")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("GovHack22API.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("int");

                    b.Property<string>("URI")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("GovHack22API.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Latitude")
                        .HasColumnType("float");

                    b.Property<float>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Suburb")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("GovHack22API.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("GovHack22API.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DressCode")
                        .HasColumnType("int");

                    b.Property<int>("FacilitiesId")
                        .HasColumnType("int");

                    b.Property<int>("FloorPlanId")
                        .HasColumnType("int");

                    b.Property<int>("GreenRating")
                        .HasColumnType("int");

                    b.Property<string>("HouseRules")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FacilitiesId");

                    b.HasIndex("FloorPlanId");

                    b.HasIndex("LocationId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("GovHack22API.Models.Space", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<float>("DailyPrice")
                        .HasColumnType("float");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Space");
                });

            modelBuilder.Entity("GovHack22API.Models.Availability", b =>
                {
                    b.HasOne("GovHack22API.Models.Space", null)
                        .WithMany("Availability")
                        .HasForeignKey("SpaceId");
                });

            modelBuilder.Entity("GovHack22API.Models.Image", b =>
                {
                    b.HasOne("GovHack22API.Models.Property", null)
                        .WithMany("Images")
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("GovHack22API.Models.Property", b =>
                {
                    b.HasOne("GovHack22API.Models.Facilities", "Facilities")
                        .WithMany()
                        .HasForeignKey("FacilitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GovHack22API.Models.Image", "FloorPlan")
                        .WithMany()
                        .HasForeignKey("FloorPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GovHack22API.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GovHack22API.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facilities");

                    b.Navigation("FloorPlan");

                    b.Navigation("Location");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("GovHack22API.Models.Space", b =>
                {
                    b.HasOne("GovHack22API.Models.Property", null)
                        .WithMany("Spaces")
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("GovHack22API.Models.Property", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Spaces");
                });

            modelBuilder.Entity("GovHack22API.Models.Space", b =>
                {
                    b.Navigation("Availability");
                });
#pragma warning restore 612, 618
        }
    }
}
