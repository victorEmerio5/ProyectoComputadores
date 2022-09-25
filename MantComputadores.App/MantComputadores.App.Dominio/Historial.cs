namespace MantComputadores.App.Dominio;
public class Historial
{
    public CitasAgendadas _citasagendadas {get; set;}  //asociacion entre Historial y CitasAgendadas
    public ServiciosPrestados _serviciosprestados {get; set;} //asociacion entre Historial y ServiciosPrestados
    public OrdenServicios _ordenservicios {get; set;}  //asociacion entre Historial y OrdenServicios

    public int Id {get; set;}
    public string Fecha {get; set;}
    
}