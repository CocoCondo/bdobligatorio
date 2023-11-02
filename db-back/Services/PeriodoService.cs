namespace proyectobd;

using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class PeriodoService
{
    private readonly ApplicationDbContext _context;

    public PeriodoService(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<PeriodoActualizacion> GetPeriodos()
    {
        return _context.PeriodosActualizacion.ToList();
    }

    public void CreatePeriodo(PeriodoActualizacion periodo)
    {
        _context.PeriodosActualizacion.Add(periodo);
        _context.SaveChanges();
    }

    public void UpdatePeriodo(PeriodoActualizacion periodo)
    {
        _context.PeriodosActualizacion.Update(periodo);
        _context.SaveChanges();
    }

    public void DeletePeriodo(int año, int semestre)
    {
        var periodo = _context.PeriodosActualizacion.FirstOrDefault(p => p.Año == año && p.Semestre == semestre);

        if (periodo != null)
        {
            _context.PeriodosActualizacion.Remove(periodo);
            _context.SaveChanges();
        }
    }

    // Puedes agregar más métodos según tus necesidades
}
