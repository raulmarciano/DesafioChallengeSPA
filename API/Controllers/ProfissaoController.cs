using System.Threading.Tasks;
using DesafioChallengeSPA.Data;
using System.Collections.Generic;
using DesafioChallengeSPA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioChallengeSPA.Controllers
{
    [Route("profissoes")]
    public class ProfissaoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Profissao>>> Get(
            [FromServices]DataContext context)
        {
            var profissao = await context.Profissoes.AsNoTracking().ToListAsync();
            return Ok(profissao);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Profissao>> Get(
            int id,
            [FromServices]DataContext context)
        {
            var profissao = await context.Profissoes.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            return Ok(profissao);
        }
    }
}