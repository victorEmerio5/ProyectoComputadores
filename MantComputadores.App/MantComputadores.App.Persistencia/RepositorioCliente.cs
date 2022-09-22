/*using System.Collections.Generic;
using System.Linq;
using MantComputadores.App.Dominio;
namespace MantComputadores.App.Persistencia;

public class RepositorioCliente:IRepositorioCliente
{
    private readonly AppContext _appContext;
    public RepositorioCliente(AppContext appContext)
    {
        _appContext=appContext;
    }

    // adicionar un cliente:
    Cliente IRepositorioCliente.AddCliente(Cliente cliente)
    {
        var ClienteAdicionado = _appContext.clientes.Add(Cliente);
        _appContext.SaveChanges();
        return ClienteAdicionado.Entity;
    }

    // eliminar un cliente:
    void IRepositorioCliente.DeleteCliente(int IdCliente)
    {
        var ClienteEncontrado= _appContext.clientes.FirstOrDefault(client => client.Id==IdCliente);
        if (ClienteEncontrado==null)
        return;
        _appContext.clientes.Remove(ClienteEncontrado);
        _appContext.SaveChanges();
        
    }

    // obtener todos los clientes:
    IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
    {
        return _appContext.clientes;
    }

    // obtener un cliente:

    Cliente IRepositorioCliente.GetCliente(int IdCliente)
    {
        return _appContext.clientes.FirstOrDefault(client => client.Id==IdCliente);
        //throw new System.NotImplementedException();
    }

    // actualizar un cliente:
    Cliente IRepositorioCliente.UpdateCliente(Cliente Cliente)
    {
        var ClienteEncontrado = _appContext.clientes.FirstOrDefault(client => client.Id==Client.Id);
        if(ClienteEncontrado != null)
        {
            ClienteEncontrado.Nombres = Cliente.Nombres;
            ClienteEncontrado.Apellidos = Cliente.Apellidos;
            ClienteEncontrado.Direccion = Cliente.Direccion;
            ClienteEncontrado.NumTelefono = Cliente.NumTelefono;

            _appContext.SaveChanges();
        }
        return ClienteEncontrado;
    }

}*/