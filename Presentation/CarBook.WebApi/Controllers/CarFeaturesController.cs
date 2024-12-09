using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CarFeatureListByCarId(int id)
        {
            var values = await _mediator.Send(new GetCarFeatureByCarIdQuery(id));
            return Ok(values);
        }
        [HttpGet("CarFeaturesAvailableChangeToFalse")]
        public async Task<IActionResult> CarFeaturesAvailableChangeToFalse(int id)
        {
            _mediator.Send(new UpdateCarFeaturesAvailableChangeToFalseCommand(id));
            return Ok("Güncelleme Yapıldı");
        }
        [HttpGet("CarFeaturesAvailableChangeToTrue")]
        public async Task<IActionResult> CarFeaturesAvailableChangeToTrue(int id)
        {
            _mediator.Send(new UpdateCarFeaturesAvailableChangeToTrueCommand(id));
            return Ok("Güncelleme Yapıldı");
        }
        [HttpPost]
        public async Task<IActionResult> CreateCarFeatureByCarId(CreateCarFeatureByCarCommand command)
        {
            _mediator.Send(command);
            return Ok("Ekleme Yapıldı");
    
        }
    }
}
