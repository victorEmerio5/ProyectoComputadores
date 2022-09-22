namespace MantComputadores.App.Dominio;
public class OrdenServicios
{
    public int Id {get; set;}
    public string Fecha {get; set;}
    public string NombresCliente {get; set;}
    public string NonbresTecnico{get; set;}
    public string Horario {get; set;}
    public string TipoServicio {get; set;}
    public double ValorServicio {get; set;}
    public double ComisionTecnico {get; set;}
    public double TotalPagar {get; set;}
}