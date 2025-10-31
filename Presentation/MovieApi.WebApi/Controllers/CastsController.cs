using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Aplication.Features.CQRSDesignPattern.Results.MovieResults;
using MovieApi.Aplication.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Aplication.Features.MediatorDesignPattern.Queries.CastQuery;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CastList()
        {
            var value = await _mediator.Send(new GetCastQuery());
            return Ok(value);
        }

        [HttpDelete]

        public async Task<IActionResult> Delete(int id)
        {

            await _mediator.Send(new RemoveCastCommand(id));
            return Ok("silme basarili");
        }

        [HttpPost]

        public async Task<IActionResult>  Post(CreateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Basarili");
        }

        [HttpPut]

        public async Task<IActionResult> Update(UpdateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Basarili");

        }

        [HttpGet("ById")]

        public async Task<IActionResult> GetById(int id)
        {
           var value = await _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }
    }

}