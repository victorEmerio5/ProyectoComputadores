namespace MantComputadores.App.Dominio;
public class Tecnico:RegPersona
{
    public ServiciosPrestados _serviciosprestados {get; set;} //asociacion entre Tecnico y ServiciosPrestados
    public LogIn _login {get; set;} //asociacion entre Tecnico y LogIn


    public string IdProfesional {get; set;}  //propiedad
    public string NivelAcademico {get; set;}
}