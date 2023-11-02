namespace proyectobd;

using Microsoft.AspNetCore.Mvc;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class FuncionariosController : ControllerBase
{
    private readonly FuncionarioService _funcionarioService;

    public FuncionariosController(FuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }

    [HttpGet("{ci}")]
    public ActionResult<Funcionario> GetFuncionario(int ci)
    {
        var funcionario = _funcionarioService.GetFuncionario(ci);

        if (funcionario == null)
            return NotFound();

        return funcionario;
    }

    [HttpPost]
    public IActionResult CreateFuncionario(Funcionario funcionario)
    {
        _funcionarioService.CreateFuncionario(funcionario);
        return CreatedAtAction(nameof(GetFuncionario), new { ci = funcionario.Ci }, funcionario);
    }

    [HttpGet("{ci}/agenda")]
    public ActionResult<IQueryable<Agenda>> GetAgenda(int ci)
    {
        var agendas = _funcionarioService.GetAgenda(ci);

        if (agendas == null)
            return NotFound();

        return Ok(agendas);
    }
    // Puedes agregar más acciones según tus necesidades
}
