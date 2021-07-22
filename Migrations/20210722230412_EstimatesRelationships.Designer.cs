﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sqstr.Models;

namespace sqstr.Solution.Migrations
{
    [DbContext(typeof(SqstrContext))]
    [Migration("20210722230412_EstimatesRelationships")]
    partial class EstimatesRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("sqstr.Models.Electricity", b =>
                {
                    b.Property<int>("ElectricityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("CarbonG")
                        .HasColumnType("float");

                    b.Property<float>("CarbonKg")
                        .HasColumnType("float");

                    b.Property<float>("CarbonLb")
                        .HasColumnType("float");

                    b.Property<float>("CarbonMt")
                        .HasColumnType("float");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("DistanceUnit")
                        .HasColumnType("float");

                    b.Property<float>("DistanceValue")
                        .HasColumnType("float");

                    b.Property<string>("ElectricityUnit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ElectricityValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("EstimateId")
                        .HasColumnType("int");

                    b.Property<string>("EstimatedAt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ElectricityId");

                    b.HasIndex("EstimateId");

                    b.ToTable("Electricities");
                });

            modelBuilder.Entity("sqstr.Models.Estimate", b =>
                {
                    b.Property<int>("EstimateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("InterfaceEstimateId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("EstimateId");

                    b.ToTable("Estimates");
                });

            modelBuilder.Entity("sqstr.Models.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("CarbonG")
                        .HasColumnType("float");

                    b.Property<float>("CarbonKg")
                        .HasColumnType("float");

                    b.Property<float>("CarbonLb")
                        .HasColumnType("float");

                    b.Property<float>("CarbonMt")
                        .HasColumnType("float");

                    b.Property<string>("DistanceUnit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("DistanceValue")
                        .HasColumnType("float");

                    b.Property<int>("EstimateId")
                        .HasColumnType("int");

                    b.Property<string>("EstimatedAt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("LegId")
                        .HasColumnType("int");

                    b.Property<int>("Passengers")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.HasIndex("EstimateId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("sqstr.Models.Fuel", b =>
                {
                    b.Property<int>("FuelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("CarbonG")
                        .HasColumnType("float");

                    b.Property<float>("CarbonKg")
                        .HasColumnType("float");

                    b.Property<float>("CarbonLb")
                        .HasColumnType("float");

                    b.Property<float>("CarbonMt")
                        .HasColumnType("float");

                    b.Property<int>("EstimateId")
                        .HasColumnType("int");

                    b.Property<string>("EstimatedAt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FuelSourceType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FuelSourceUnit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("FuelSourceValue")
                        .HasColumnType("float");

                    b.HasKey("FuelId");

                    b.HasIndex("EstimateId");

                    b.ToTable("Fuels");
                });

            modelBuilder.Entity("sqstr.Models.Leg", b =>
                {
                    b.Property<int>("LegId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DepartureAirport_1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DepartureAirport_2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DepartureAirport_3")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DestinationAirport_1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DestinationAirport_2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DestinationAirport_3")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.HasKey("LegId");

                    b.HasIndex("FlightId");

                    b.ToTable("Legs");
                });

            modelBuilder.Entity("sqstr.Models.Price", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("EstimateId")
                        .HasColumnType("int");

                    b.Property<double>("LatestPrice")
                        .HasColumnType("double");

                    b.Property<string>("PriceDate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PriceId");

                    b.HasIndex("EstimateId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("sqstr.Models.SeedAirport", b =>
                {
                    b.Property<int>("SeedAirportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IATA")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Lat")
                        .HasColumnType("double");

                    b.Property<double>("Lon")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SeedAirportId");

                    b.ToTable("SeedAirports");
                });

            modelBuilder.Entity("sqstr.Models.SeedCountry", b =>
                {
                    b.Property<int>("SeedCountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SeedCountryId");

                    b.ToTable("SeedCountries");
                });

            modelBuilder.Entity("sqstr.Models.SeedFuel", b =>
                {
                    b.Property<int>("SeedFuelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FuelSourceUnit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SeedFuelId");

                    b.ToTable("SeedFuels");
                });

            modelBuilder.Entity("sqstr.Models.SeedSubregion", b =>
                {
                    b.Property<int>("SeedSubregionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SeedSubregionId");

                    b.ToTable("SeedSubregions");
                });

            modelBuilder.Entity("sqstr.Models.SeedVehicle", b =>
                {
                    b.Property<int>("SeedVehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("QueryId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("SeedVehicleId");

                    b.ToTable("SeedVehicles");
                });

            modelBuilder.Entity("sqstr.Models.Shipping", b =>
                {
                    b.Property<int>("ShippingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("CarbonG")
                        .HasColumnType("float");

                    b.Property<float>("CarbonKg")
                        .HasColumnType("float");

                    b.Property<float>("CarbonLb")
                        .HasColumnType("float");

                    b.Property<float>("CarbonMt")
                        .HasColumnType("float");

                    b.Property<string>("DistanceUnit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("DistanceValue")
                        .HasColumnType("float");

                    b.Property<int>("EstimateId")
                        .HasColumnType("int");

                    b.Property<string>("EstimatedAt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("WeightUnit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("WeightValue")
                        .HasColumnType("float");

                    b.HasKey("ShippingId");

                    b.HasIndex("EstimateId");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("sqstr.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("CarbonG")
                        .HasColumnType("float");

                    b.Property<float>("CarbonKg")
                        .HasColumnType("float");

                    b.Property<float>("CarbonLb")
                        .HasColumnType("float");

                    b.Property<float>("CarbonMt")
                        .HasColumnType("float");

                    b.Property<string>("DistanceUnit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("DistanceValue")
                        .HasColumnType("float");

                    b.Property<int>("EstimateId")
                        .HasColumnType("int");

                    b.Property<string>("EstimatedAt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VehicleMake")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VehicleModel")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VehicleModelId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("VehicleYear")
                        .HasColumnType("int");

                    b.HasKey("VehicleId");

                    b.HasIndex("EstimateId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("sqstr.Models.Electricity", b =>
                {
                    b.HasOne("sqstr.Models.Estimate", "Estimate")
                        .WithMany("Electricities")
                        .HasForeignKey("EstimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estimate");
                });

            modelBuilder.Entity("sqstr.Models.Flight", b =>
                {
                    b.HasOne("sqstr.Models.Estimate", "Estimate")
                        .WithMany("Flights")
                        .HasForeignKey("EstimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estimate");
                });

            modelBuilder.Entity("sqstr.Models.Fuel", b =>
                {
                    b.HasOne("sqstr.Models.Estimate", "Estimate")
                        .WithMany("Fuels")
                        .HasForeignKey("EstimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estimate");
                });

            modelBuilder.Entity("sqstr.Models.Leg", b =>
                {
                    b.HasOne("sqstr.Models.Flight", "Flight")
                        .WithMany("Legs")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("sqstr.Models.Price", b =>
                {
                    b.HasOne("sqstr.Models.Estimate", "Estimate")
                        .WithMany("Prices")
                        .HasForeignKey("EstimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estimate");
                });

            modelBuilder.Entity("sqstr.Models.Shipping", b =>
                {
                    b.HasOne("sqstr.Models.Estimate", "Estimate")
                        .WithMany("Shippings")
                        .HasForeignKey("EstimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estimate");
                });

            modelBuilder.Entity("sqstr.Models.Vehicle", b =>
                {
                    b.HasOne("sqstr.Models.Estimate", "Estimate")
                        .WithMany("Vehicles")
                        .HasForeignKey("EstimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estimate");
                });

            modelBuilder.Entity("sqstr.Models.Estimate", b =>
                {
                    b.Navigation("Electricities");

                    b.Navigation("Flights");

                    b.Navigation("Fuels");

                    b.Navigation("Prices");

                    b.Navigation("Shippings");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("sqstr.Models.Flight", b =>
                {
                    b.Navigation("Legs");
                });
#pragma warning restore 612, 618
        }
    }
}
