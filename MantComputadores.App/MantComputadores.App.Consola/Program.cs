// See https://aka.ms/new-console-template for more information
using MantComputadores.App.Dominio;
using MantComputadores.App.Persistencia;
namespace MantComputadores.App.consola;

class program
{
    private static IRepositorioCliente _RepoCliente = new RepositorioCliente(new Persistencia.AppContext());  //referencia al repositorio atraves de la interfaz
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        AddCliente();  // llamada al metodo AddCliente
    }
    private static void AddCliente()  // metodo AddCliente
    {
        var cliente = new Cliente  //instancia de la entidad Cliente
        {
            Nombres = "Karla Naomi",
            Apellidos = "Asprilla Turbai",
            Direccion = "Leticia Cra 4 23-10",
            NumTelefono = "9605647",
            RazonSocial = "Colmaquinas"
        };
        _RepoCliente.AddCliente(cliente);  //llamada a _RepoPaciente
    }
}

