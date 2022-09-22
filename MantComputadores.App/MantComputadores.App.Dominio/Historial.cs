namespace MantComputadores.App.Dominio;
public class Historial
{
    public CitasAgendadas citasagendadas {get; set;}  //asociacion entre Historial y CitasAgendadas
    public ServiciosPrestados serviciosprestados {get; set;} //asociacion entre Historial y ServiciosPrestados
    public OrdenServicios ordenservicios {get; set;}  //asociacion entre Historial y OrdenServicios

    public int Id {get; set;}
    public string Fecha {get; set;}
    
}