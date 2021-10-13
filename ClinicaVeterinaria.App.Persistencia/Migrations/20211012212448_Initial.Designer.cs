﻿// <auto-generated />
using System;
using ClinicaVeterinaria.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicaVeterinaria.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211012212448_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Agenda", b =>
                {
                    b.Property<int>("AgendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AuxiliarId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("AgendaId");

                    b.HasIndex("AuxiliarId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Anotacion", b =>
                {
                    b.Property<int>("AnotacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Duracion")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MascotaId")
                        .HasColumnType("int");

                    b.Property<int?>("auxiliarId")
                        .HasColumnType("int");

                    b.Property<int?>("ownerId")
                        .HasColumnType("int");

                    b.Property<int?>("veterinarioId")
                        .HasColumnType("int");

                    b.HasKey("AnotacionId");

                    b.HasIndex("MascotaId");

                    b.HasIndex("auxiliarId");

                    b.HasIndex("ownerId");

                    b.HasIndex("veterinarioId");

                    b.ToTable("Anotaciones");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Chequeo", b =>
                {
                    b.Property<int>("ChequeoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AnotacionId")
                        .HasColumnType("int");

                    b.Property<string>("Consiente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PresionArterial")
                        .HasColumnType("int");

                    b.Property<int>("Pulso")
                        .HasColumnType("int");

                    b.Property<string>("Temperatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoSangre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChequeoId");

                    b.HasIndex("AnotacionId");

                    b.ToTable("Chequeos");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Diagnostico", b =>
                {
                    b.Property<int>("DiagnosticoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AnotacionId")
                        .HasColumnType("int");

                    b.Property<int?>("ChequeoId")
                        .HasColumnType("int");

                    b.Property<string>("Gravedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MascotaId")
                        .HasColumnType("int");

                    b.Property<string>("Receta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiagnosticoId");

                    b.HasIndex("AnotacionId");

                    b.HasIndex("ChequeoId");

                    b.HasIndex("MascotaId");

                    b.ToTable("Diagnosticos");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("HistoriaClinicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AnotacionId")
                        .HasColumnType("int");

                    b.Property<int?>("ChequeoId")
                        .HasColumnType("int");

                    b.Property<int?>("MascotaId")
                        .HasColumnType("int");

                    b.Property<int?>("auxiliarId")
                        .HasColumnType("int");

                    b.Property<int?>("ownerId")
                        .HasColumnType("int");

                    b.Property<int?>("veterinarioId")
                        .HasColumnType("int");

                    b.HasKey("HistoriaClinicaId");

                    b.HasIndex("AnotacionId");

                    b.HasIndex("ChequeoId");

                    b.HasIndex("MascotaId");

                    b.HasIndex("auxiliarId");

                    b.HasIndex("ownerId");

                    b.HasIndex("veterinarioId");

                    b.ToTable("HistoriaClinicas");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Mascota", b =>
                {
                    b.Property<int>("MascotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripción")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<int?>("auxiliarId")
                        .HasColumnType("int");

                    b.Property<int?>("ownerId")
                        .HasColumnType("int");

                    b.Property<int?>("veterinarioId")
                        .HasColumnType("int");

                    b.HasKey("MascotaId");

                    b.HasIndex("auxiliarId");

                    b.HasIndex("ownerId");

                    b.HasIndex("veterinarioId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Cedula")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Auxiliar", b =>
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

                    b.HasDiscriminator().HasValue("Auxiliar");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Owner", b =>
                {
                    b.HasBaseType("ClinicaVeterinaria.App.Dominio.Persona");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Owner");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("ClinicaVeterinaria.App.Dominio.Persona");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Veterinario_Especializacion");

                    b.Property<int>("EstadoVeterinario")
                        .HasColumnType("int")
                        .HasColumnName("Veterinario_EstadoVeterinario");

                    b.Property<DateTime>("HorarioLaboral")
                        .HasColumnType("datetime2")
                        .HasColumnName("Veterinario_HorarioLaboral");

                    b.Property<string>("LicenciaProfesional")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Veterinario_LicenciaProfesional");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Agenda", b =>
                {
                    b.HasOne("ClinicaVeterinaria.App.Dominio.Auxiliar", "Auxiliar")
                        .WithMany()
                        .HasForeignKey("AuxiliarId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("Auxiliar");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Anotacion", b =>
                {
                    b.HasOne("ClinicaVeterinaria.App.Dominio.Mascota", "mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Auxiliar", "auxiliar")
                        .WithMany()
                        .HasForeignKey("auxiliarId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Owner", "owner")
                        .WithMany()
                        .HasForeignKey("ownerId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Veterinario", "veterinario")
                        .WithMany()
                        .HasForeignKey("veterinarioId");

                    b.Navigation("auxiliar");

                    b.Navigation("mascota");

                    b.Navigation("owner");

                    b.Navigation("veterinario");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Chequeo", b =>
                {
                    b.HasOne("ClinicaVeterinaria.App.Dominio.Anotacion", "anotacion")
                        .WithMany()
                        .HasForeignKey("AnotacionId");

                    b.Navigation("anotacion");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Diagnostico", b =>
                {
                    b.HasOne("ClinicaVeterinaria.App.Dominio.Anotacion", "anotacion")
                        .WithMany()
                        .HasForeignKey("AnotacionId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Chequeo", "chequeo")
                        .WithMany()
                        .HasForeignKey("ChequeoId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Mascota", "mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId");

                    b.Navigation("anotacion");

                    b.Navigation("chequeo");

                    b.Navigation("mascota");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.HistoriaClinica", b =>
                {
                    b.HasOne("ClinicaVeterinaria.App.Dominio.Anotacion", "anotacion")
                        .WithMany()
                        .HasForeignKey("AnotacionId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Chequeo", "chequeo")
                        .WithMany()
                        .HasForeignKey("ChequeoId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Mascota", "mascota")
                        .WithMany()
                        .HasForeignKey("MascotaId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Auxiliar", "auxiliar")
                        .WithMany()
                        .HasForeignKey("auxiliarId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Owner", "owner")
                        .WithMany()
                        .HasForeignKey("ownerId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Veterinario", "veterinario")
                        .WithMany()
                        .HasForeignKey("veterinarioId");

                    b.Navigation("anotacion");

                    b.Navigation("auxiliar");

                    b.Navigation("chequeo");

                    b.Navigation("mascota");

                    b.Navigation("owner");

                    b.Navigation("veterinario");
                });

            modelBuilder.Entity("ClinicaVeterinaria.App.Dominio.Mascota", b =>
                {
                    b.HasOne("ClinicaVeterinaria.App.Dominio.Auxiliar", "auxiliar")
                        .WithMany()
                        .HasForeignKey("auxiliarId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Owner", "owner")
                        .WithMany()
                        .HasForeignKey("ownerId");

                    b.HasOne("ClinicaVeterinaria.App.Dominio.Veterinario", "veterinario")
                        .WithMany()
                        .HasForeignKey("veterinarioId");

                    b.Navigation("auxiliar");

                    b.Navigation("owner");

                    b.Navigation("veterinario");
                });
#pragma warning restore 612, 618
        }
    }
}