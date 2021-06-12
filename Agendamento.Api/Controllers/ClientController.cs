using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.Data;
using Agendamento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.Api.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Client>>> Get(
            [FromServices] DataContext context
        ){
            try
            {
                return await context.Clients.AsNoTracking().ToListAsync();

            }
            catch (System.Exception e)
            {
                
                return BadRequest(new { message = e.Message, stacktrace = e.StackTrace });
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Client>> GetById(
            int id,
            [FromServices] DataContext context
        ){
            try
            {
                return await context.Clients.AsNoTracking().SingleOrDefaultAsync();

            }
            catch (System.Exception e)
            {
                
                return BadRequest(new { message = e.Message, stacktrace = e.StackTrace });
            }
        }



        [HttpPost]
        public async Task<ActionResult<Client>> Post(
            [FromBody]Client model,
            [FromServices] DataContext context
        ){
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            try
            {
                context.Clients.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch (System.Exception e)
            {
                return BadRequest( new { message = e.Message, stacktrace = e.StackTrace } );
            }
           
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Client>> Put(
            int id,
            [FromBody]Client model,
            [FromServices] DataContext context
        ){
            if(!ModelState.IsValid)
                return BadRequest(model);

            try
            {
                context.Entry<Client>(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch (System.Exception e)
            {
                 return BadRequest( new { message = e.Message, stacktrace = e.StackTrace } );
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Client>> Delete(
            Guid id, 
            [FromServices] DataContext context
        ){
           var client = await context.Clients.FirstOrDefaultAsync(c => c.Id == id);

           if(client == null){
               return NotFound( new { message = "Cliente não encontrado" } );
           }
            

            try
            {
                context.Clients.Remove(client);
                await context.SaveChangesAsync();
                return Ok(new { message = "cliente removido com sucesso" });


            }
            catch (System.Exception e)
            {
                return BadRequest( new { message = e.Message, stacktrace = e.StackTrace } );
            }
        }
    }
}