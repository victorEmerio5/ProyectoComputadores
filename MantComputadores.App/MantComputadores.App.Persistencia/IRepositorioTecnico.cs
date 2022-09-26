using System.Collections.Generic;  //libreria importada
using MantComputadores.App.Dominio;

namespace MantComputadores.App.Persistencia;

public interface IRepositorioTecnico
{
    //firma de los metodos:
    IEnumerable<Tecnico> GetAllTecnicos();
    Tecnico AddTecnico(Tecnico tecnico);
    Tecnico UpdateTecnico (Tecnico tecnico);
    void DeleteTecnico(int IdTecnico);
    Tecnico GetTecnico(int IdTecnico);
}