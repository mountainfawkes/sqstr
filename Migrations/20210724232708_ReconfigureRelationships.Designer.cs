﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sqstr.Models;

namespace sqstr.Solution.Migrations
{
    [DbContext(typeof(SqstrContext))]
    [Migration("20210724232708_ReconfigureRelationships")]
    partial class ReconfigureRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("sqstr.Models.Attributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Carbon_G")
                        .HasColumnType("int");

                    b.Property<double>("Carbon_Kg")
                        .HasColumnType("double");

                    b.Property<double>("Carbon_Lb")
                        .HasColumnType("double");

                    b.Property<double>("Carbon_Mt")
                        .HasColumnType("double");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("DataId")
                        .HasColumnType("int");

                    b.Property<string>("Distance_Unit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Distance_Value")
                        .HasColumnType("double");

                    b.Property<string>("Electricity_Unit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Electricity_Value")
                        .HasColumnType("double");

                    b.Property<DateTime>("Estimated_At")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Fuel_Source_Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Fuel_Source_Unit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Fuel_Source_Value")
                        .HasColumnType("int");

                    b.Property<int>("Passengers")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Transport_Method")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Vehicle_Make")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Vehicle_Model")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Vehicle_Year")
                        .HasColumnType("int");

                    b.Property<string>("Weight_Unit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Weight_Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("DataId")
                        .IsUnique();

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("sqstr.Models.Data", b =>
                {
                    b.Property<int>("DataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Id")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("RootId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DataId");

                    b.HasIndex("RootId")
                        .IsUnique();

                    b.ToTable("Data");
                });

            modelBuilder.Entity("sqstr.Models.Leg", b =>
                {
                    b.Property<int>("LegsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AttributesId")
                        .HasColumnType("int");

                    b.Property<string>("Departure_Airport")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Destination_Airport")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("LegsId");

                    b.HasIndex("AttributesId");

                    b.ToTable("Legs");
                });

            modelBuilder.Entity("sqstr.Models.Price", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("LatestPrice")
                        .HasColumnType("double");

                    b.Property<string>("PriceDate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PriceId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("sqstr.Models.Root", b =>
                {
                    b.Property<int>("RootId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("High")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("High_Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Price")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Price_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Price_Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Symbol")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("RootId");

                    b.ToTable("Roots");
                });

            modelBuilder.Entity("sqstr.Models.Attributes", b =>
                {
                    b.HasOne("sqstr.Models.Data", null)
                        .WithOne("Attributes")
                        .HasForeignKey("sqstr.Models.Attributes", "DataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sqstr.Models.Data", b =>
                {
                    b.HasOne("sqstr.Models.Root", null)
                        .WithOne("Data")
                        .HasForeignKey("sqstr.Models.Data", "RootId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sqstr.Models.Leg", b =>
                {
                    b.HasOne("sqstr.Models.Attributes", null)
                        .WithMany("Legs")
                        .HasForeignKey("AttributesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sqstr.Models.Attributes", b =>
                {
                    b.Navigation("Legs");
                });

            modelBuilder.Entity("sqstr.Models.Data", b =>
                {
                    b.Navigation("Attributes");
                });

            modelBuilder.Entity("sqstr.Models.Root", b =>
                {
                    b.Navigation("Data");
                });
#pragma warning restore 612, 618
        }
    }
}