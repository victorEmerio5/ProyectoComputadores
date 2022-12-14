// <auto-generated />
using System;
using MantComputadores.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MantComputadores.App.Persistencia.Migrations
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

                    b.Property<int?>("_citasagendadasId")
                        .HasColumnType("int");

                    b.Property<int?>("_ordenserviciosId")
                        .HasColumnType("int");

                    b.Property<int?>("_serviciosprestadosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("_citasagendadasId");

                    b.HasIndex("_ordenserviciosId");

                    b.HasIndex("_serviciosprestadosId");

                    b.ToTable("historiales");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.LogIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("login");
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

                    b.Property<int?>("_historialId")
                        .HasColumnType("int");

                    b.Property<int?>("_ordenserviciosId")
                        .HasColumnType("int");

                    b.HasIndex("_historialId");

                    b.HasIndex("_ordenserviciosId");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.Cliente", b =>
                {
                    b.HasBaseType("MantComputadores.App.Dominio.RegPersona");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("_citasagendadasId")
                        .HasColumnType("int");

                    b.Property<int?>("_loginId")
                        .HasColumnType("int");

                    b.Property<int?>("_mediodepagoId")
                        .HasColumnType("int");

                    b.HasIndex("_citasagendadasId");

                    b.HasIndex("_loginId");

                    b.HasIndex("_mediodepagoId");

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

                    b.Property<int?>("_loginId")
                        .HasColumnType("int")
                        .HasColumnName("Tecnico__loginId");

                    b.Property<int?>("_serviciosprestadosId")
                        .HasColumnType("int");

                    b.HasIndex("_loginId");

                    b.HasIndex("_serviciosprestadosId");

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
                    b.HasOne("MantComputadores.App.Dominio.CitasAgendadas", "_citasagendadas")
                        .WithMany()
                        .HasForeignKey("_citasagendadasId");

                    b.HasOne("MantComputadores.App.Dominio.OrdenServicios", "_ordenservicios")
                        .WithMany()
                        .HasForeignKey("_ordenserviciosId");

                    b.HasOne("MantComputadores.App.Dominio.ServiciosPrestados", "_serviciosprestados")
                        .WithMany()
                        .HasForeignKey("_serviciosprestadosId");

                    b.Navigation("_citasagendadas");

                    b.Navigation("_ordenservicios");

                    b.Navigation("_serviciosprestados");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.Administrador", b =>
                {
                    b.HasOne("MantComputadores.App.Dominio.Historial", "_historial")
                        .WithMany()
                        .HasForeignKey("_historialId");

                    b.HasOne("MantComputadores.App.Dominio.OrdenServicios", "_ordenservicios")
                        .WithMany()
                        .HasForeignKey("_ordenserviciosId");

                    b.Navigation("_historial");

                    b.Navigation("_ordenservicios");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.Cliente", b =>
                {
                    b.HasOne("MantComputadores.App.Dominio.CitasAgendadas", "_citasagendadas")
                        .WithMany()
                        .HasForeignKey("_citasagendadasId");

                    b.HasOne("MantComputadores.App.Dominio.LogIn", "_login")
                        .WithMany()
                        .HasForeignKey("_loginId");

                    b.HasOne("MantComputadores.App.Dominio.MedioDePago", "_mediodepago")
                        .WithMany()
                        .HasForeignKey("_mediodepagoId");

                    b.Navigation("_citasagendadas");

                    b.Navigation("_login");

                    b.Navigation("_mediodepago");
                });

            modelBuilder.Entity("MantComputadores.App.Dominio.Tecnico", b =>
                {
                    b.HasOne("MantComputadores.App.Dominio.LogIn", "_login")
                        .WithMany()
                        .HasForeignKey("_loginId");

                    b.HasOne("MantComputadores.App.Dominio.ServiciosPrestados", "_serviciosprestados")
                        .WithMany()
                        .HasForeignKey("_serviciosprestadosId");

                    b.Navigation("_login");

                    b.Navigation("_serviciosprestados");
                });
#pragma warning restore 612, 618
        }
    }
}
