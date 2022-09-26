// See https://aka.ms/new-console-template for more information
using MantComputadores.App.Dominio;
using MantComputadores.App.Persistencia;
namespace MantComputadores.App.consola;

class program  // dentro de esta clase, agregamos las entidades
{
    private static IRepositorioCliente _RepoCliente = new RepositorioCliente(new Persistencia.AppContext());  //referencia al repositorio atraves de la interfaz
    static void Main(string[] args)
    {
        Console.WriteLine("agregando entidades a la base de datos");
        //AddCliente();  // llamada al metodo AddCliente
        AddTecnico();  //llamada al metodo AddTecnico
    }
    private static void AddCliente()  // metodo AddCliente
    {
        var cliente = new Cliente  //instancia de la entidad Cliente
        {
            Nombres = "Karla Naomi",  //atributos de la clase Tecnico
            Apellidos = "Asprilla Turbai",
            Direccion = "Leticia Cra 4 23-10",
            NumTelefono = "9605647",
            RazonSocial = "Colmaquinas"
        };
        _RepoCliente.AddCliente(cliente);  //llamada a _RepoPaciente
    }
    //-------------------------------------------------------------------------------------------------
    private static IRepositorioTecnico _RepoTecnico = new RepositorioTecnico(new Persistencia.AppContext());
    private static void AddTecnico()  // metodo AddTecnico
    {
        var tecnico = new Tecnico  //instancia de la entidad Tecnico
        {
            Nombres = "Sandro Miguel",
            Apellidos = "Boce Miranda",
            Direccion = "Bogota Cra 8 43-21",
            NumTelefono = "7564329",
            IdProfesional = "xy43232",
            NivelAcademico = "Tecnologo",
        };
        _RepoTecnico.AddTecnico(tecnico);  //llamada a _RepoTecnico
    }
    //---------------------------------------------------------------------------------------------------
}

