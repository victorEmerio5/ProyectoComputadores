﻿// <auto-generated />
using System;
using MantComputadores.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MantComputadores.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220911182015_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MantComputadores.App.Dominio.CitasAgendadas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("regpersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("regpersonaId");

                    b.ToTable("citasagendadas");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.Historial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("citasagendadasId")
                        .HasColumnType("int");

                    b.Property<int?>("ordenserviciosId")
                        .HasColumnType("int");

                    b.Property<int?>("serviciosprestadosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("citasagendadasId");

                    b.HasIndex("ordenserviciosId");

                    b.HasIndex("serviciosprestadosId");

                    b.ToTable("historiales");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.MedioDePago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Giro")
                        .HasColumnType("bit");

                    b.Property<bool>("Transferencia")
                        .HasColumnType("bit");

                    b.Property<bool>("efectivo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("mediodepagos");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.OrdenServicios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("ComisionTecnico")
                        .HasColumnType("float");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombresCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NonbresTecnico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalPagar")
                        .HasColumnType("float");

                    b.Property<double>("ValorServicio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ordenservicios");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.RegPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("regpersonas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("RegPersona");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.ServiciosPrestados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Piezas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioPiezas")
                        .HasColumnType("float");

                    b.Property<string>("TipoServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("serviciosprestados");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.Administrador", b =>
                {
                    b.HasBaseType("MantComputadores.App.Dominio.RegPersona");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.Cliente", b =>
                {
                    b.HasBaseType("MantComputadores.App.Dominio.RegPersona");

                    b.Property<int>("RazonSocial")
                        .HasColumnType("int");

                    b.Property<int?>("citasagendadasId")
                        .HasColumnType("int");

                    b.HasIndex("citasagendadasId");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.Tecnico", b =>
                {
                    b.HasBaseType("MantComputadores.App.Dominio.RegPersona");

                    b.Property<string>("IdProfesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelAcademico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Tecnico");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.CitasAgendadas", b =>
                {
                    b.HasOne("MantComputadores.App.Dominio.RegPersona", "regpersona")
                        .WithMany()
                        .HasForeignKey("regpersonaId");

                    b.Navigation("regpersona");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.Historial", b =>
                {
                    b.HasOne("MantComputadores.App.Dominio.CitasAgendadas", "citasagendadas")
                        .WithMany()
                        .HasForeignKey("citasagendadasId");

                    b.HasOne("MantComputadores.App.Dominio.OrdenServicios", "ordenservicios")
                        .WithMany()
                        .HasForeignKey("ordenserviciosId");

                    b.HasOne("MantComputadores.App.Dominio.ServiciosPrestados", "serviciosprestados")
                        .WithMany()
                        .HasForeignKey("serviciosprestadosId");

                    b.Navigation("citasagendadas");

                    b.Navigation("ordenservicios");

                    b.Navigation("serviciosprestados");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.Cliente", b =>
                {
                    b.HasOne("MantComputadores.App.Dominio.CitasAgendadas", "citasagendadas")
                        .WithMany()
                        .HasForeignKey("citasagendadasId");

                    b.Navigation("citasagendadas");
                });
#pragma warning restore 612, 618
        }
    }
}
