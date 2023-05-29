﻿// <auto-generated />
using System;
using HotelProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelProject.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20230527194105_sample2")]
    partial class sample2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelProject.Model.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("HotelAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelContactNo")
                        .HasColumnType("int");

                    b.Property<string>("HotelDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomAvailability")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("HotelProject.Model.Reservation", b =>
                {
                    b.Property<int>("ResId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("Date");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("visitorId")
                        .HasColumnType("int");

                    b.HasKey("ResId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("HotelProject.Model.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("RoomAvailability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<int>("RoomPrice")
                        .HasColumnType("int");

                    b.Property<string>("RoomType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelProject.Model.Visitor", b =>
                {
                    b.Property<int>("visitorId")
                        .HasColumnType("int");

                    b.Property<string>("visitorAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("visitorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("visitorPhone")
                        .HasColumnType("int");

                    b.HasKey("visitorId");

                    b.ToTable("Visitors");
                });
#pragma warning restore 612, 618
        }
    }
}
