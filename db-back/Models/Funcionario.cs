namespace proyectobd;

public class Funcionario
{
    public int Ci { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime Fch_Nacimiento { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }

    // Relación con Login
    public int LogId { get; set; }
    public Login Login { get; set; }

    // Relación con Agenda
    public List<Agenda> Agendas { get; set; }

    // Relación con CarnetSalud
    public CarnetSalud CarnetSalud { get; set; }
}
