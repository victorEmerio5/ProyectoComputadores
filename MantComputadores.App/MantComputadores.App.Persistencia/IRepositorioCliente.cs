using System.Collections.Generic;  //libreria importada
//using System.Linq;
using MantComputadores.App.Dominio;

namespace MantComputadores.App.Persistencia;

public interface IRepositorioCliente
{
    //firma de los metodos:
    IEnumerable<Cliente> GetAllClientes();
    Cliente AddCliente(Cliente cliente);
    Cliente UpdateCliente (Cliente cliente);
    void DeleteCliente(int IdCliente);
    Cliente GetCliente(int IdCliente);
}