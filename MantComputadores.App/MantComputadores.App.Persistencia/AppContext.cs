using Microsoft.EntityFrameworkCore;
using MantComputadores.App.Dominio;
namespace MantComputadores.App.Persistencia;
public class AppContext:DbContext
{
    public DbSet<RegPersona> regpersonas {get; set;} //propiedades DbSet
    public DbSet<Administrador> administradores {get; set;}
    public DbSet<CitasAgendadas> citasagendadas {get; set;}
    public DbSet<Cliente> clientes {get; set;}
    public DbSet<Historial> historiales {get; set;}
    public DbSet<LogIn> login {get; set;}
    public DbSet<MedioDePago> mediodepagos {get; set;}
    public DbSet<OrdenServicios> ordenservicios {get; set;}
    public DbSet<ServiciosPrestados> serviciosprestados {get; set;}
    public DbSet<Tecnico> tecnicos {get; set;}

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  //conexion con el servidor
{
    if(!optionsBuilder.IsConfigured)
    {
        optionsBuilder
        .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MantComputadores.Data");
    }
}
}

