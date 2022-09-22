namespace MantComputadores.App.Dominio;
public class CitasAgendadas
{
    //public Cliente cliente {get; set;}  //asociacion entre CitasAgendadas y Cliente
    public RegPersona regpersona {get; set;}  //asociacion entre CitasAgendadas y RegPersona

    public int Id {get; set;}
    public string Fecha {get; set;}
    public string Hora {get; set;}
    public string TipoServicio {get; set;}
}