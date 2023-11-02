namespace proyectobd;

public class Agenda
{
    public int Nro { get; set; }
    public int Ci { get; set; }
    public DateTime Fch_Agenda { get; set; }

    // Relación con Funcionario
    public Funcionario Funcionario { get; set; }
}