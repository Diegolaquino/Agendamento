using Microsoft.AspNetCore.Mvc;

namespace Agendamento.Api.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public string Get(){
            return "Order Get";
        }

        [HttpPost]
        public string Post(){
            return "Order Post";
        }

        [HttpPut]
        public string Put(){
            return "Order Put";
        }

        [HttpDelete]
        public string Delete(){
            return "order Delete";
        }
    }
}