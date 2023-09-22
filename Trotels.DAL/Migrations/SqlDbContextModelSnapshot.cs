﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trotels.DAL.Context;

#nullable disable

namespace Trotels.DAL.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Trotels.Entity.Concrete.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan>("CheckIn")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("CheckOut")
                        .HasColumnType("time");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(1943));

                    b.Property<int?>("GuestId")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoomId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Trotels.Entity.Concrete.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(3654));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("HotelId");

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasFilter("[Phone] IS NOT NULL");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Trotels.Entity.Concrete.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(6107));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<int?>("GuestAmount")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TcNo")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasFilter("[Phone] IS NOT NULL");

                    b.HasIndex("TcNo")
                        .IsUnique()
                        .HasFilter("[TcNo] IS NOT NULL");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Ali@gmail.com",
                            FirstName = "Ali",
                            LastName = "Yılmaz",
                            Password = "ali123"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Veli@gmail.com",
                            FirstName = "Veli",
                            LastName = "Kaya",
                            Password = "veli123"
                        });
                });

            modelBuilder.Entity("Trotels.Entity.Concrete.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 12, 42, 30, 132, DateTimeKind.Local).AddTicks(8761));

                    b.Property<string>("HotelAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("HotelCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HotelName")
                        .IsUnique();

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Trotels.Entity.Concrete.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 12, 42, 30, 133, DateTimeKind.Local).AddTicks(505));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("Occupancy")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Trotels.Entity.Concrete.Booking", b =>
                {
                    b.HasOne("Trotels.Entity.Concrete.Guest", "Guest")
                        .WithMany("Bookings")
                        .HasForeignKey("GuestId");

                    b.HasOne("Trotels.Entity.Concrete.Hotel", "Hotel")
                        .WithMany("Bookings")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trotels.Entity.Concrete.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomId");

                    b.Navigation("Guest");

                    b.Navigation("Hotel");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Trotels.Entity.Concrete.Employee", b =>
                {
                    b.HasOne("Trotels.Entity.Concrete.Hotel", "Hotel")
                        .WithMany("Employees")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Trotels.Entity.Concrete.Room", b =>
                {
                    b.HasOne("Trotels.Entity.Concrete.Hotel", "Hotel")
                        .WithMany("RoomNum")
                        .HasForeignKey("HotelId");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Trotels.Entity.Concrete.Guest", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Trotels.Entity.Concrete.Hotel", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Employees");

                    b.Navigation("RoomNum");
                });

            modelBuilder.Entity("Trotels.Entity.Concrete.Room", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
