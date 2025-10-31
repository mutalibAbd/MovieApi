using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Aplication.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApi.Aplication.Features.MediatorDesignPattern.Handlers.TagHandlers;
using MovieApi.Aplication.Features.MediatorDesignPattern.Queries.TagQuery;
//mediator ile
namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {

        private readonly IMediator mediator;

        public TagsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]

        public async Task<IActionResult>  ListTags()
        {
            var value = await mediator.Send(new GetTagQuery());
            return Ok(value);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
            await  mediator.Send(command);
            return Ok("Updated");
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteTag(int id)
        {
           await  mediator.Send(new RemoveTagCommand(id));
            return Ok("deleted");
        }

        [HttpPost]

        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            await mediator.Send(command);
            return Ok("Created");
        }

        [HttpGet("ById")]
        public async Task<IActionResult> GetTagById(int id)
        {

            var value = await mediator.Send(new GetTagByIdQuery(id));
            return Ok(value);
        }
    }
}
