namespace proyectobd;

using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Login> Logins { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Agenda> Agendas { get; set; }
    public DbSet<CarnetSalud> CarnetSaluds { get; set; }
    public DbSet<PeriodoActualizacion> PeriodosActualizacion { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuración de relaciones y restricciones
        modelBuilder.Entity<Funcionario>()
            .HasOne(f => f.Login)
            .WithMany()
            .HasForeignKey(f => f.LogId);

        modelBuilder.Entity<Agenda>()
            .HasOne(a => a.Funcionario)
            .WithMany(f => f.Agendas)
            .HasForeignKey(a => a.Ci);

        modelBuilder.Entity<CarnetSalud>()
            .HasOne(cs => cs.Funcionario)
            .WithOne(f => f.CarnetSalud)
            .HasForeignKey<CarnetSalud>(cs => cs.Ci);

        // Puedes agregar más configuraciones según sea necesario

        base.OnModelCreating(modelBuilder);
    }
}
