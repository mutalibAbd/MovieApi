using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Aplication.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.MovieHandlers;
using MovieApi.Aplication.Features.CQRSDesignPattern.Queries.MovieQuery;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly CreatMovieCommandHandleer _createMovieCommandController;
        private readonly GetMovieByIdQueryHandlers _getMovieByIdQueryHandler;
        private readonly GetMovieQueryHandler _getMovieQueryHandler;
        private readonly RemoveMovieCommandHandler _removeMovieCommandHandler;
        private readonly UpdateMoviecommandHandler _updateMoviecommandHandler;

        public MovieController(CreatMovieCommandHandleer createMovieCommandController, 
            GetMovieByIdQueryHandlers getMovieByIdQueryHandler, GetMovieQueryHandler getMovieQueryHandler,
            RemoveMovieCommandHandler removeMovieCommandHandler, UpdateMoviecommandHandler updateMoviecommandHandler)
        {
            _createMovieCommandController = createMovieCommandController;
            _getMovieByIdQueryHandler = getMovieByIdQueryHandler;
            _getMovieQueryHandler = getMovieQueryHandler;
            _removeMovieCommandHandler = removeMovieCommandHandler;
            _updateMoviecommandHandler = updateMoviecommandHandler;
        }

        [HttpGet]

        public async Task<IActionResult> MoviesList()
        {
            var value =  await _getMovieQueryHandler.Handler();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(AddMovieCommands command)
        {
            await _createMovieCommandController.Handle(command);
            return Ok("Yeni hazir");    
        }

        

        [HttpPut]

        public async Task<IActionResult> UpdateMovie(UpdateMovieCommands command)
        {
            await _updateMoviecommandHandler.handle(command);
            return Ok("Basarili");
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _removeMovieCommandHandler.Handle(new RemoveMovieCommands(id));
            return Ok("Basariyla silindi");
        }

        [HttpGet("MovieGetById")]

        public async Task<IActionResult> GetMovieById(int id)
        {
            var value = await _getMovieByIdQueryHandler.Handle(new GetMovieByIdQuery(id));
            if (value != null)
            {
                return Ok(value);
            }
            else
            {
                return BadRequest("Yokki");
            }
        }
    }
}
