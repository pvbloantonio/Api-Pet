﻿// <auto-generated />
using System;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230721063204_addData")]
    partial class addData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Api.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Age")
                        .HasColumnType("float");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 2.0,
                            Breed = "Gato",
                            Color = "Amarillo",
                            Created = new DateTime(2023, 7, 21, 2, 32, 4, 799, DateTimeKind.Local).AddTicks(9410),
                            Name = "Sam",
                            Updated = new DateTime(2023, 7, 21, 2, 32, 4, 799, DateTimeKind.Local).AddTicks(9440),
                            Weight = 4f
                        },
                        new
                        {
                            Id = 2,
                            Age = 1.0,
                            Breed = "Gato",
                            Color = "Blanco",
                            Created = new DateTime(2023, 7, 21, 2, 32, 4, 799, DateTimeKind.Local).AddTicks(9444),
                            Name = "Lucas",
                            Updated = new DateTime(2023, 7, 21, 2, 32, 4, 799, DateTimeKind.Local).AddTicks(9446),
                            Weight = 2f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}