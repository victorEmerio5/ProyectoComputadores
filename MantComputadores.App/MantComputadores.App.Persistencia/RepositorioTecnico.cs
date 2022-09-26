using System.Collections.Generic;
using System.Linq;
using MantComputadores.App.Dominio;
namespace MantComputadores.App.Persistencia;

public class RepositorioTecnico:IRepositorioTecnico
{
    private readonly AppContext _appContext;
    public RepositorioTecnico(AppContext appContext)
    {
        _appContext=appContext;
    }

    // agregar un Tecnico:
    Tecnico IRepositorioTecnico.AddTecnico(Tecnico tecnico)
    {
        var TecnicoAdicionado = _appContext.tecnicos.Add(tecnico);
        _appContext.SaveChanges();
        return TecnicoAdicionado.Entity;
    }

    // eliminar un Tecnico:
    void IRepositorioTecnico.DeleteTecnico(int IdTecnico)
    {
        var TecnicoEncontrado= _appContext.tecnicos.FirstOrDefault(tecn => tecn.Id==IdTecnico);
        if (TecnicoEncontrado==null)
        return;
        _appContext.tecnicos.Remove(TecnicoEncontrado);
        _appContext.SaveChanges();
        
    }

    // obtener todos los tecnicos:
    IEnumerable<Tecnico> IRepositorioTecnico.GetAllTecnicos()
    {
        return _appContext.tecnicos;
    }

    // obtener un tecnico:

    Tecnico IRepositorioTecnico.GetTecnico(int IdTecnico)
    {
        return _appContext.tecnicos.FirstOrDefault(tecn => tecn.Id==IdTecnico);
        //throw new System.NotImplementedException();
    }

    // actualizar un tecnico:
    Tecnico IRepositorioTecnico.UpdateTecnico(Tecnico tecnico)
    {
        var TecnicoEncontrado = _appContext.tecnicos.FirstOrDefault(tecn => tecn.Id==tecnico.Id);
        if(TecnicoEncontrado != null)
        {
            TecnicoEncontrado.Nombres = tecnico.Nombres;
            TecnicoEncontrado.Apellidos = tecnico.Apellidos;
            TecnicoEncontrado.Direccion = tecnico.Direccion;
            TecnicoEncontrado.NumTelefono = tecnico.NumTelefono;
            TecnicoEncontrado.IdProfesional = tecnico.IdProfesional;
            TecnicoEncontrado.NivelAcademico = tecnico.NivelAcademico;

            _appContext.SaveChanges();
        }
        return TecnicoEncontrado;
    }

}