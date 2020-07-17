﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Context;

namespace PacienteES.Infraestructure.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200716204531_includetipoidentificacionOwned")]
    partial class includetipoidentificacionOwned
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Barrio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BarrioAcompanante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carnet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionAcompanante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EscolaridadId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoCivilId")
                        .HasColumnType("int");

                    b.Property<int>("EtniaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimientoAcompanante")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificacionAcompanante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LugarExpedicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LugarExpedicionAcompanante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MunicipioAcompanante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NivelId")
                        .HasColumnType("int");

                    b.Property<string>("Ocupacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OcupacionAcompanante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerApellidoAcompanante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombreAcompanante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegimenId")
                        .HasColumnType("int");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellidoAcompanante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombreAcompanante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoAfiliadoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoSangre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZonaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("Domain.Entities.Paciente", b =>
                {
                    b.OwnsOne("Domain.ValueObject.TipoIdentificacion", "TipoId", b1 =>
                        {
                            b1.Property<int>("PacienteId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Id")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PacienteId");

                            b1.ToTable("Paciente");

                            b1.WithOwner()
                                .HasForeignKey("PacienteId");
                        });

                    b.OwnsOne("Domain.ValueObject.TipoIdentificacion", "TipoIdAcompanante", b1 =>
                        {
                            b1.Property<int>("PacienteId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Id")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PacienteId");

                            b1.ToTable("Paciente");

                            b1.WithOwner()
                                .HasForeignKey("PacienteId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
