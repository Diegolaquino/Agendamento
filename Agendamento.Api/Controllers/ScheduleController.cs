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
    [Route("schedules")]
    public class ScheduleController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Schedule>>> Get(
            [FromServices] DataContext context
        ){
            try
            {
                return await context.Schedules.AsNoTracking().ToListAsync();

            }
            catch (System.Exception e)
            {
                
                return BadRequest(new { message = e.Message, stacktrace = e.StackTrace });
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Schedule>> GetById(
            int id,
            [FromServices] DataContext context
        ){
            try
            {
                return await context.Schedules.AsNoTracking().SingleOrDefaultAsync();

            }
            catch (System.Exception e)
            {
                
                return BadRequest(new { message = e.Message, stacktrace = e.StackTrace });
            }
        }



        [HttpPost]
        public async Task<ActionResult<Schedule>> Post(
            [FromBody]Schedule model,
            [FromServices] DataContext context
        ){
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            try
            {
                context.Schedules.Add(model);
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
        public async Task<ActionResult<Schedule>> Put(
            int id,
            [FromBody]Schedule model,
            [FromServices] DataContext context
        ){
            if(!ModelState.IsValid)
                return BadRequest(model);

            try
            {
                context.Entry<Schedule>(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch (System.Exception e)
            {
                 return BadRequest( new { message = e.Message, stacktrace = e.StackTrace } );
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<ActionResult<Schedule>> Delete(
            Guid id, 
            [FromServices] DataContext context
        ){
           var schedule = await context.Schedules.FirstOrDefaultAsync(c => c.Id == id);

           if(schedule == null){
               return NotFound( new { message = "Agendamento não encontrado" } );
           }
            

            try
            {
                context.Schedules.Remove(schedule);
                await context.SaveChangesAsync();
                return Ok(new { message = "Agendamento removido com sucesso" });


            }
            catch (System.Exception e)
            {
                return BadRequest( new { message = e.Message, stacktrace = e.StackTrace } );
            }
        }
    }
}