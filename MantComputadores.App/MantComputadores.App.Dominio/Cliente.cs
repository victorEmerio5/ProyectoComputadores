namespace MantComputadores.App.Dominio;
public class Cliente:RegPersona
{
    public MedioDePago _mediodepago {get; set;}  // asociacion entre Cliete y MedioDePago
    public CitasAgendadas _citasagendadas {get; set;}  //asociacion entre Cliente y CitasAgendadas
    public LogIn _login {get; set;}  //asociacion entre Cliente y LogIn
    
    public string RazonSocial {get; set;}
}