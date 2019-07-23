﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoomTemp.Data;

namespace RoomTemp.Data.Migrations
{
    [DbContext(typeof(TemperatureContext))]
    [Migration("20190722074713_TempReadingTakenAtIndex")]
    partial class TempReadingTakenAtIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RoomTemp.Data.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("Key");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("RoomTemp.Data.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("RoomTemp.Data.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Sensor");
                });

            modelBuilder.Entity("RoomTemp.Data.TempReading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeviceId");

                    b.Property<int>("LocationId");

                    b.Property<int>("SensorId");

                    b.Property<DateTime>("TakenAt");

                    b.Property<decimal>("Temperature");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("LocationId");

                    b.HasIndex("SensorId");

                    b.HasIndex("TakenAt");

                    b.ToTable("TempReading");
                });

            modelBuilder.Entity("RoomTemp.Data.TempReading", b =>
                {
                    b.HasOne("RoomTemp.Data.Device", "Device")
                        .WithMany("TempReadings")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RoomTemp.Data.Location", "Location")
                        .WithMany("TempReadings")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RoomTemp.Data.Sensor", "Sensor")
                        .WithMany("TempReadings")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}