﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P1_AP1_Reny_20190003.DAL;

namespace P1_AP1_Reny_20190003.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211006030428_Migracion_Inicial")]
    partial class Migracion_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("P1_AP1_Reny_20190003.Entidades.Aportes", b =>
                {
                    b.Property<int>("aporteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .HasColumnType("TEXT");

                    b.Property<int>("Conteo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Persona")
                        .HasColumnType("TEXT");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("aporteId");

                    b.ToTable("Aportes");
                });
#pragma warning restore 612, 618
        }
    }
}
