﻿// <auto-generated />
using System;
using ClinicaVeterinaria.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicaVeterinaria.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Dueño", b =>
                {
                    b.HasBaseType("ClinicaVeterinaria.App.Dominio.Persona");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoDueño")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Dueño");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("ClinicaVeterinaria.App.Dominio.Persona");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoVeterinario")
                        .HasColumnType("int");

                    b.Property<DateTime>("HorarioLaboral")
                        .HasColumnType("datetime2");

                    b.Property<string>("LicenciaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });
#pragma warning restore 612, 618
        }
    }
}
