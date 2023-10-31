namespace proyectobd;

using System.Linq;
using Microsoft.EntityFrameworkCore;

public class FuncionarioService
{
    private readonly ApplicationDbContext _context;

    public FuncionarioService(ApplicationDbContext context)
    {
        _context = context;
    }

    public Funcionario GetFuncionario(int ci)
    {
        return _context.Funcionarios.FirstOrDefault(f => f.Ci == ci);
    }

    public void CreateFuncionario(Funcionario funcionario)
    {
        _context.Funcionarios.Add(funcionario);
        _context.SaveChanges();
    }

    public IQueryable<Agenda> GetAgenda(int ci)
    {
        return _context.Agendas.Where(a => a.Ci == ci);
    }

    // Puedes agregar más métodos según tus necesidades
}
