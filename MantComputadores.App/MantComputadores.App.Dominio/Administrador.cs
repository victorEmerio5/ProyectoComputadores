namespace MantComputadores.App.Dominio;
public class Administrador:RegPersona
{
    public Historial _historial {get; set;}  //asociacion entre Administrador e Historial
    public OrdenServicios _ordenservicios {get; set;}  //asociacion entre Administrador y OrdenServicios
    
    //private Historial _historial;  // relacion de agregacion entre Administrador e Historial
}