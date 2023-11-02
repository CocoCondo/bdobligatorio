namespace proyectobd;

public class CarnetSalud
{
    public int Ci { get; set; }
    public DateTime Fch_Emision { get; set; }
    public DateTime? Fch_Vencimiento { get; set; }
    public byte[] Comprobante { get; set; } // Cambiado a byte[] para almacenar imágenes o archivos

    // Relación con Funcionario
    public Funcionario Funcionario { get; set; }
}