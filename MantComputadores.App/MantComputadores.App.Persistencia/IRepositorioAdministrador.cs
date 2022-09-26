using System.Collections.Generic;  //libreria importada
using MantComputadores.App.Dominio;

namespace MantComputadores.App.Persistencia;

public interface IRepositorioAdministrador
{
    //firma de los metodos:
    IEnumerable<Administrador> GetAllAdministradores();
    Administrador AddAdministrador(Administrador administrador);
    Administrador UpdateAdministrador (Administrador administrador);
    void DeleteAdministrador(int IdAdministrador);
    Administrador GetAdministrador(int IdAdministrador);
}