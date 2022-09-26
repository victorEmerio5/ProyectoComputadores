using System.Collections.Generic;
using System.Linq;
using MantComputadores.App.Dominio;  // apuntando a la capa del Dominio
namespace MantComputadores.App.Persistencia;

public class RepositorioAdministrador:IRepositorioAdministrador
{
    private readonly AppContext _appContext;
    public RepositorioAdministrador(AppContext appContext)
    {
        _appContext=appContext;
    }

    // adicionar un Administrador:
    Administrador IRepositorioAdministrador.AddAdministrador(Administrador administrador)
    {
        var AdministradorAdicionado = _appContext.administradores.Add(administrador);
        _appContext.SaveChanges();
        return AdministradorAdicionado.Entity;
    }

    // eliminar un Administrador:
    void IRepositorioAdministrador.DeleteAdministrador(int IdAdministrador)
    {
        var AdministradorEncontrado= _appContext.administradores.FirstOrDefault(admin => admin.Id==IdAdministrador);
        if (AdministradorEncontrado==null)
        return;
        _appContext.administradores.Remove(AdministradorEncontrado);
        _appContext.SaveChanges();
        
    }

    // obtener todos los Administradores:
    IEnumerable<Administrador> IRepositorioAdministrador.GetAllAdministradores()
    {
        return _appContext.administradores;
    }

    // obtener un Administrador:

    Administrador IRepositorioAdministrador.GetAdministrador(int IdAdministrador)
    {
        return _appContext.administradores.FirstOrDefault(admin => admin.Id==IdAdministrador);
        //throw new System.NotImplementedException();
    }

    // actualizar un Administrador:
    Administrador IRepositorioAdministrador.UpdateAdministrador(Administrador administrador)
    {
        var AdministradorEncontrado = _appContext.administradores.FirstOrDefault(admin => admin.Id==administrador.Id);
        if(AdministradorEncontrado != null)
        {
            AdministradorEncontrado.Nombres = administrador.Nombres;
            AdministradorEncontrado.Apellidos = administrador.Apellidos;
            AdministradorEncontrado.Direccion = administrador.Direccion;
            AdministradorEncontrado.NumTelefono = administrador.NumTelefono;

            _appContext.SaveChanges();
        }
        return AdministradorEncontrado;
    }

}