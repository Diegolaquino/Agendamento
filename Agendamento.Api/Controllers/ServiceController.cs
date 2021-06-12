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
    [Route("services")]
    public class ServiceController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Service>>> Get(
            [FromServices] DataContext context
        ){
            try
            {
                return await context.Services.AsNoTracking().ToListAsync();

            }
            catch (System.Exception e)
            {
                
                return BadRequest(new { message = e.Message, stacktrace = e.StackTrace });
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Service>> GetById(
            int id,
            [FromServices] DataContext context
        ){
            try
            {
                return await context.Services.AsNoTracking().SingleOrDefaultAsync();

            }
            catch (System.Exception e)
            {
                
                return BadRequest(new { message = e.Message, stacktrace = e.StackTrace });
            }
        }



        [HttpPost]
        public async Task<ActionResult<Service>> Post(
            [FromBody]Service model,
            [FromServices] DataContext context
        ){
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            try
            {
                context.Services.Add(model);
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
        public async Task<ActionResult<Service>> Put(
            int id,
            [FromBody]Service model,
            [FromServices] DataContext context
        ){
            if(!ModelState.IsValid)
                return BadRequest(model);

            try
            {
                context.Entry<Service>(model).State = EntityState.Modified;
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
        public async Task<ActionResult<Service>> Delete(
            Guid id, 
            [FromServices] DataContext context
        ){
           var service = await context.Services.FirstOrDefaultAsync(c => c.Id == id);

           if(service == null){
               return NotFound( new { message = "Serviço não encontrado" } );
           }
            

            try
            {
                context.Services.Remove(service);
                await context.SaveChangesAsync();
                return Ok(new { message = "Serviço removido com sucesso" });


            }
            catch (System.Exception e)
            {
                return BadRequest( new { message = e.Message, stacktrace = e.StackTrace } );
            }
        }
    }
}