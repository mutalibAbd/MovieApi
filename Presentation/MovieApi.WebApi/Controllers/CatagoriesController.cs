using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Aplication.Features.CQRSDesignPattern.Commands.CatagoryCommands;
using MovieApi.Aplication.Features.CQRSDesignPattern.Handlers.CatagoryHandlers;
using MovieApi.Aplication.Features.CQRSDesignPattern.Queries.CatagoryQueries;
using MovieApi.Domain.Entites;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoriesController : ControllerBase
    {
        private readonly CreatCatagoryCommandHandler _creatCatagoryCommandHandler;
        private readonly RemoveCatagoryCommandHandler _removeCatagoryCommandHandler;
        private readonly UpdateCatagoryCommandHandler _updateCatagoryCommandHandler;
        private readonly GetCatagoryQueryHandler _getCatagoryQueryHandler;
        private readonly GetCatagoryByIdQueryHandler _getCatagoryByIdQueryHandler;

        public CatagoriesController(CreatCatagoryCommandHandler creatCatagoryCommandHandler, RemoveCatagoryCommandHandler removeCatagoryCommandHandler, UpdateCatagoryCommandHandler updateCatagoryCommandHandler, GetCatagoryQueryHandler getCatagoryQueryHandler, GetCatagoryByIdQueryHandler getCatagoryByIdQueryHandler)
        {
            _creatCatagoryCommandHandler = creatCatagoryCommandHandler;
            _removeCatagoryCommandHandler = removeCatagoryCommandHandler;
            _updateCatagoryCommandHandler = updateCatagoryCommandHandler;
            _getCatagoryQueryHandler = getCatagoryQueryHandler;
            _getCatagoryByIdQueryHandler = getCatagoryByIdQueryHandler;
        }

        [HttpGet]

        public async Task<IActionResult> CatagoryList()
        {
            var value = await _getCatagoryQueryHandler.Handle();
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreateCatagory(AddCatagoryCommand command)
        {
            await _creatCatagoryCommandHandler.Handle(command);
            return Ok("Katagori yaratma basarili");
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteCatagory(int id)
        {
            await _removeCatagoryCommandHandler.Hanlder(new RemoveCatagoryCommand(id));
            return Ok("basariyla silindi");
        }

        [HttpPut]

        public async Task<IActionResult> UpdateCatagory(UpdateCatagoryCommand command)
        {
            await _updateCatagoryCommandHandler.Handle(command);
            return Ok("basarili");
        }

        [HttpGet("GetCatagoryByID")]

        public async Task<IActionResult> GetCatagoryById(int id)
        {
            var value = await _getCatagoryByIdQueryHandler.Handle(new GetCatagoryByIdQuery(id));
            return Ok( value);
        }                                             
    }
}
