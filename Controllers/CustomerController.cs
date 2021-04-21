using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Handlers;

namespace Shop.Controllers
{
    [ApiController]
    [Route("v1/customer")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<CreateCustomerResponse> Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command
        )
        {
            return await mediator.Send(command);
        }
    }
}