﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Projekt2_Aplikacja_bazodanowa_API.Migrations
{
    [DbContext(typeof(SWDatabase))]
    partial class SWDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("StarWars.Data.Films", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("characters")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("created")
                        .HasColumnType("TEXT");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("edited")
                        .HasColumnType("TEXT");

                    b.Property<string>("opening_crawl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("planets")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("producer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("release_date")
                        .HasColumnType("TEXT");

                    b.Property<string>("species")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("starships")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("vehicles")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("films");
                });

            modelBuilder.Entity("StarWars.Data.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("birth_year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("edited")
                        .HasColumnType("TEXT");

                    b.Property<string>("eye_color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("films")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("hair_color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("hight")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("homeworld")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("mass")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("skin_color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("species")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("starships")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("vehicles")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("people");
                });
#pragma warning restore 612, 618
        }
    }
}
