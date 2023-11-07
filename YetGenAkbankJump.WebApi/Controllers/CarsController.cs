using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using YetGenAkbankJump.Shared.Helpers;
using YetGenAkbankJump.WebApi.Data;

namespace YetGenAkbankJump.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IStringLocalizer<CommonTranslations> _localizer;

        public CarsController(IStringLocalizer<CommonTranslations> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cars = CarsContext.LuxuryCars.ToList();

            return Ok(cars);
        }

        [HttpGet("WelcomeMessage")]
        public IActionResult WelcomeMessage()
        {
            return Ok(_localizer["WelcomeMessage"]);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {

            if (id == Guid.Empty)
                // Id cannot be empty
                return BadRequest(_localizer["IdCannotBeNull"]);

            var car = CarsContext.LuxuryCars.FirstOrDefault(x=>x.Id == id);

            if (car is null)
                return NotFound("The car requested with given Id was not found.");

            return Ok(car);
        }
    }
}
