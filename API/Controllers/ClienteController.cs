using System;
using System.Threading.Tasks;
using DesafioChallengeSPA.Data;
using DesafioChallengeSPA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DesafioChallengeSPA.Controllers
{
    [Route("clientes")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Cliente>>> Get(
            [FromServices]DataContext context)
        {
            var clientes = await context.Clientes.Include(p => p.Profissao).AsNoTracking().ToListAsync();
            return Ok(clientes);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Cliente>> GetPorId(
            int id,
            [FromServices]DataContext context)
        {
            var clientes = await context.Clientes.Include(p => p.Profissao).AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
            return Ok(clientes);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Cliente>> Post(
            [FromBody]Cliente model,
            [FromServices]DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                context.Clientes.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível criar cliente" } );
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Cliente>> Put (
            int id,
            [FromBody]Cliente model,
            [FromServices]DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                context.Entry<Cliente>(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch (DbUpdateConcurrencyException)
            {
               return BadRequest(new { message = "Este registro já foi atualizado" });
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Não foi possível atualizar" });
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Cliente>> Delete(
            int id,
            [FromServices]DataContext context
        )
        {
            var cliente = context.Clientes.FirstOrDefaultAsync(c => c.Id == id).Result;

            if (cliente == null)
                return NotFound(new { message = "Cliente não encontrado "});

            try
            {
                context.Clientes.Remove(cliente);
                await context.SaveChangesAsync();
                return Ok(new { message = "Cliente removido" });
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível remover"} );
            }
        }
    }
}